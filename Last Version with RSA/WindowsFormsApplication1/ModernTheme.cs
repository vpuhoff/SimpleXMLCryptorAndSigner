///
/// ModernTheme
/// Original vb.Net Creator, AeonHack
/// Converted to C# by Faded
/// www.EmuDevs.com
/// 

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernTheme : Control
{
    private int _TitleHeight = 25;
    public int TitleHeight
    {
        get { return _TitleHeight; }
        set
        {
            if (value > Height)
            {
                value = Height;
            }
            if (value < 2)
            {
                Height = 1;
            }
            _TitleHeight = value;
            Invalidate();
        }
    }
    private HorizontalAlignment _TitleAlign = (HorizontalAlignment)2;

    public HorizontalAlignment TitleAlign
    {
        get { return _TitleAlign; }
        set
        {
            _TitleAlign = value;
            Invalidate();
        }
    }

    protected override void OnHandleCreated(System.EventArgs e)
    {
        Dock = (DockStyle)5;
        if (Parent is Form)
            ((Form)Parent).FormBorderStyle = 0;
        base.OnHandleCreated(e);
    }

    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
    {
        if (new Rectangle(Parent.Location.X, Parent.Location.Y, Width - 1, _TitleHeight - 1).IntersectsWith(new Rectangle(MousePosition.X, MousePosition.Y, 1, 1)))
        {
            Capture = false;
            var M = Message.Create(Parent.Handle, 161, new IntPtr(2), new IntPtr(0));
            DefWndProc(ref M);
        }
        base.OnMouseDown(e);
    }

    private Color C1 = Color.FromArgb(255, 255, 255);
    private Color C2 = Color.FromArgb(63, 63, 63);
    private Color C3 = Color.FromArgb(41, 41, 41);
    private Color C4 = Color.FromArgb(27, 27, 27);
    private Color C5 = Color.FromArgb(0, 0, 0, 0);
    private Color C6 = Color.FromArgb(25, 255, 255, 255);

    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
    {}

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        using (Bitmap B = new Bitmap(Width, Height))
        {
            using (var G = Graphics.FromImage(B))
            {
                G.Clear(C3);
                Draw.Gradient(G, C4, C3, 0, 0, Width, _TitleHeight);

                var S = G.MeasureString(Text, Font);
                var O = 6;

                if ((int)_TitleAlign == 2)
                    O = Width / 2 - (int)S.Width / 2;
                if ((int)_TitleAlign == 1)
                    O = Width - (int)S.Width - 6;

                Rectangle R = new Rectangle(O, (_TitleHeight + 2) / 2 - (int)S.Height / 2, (int)S.Width, (int)S.Height);

                using (LinearGradientBrush T = new LinearGradientBrush(R, C1, C3, LinearGradientMode.Vertical))
                {
                    G.DrawString(Text, Font, T, R);
                }

                G.DrawLine(new Pen(C3), 0, 1, Width, 1);
                Draw.Blend(G, C5, C6, C5, 0.5F, 0, 0, _TitleHeight + 1, Width, 1);
                G.DrawLine(new Pen(C4), 0, _TitleHeight, Width, _TitleHeight);
                G.DrawRectangle(new Pen(C4), 0, 0, Width - 1, Height - 1);
                e.Graphics.DrawImage((Image)B.Clone(), (float)0, (float)0);
            }
        }
    }
}

public class MButton : Control
{
    public MButton()
    {
        ForeColor = Color.FromArgb(255, 255, 255);
    }

    private int State;
    protected override void OnMouseEnter(System.EventArgs e)
    {
        State = 1;
        Invalidate();
        base.OnMouseEnter(e);
    }

    protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
    {
        State = 2;
        Invalidate();
        base.OnMouseDown(e);
    }

    protected override void OnMouseLeave(System.EventArgs e)
    {
        State = 0;
        Invalidate();
        base.OnMouseLeave(e);
    }

    protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e)
    {
        State = 1;
        Invalidate();
        base.OnMouseUp(e);
    }

    private Color C1 = Color.FromArgb(31, 31, 31);
    private Color C2 = Color.FromArgb(41, 41, 41);
    private Color C3 = Color.FromArgb(51, 51, 51);
    private Color C4 = Color.FromArgb(0, 0, 0, 0);
    private Color C5 = Color.FromArgb(128, 255, 255, 255);

    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
    { }

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        using (Bitmap B = new Bitmap(Width, Height))
        {
            using (var G = Graphics.FromImage(B))
            {
                G.DrawRectangle(new Pen(C1), 0, 0, Width - 1, Height - 1);

                if (State == 2)
                    Draw.Gradient(G, C2, C3, 1, 1, Width - 2, Height - 2);
                else
                    Draw.Gradient(G, C3, C2, 1, 1, Width - 2, Height - 2);

                var O = G.MeasureString(Text, Font);
                G.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - O.Width / 2, Height / 2 - O.Height / 2);
                Draw.Blend(G, C4, C5, C4, 0.5F, 0, 1, 1, Width - 2, 1);
                e.Graphics.DrawImage((Image)B.Clone(), (float)0, (float)0);
            }
        }
    }
}

public class MProgress : Control
{
    private int _Value;
    public int Value
    {
        get { return _Value; }
        set
        {
            _Value = value;
            Invalidate();
        }
    }

    private int _Maximum = 100;
    public int Maximum
    {
        get { return _Maximum; }
        set
        {
            if (value == 0)
                value = 1;
            _Maximum = value;
            Invalidate();
        }
    }

    private Color C1 = Color.FromArgb(31, 31, 31);
    private Color C2 = Color.FromArgb(41, 41, 41);
    private Color C3 = Color.FromArgb(130, 51, 51);
    private Color C6 = Color.FromArgb(50, 51, 51);
    private Color C4 = Color.FromArgb(0, 0, 0, 0);
    private Color C5 = Color.FromArgb(25, 255, 255, 255);

    protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
    {}

    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        int V = Width * _Value / _Maximum;
        using (Bitmap B = new Bitmap(Width, Height))
        {
            using (var G = Graphics.FromImage(B))
            {
                Draw.Gradient(G, C2, C6, 1, 1, Width - 2, Height - 2);
                G.DrawRectangle(new Pen(C2), 1, 1, V - 3, Height - 3);
                Draw.Gradient(G, C3, C2, 2, 2, V - 4, Height - 4);
                G.DrawRectangle(new Pen(C1), 0, 0, Width - 1, Height - 1);
                e.Graphics.DrawImage((Image)B.Clone(), 0, 0);
            }
        }
    }
}
