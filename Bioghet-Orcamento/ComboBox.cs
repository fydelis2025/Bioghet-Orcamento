using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Bioghet_Orcamento
{
    public partial class ComboBox : System.Windows.Forms.ComboBox
    {

        public ComboBox()
        {
            //InitializeComponent();
            EnabledChanged += FlatComboBox_EnabledChanged;
            Timer.Interval = 20;
            Timer.Enabled = true;
        }
         #region " Globals "
    //Enum with all the possible styles
    public enum styles
    {
        officeXP,
        office2003
    }

    //Enum with all the possible states
    public enum states
    {
        normal,
        focused,
        dropeddown,
        disabled
    }

    //Variable to save the current style
    styles style = styles.officeXP;
    //Variable to save the current state
    states state = states.normal;
    //All the pen and brushes needed 
    Pen BorderPen;
    Brush ArrowBrush;
    Brush ButtonBrush;
    Brush TextBrush;
    //The rectangle, surounding the hole control
    Rectangle MainRect;
    //The rectangle, surounding the hole button
    Rectangle ButtonSurRect;
    //The rectangle for the button
    Rectangle ButtonRect;
    //The three points of the arrow
    PointF[] pntArrow = new PointF[3];
    //The middle of the button, used to center the arrow
    int VerticalMiddle;
    //The path for the arrow
    GraphicsPath ArrowPath = new GraphicsPath();
    //The location for drawing the text (in case dropdownstyle=dropdownlist)
    PointF TextLocation;
    //The graphics
    #endregion
    Graphics g;

    #region " Listener "

    protected override void WndProc(ref System.Windows.Forms.Message m)
    {
        base.WndProc(ref m);
        switch (m.Msg)
        {

            case 0xf:
                //WM_PAINT

                //"simple" is not currently supported
                if (this.DropDownStyle == ComboBoxStyle.Simple)
                    return;


                //==========START DRAWING===========
                g = this.CreateGraphics();
                //clear everything
                if (this.Enabled)
                {
                    g.Clear(Color.White);
                }
                else
                {
                    g.Clear(Color.FromName("control"));
                }
                //call the drawing functions
                DrawButton(g);
                DrawArrow(g);
                DrawBorder(g);
                DrawText(g);
                break;
            //===========STOP DRAWING============

            case 7:
            case 8:
            //case 0x7:
            //case 0x8:
            case 0x200:
            case 0x2a3:
                //CMB_DROPDOWN, CMB_CLOSEUP, WM_SETFOCUS, 
                //WM_KILLFOCUS, WM_MOUSEMOVE,  
                //WM_MOUSELEAVE (if you move the mouse fast over
                //the combobox, mouseleave doesn't always react)

                UpdateState();

                break;
        }

    }

    //Enable/Disable
    private void FlatComboBox_EnabledChanged(object sender, System.EventArgs e)
    {
        UpdateState();
    }

    //Cause WM_MOUSELEAVE doesn't always react, this timer refreshes the control every 20 miliseconds
    private Timer withEventsField_Timer = new Timer();
    private Timer Timer
    {
        get { return withEventsField_Timer; }
        set
        {
            if (withEventsField_Timer != null)
            {
                withEventsField_Timer.Tick -= Timer_Tick;
            }
            withEventsField_Timer = value;
            if (withEventsField_Timer != null)
            {
                withEventsField_Timer.Tick += Timer_Tick;
            }
        }
    }
    private void Timer_Tick(object sender, System.EventArgs e)
    {
        UpdateState();
    }

    protected override void Dispose(bool e)
    {
        this.Timer.Enabled = false;
        base.Dispose(e);
    }

    public void UpdateState()
    {
        //save the current state
        states temp = state;
        //
        if (this.Enabled)
        {
            if (this.DroppedDown)
            {
                this.state = states.dropeddown;
            }
            else
            {
                if (ClientRectangle.Contains(PointToClient(Form.MousePosition)))
                {
                    this.state = states.focused;
                }
                else if (this.Focused)
                {
                    this.state = states.focused;
                }
                else
                {
                    this.state = states.normal;
                }
            }
        }
        else
        {
            this.state = states.disabled;
        }
        //only redraw if the state has changed
        if (state != temp)
        {
            this.Invalidate();
        }
    }
    #endregion

    #region " Public property's "
    //Property to let the user change the style
    public styles FlatComboStyle
    {
        get { return style; }
        set { style = value; }
    }
    #endregion

    #region " Drawing functions "

    public void DrawButton(Graphics g)
    {
        if (this.RightToLeft == RightToLeft.No)
        {
            ButtonRect = new Rectangle(this.Width - 18, 1, 17, this.Height - 2);
        }
        else
        {
            ButtonRect = new Rectangle(1, 1, 17, this.Height - 2);
        }
        switch (state)
        {
            case states.normal:
                switch (style)
                {
                    case styles.officeXP:
                        ButtonBrush = new SolidBrush(Color.FromName("control"));
                        break;
                    case styles.office2003:
                        ButtonBrush = new LinearGradientBrush(ButtonRect, Color.FromArgb(214, 232, 253), Color.FromArgb(156, 189, 235), LinearGradientMode.Vertical);
                        break;
                }
                break;
            case states.focused:
                switch (style)
                {
                    case styles.officeXP:
                        ButtonBrush = new SolidBrush(Color.FromArgb(193, 210, 238));
                        break;
                    case styles.office2003:
                        ButtonBrush = new LinearGradientBrush(ButtonRect, Color.FromArgb(255, 242, 200), Color.FromArgb(255, 210, 148), LinearGradientMode.Vertical);
                        break;
                }
                break;
            case states.dropeddown:
                switch (style)
                {
                    case styles.officeXP:
                        ButtonBrush = new SolidBrush(Color.FromArgb(152, 181, 226));
                        break;
                    case styles.office2003:
                        ButtonBrush = new LinearGradientBrush(ButtonRect, Color.FromArgb(254, 149, 82), Color.FromArgb(255, 207, 139), LinearGradientMode.Vertical);
                        break;
                }
                break;
            case states.disabled:
                ButtonBrush = new SolidBrush(Color.FromName("control"));
                break;
        }
        g.FillRectangle(ButtonBrush, ButtonRect);
    }

    public void DrawArrow(Graphics g)
    {
        VerticalMiddle = Convert.ToInt32(this.Height / 2);
        if (this.RightToLeft == RightToLeft.No)
        {
            pntArrow[0] = new PointF(this.Width - 11, VerticalMiddle - 1);
            pntArrow[1] = new PointF(this.Width - 9, VerticalMiddle + 2);
            pntArrow[2] = new PointF(this.Width - 6, VerticalMiddle - 1);
        }
        else
        {
            pntArrow[0] = new PointF(7, VerticalMiddle - 1);
            pntArrow[1] = new PointF(9, VerticalMiddle + 2);
            pntArrow[2] = new PointF(12, VerticalMiddle - 1);
        }
        switch (this.state)
        {
            case states.normal:
            case states.focused:
                ArrowBrush = new SolidBrush(Color.Black);
                break;
            case states.dropeddown:
                switch (this.style)
                {
                    case styles.officeXP:
                        ArrowBrush = new SolidBrush(Color.FromArgb(73, 73, 73));
                        break;
                    case styles.office2003:
                        ArrowBrush = new SolidBrush(Color.Black);
                        break;
                }
                break;
            case states.disabled:
                ArrowBrush = new SolidBrush(Color.DarkGray);
                break;
        }
        g.FillPolygon(ArrowBrush, pntArrow);
    }

    public object DrawBorder(Graphics g)
    {
        object functionReturnValue = null;
        MainRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
        if (this.RightToLeft == 0)
        {
            ButtonSurRect = new Rectangle(0, 0, ButtonRect.Width + 1, ButtonRect.Height + 1);
        }
        else
        {
            ButtonSurRect = new Rectangle(ButtonRect.X - 1, ButtonRect.Y - 1, ButtonRect.Width + 2, ButtonRect.Height + 2);
        }
        switch (state)
        {
            case states.focused:
            case states.dropeddown:
                switch (this.style)
                {
                    case styles.officeXP:
                        BorderPen = new Pen(Color.FromArgb(49, 106, 197));
                        break;
                    case styles.office2003:
                        BorderPen = new Pen(Color.FromArgb(0, 0, 128));
                        break;
                }
                break;
            case states.disabled:
                BorderPen = new Pen(Color.DarkGray);
                break;
            default:
                return functionReturnValue;
        }
        if (!(state == states.disabled))
            g.DrawRectangle(BorderPen, ButtonSurRect);
        g.DrawRectangle(BorderPen, MainRect);
        return functionReturnValue;
    }

    public object DrawText(Graphics g)
    {
        object functionReturnValue = null;
        if (this.DropDownStyle != ComboBoxStyle.DropDownList)
            return functionReturnValue;
        string text = null;
        switch (state)
        {
            case states.normal:
            case states.focused:
            case states.dropeddown:
                TextBrush = new SolidBrush(this.ForeColor);
                break;
            case states.disabled:
                TextBrush = new SolidBrush(Color.DarkGray);
                break;
        }
        if (g.MeasureString(this.Text, this.Font).Width > this.Width - 30)
        {
            int i = -1;
            do
            {
                i += 1;
                if (g.MeasureString(text, this.Font).Width > this.Width - 30)
                    break; // TODO: might not be correct. Was : Exit Do
                text += this.Text.Substring(i, 1);
            } while (true);
        }
        else
        {
            text = this.Text;
        }
        if (this.RightToLeft == RightToLeft.No)
        {
            TextLocation = new PointF(1, 4);
        }
        else
        {
            float temp = this.Width - (g.MeasureString(text, this.Font).Width);
            TextLocation = new PointF(temp, 4);
        }
        g.DrawString(text, this.Font, TextBrush, TextLocation);
        return functionReturnValue;
    }
    #endregion
        
    }
}
