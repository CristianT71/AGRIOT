using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AGRIOT
{
    /// <summary>Paleta y utilidades de dibujo compartidas por todas las pantallas.</summary>
    internal static class Tema
    {
        public static readonly Color Fondo = Color.FromArgb(243, 246, 244);
        public static readonly Color Verde900 = Color.FromArgb(16, 44, 34);
        public static readonly Color Verde800 = Color.FromArgb(24, 62, 48);
        public static readonly Color Verde700 = Color.FromArgb(33, 82, 62);
        public static readonly Color Acento = Color.FromArgb(46, 158, 107);
        public static readonly Color AcentoHover = Color.FromArgb(37, 135, 91);
        public static readonly Color Texto = Color.FromArgb(31, 45, 39);
        public static readonly Color TextoSuave = Color.FromArgb(107, 124, 116);
        public static readonly Color Borde = Color.FromArgb(226, 232, 229);
        public static readonly Color CampoFondo = Color.FromArgb(247, 249, 248);

        public static GraphicsPath Redondeado(Rectangle r, int radio)
        {
            int d = Math.Max(1, radio * 2);
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }

        /// <summary>Primer color de fondo opaco hacia arriba en la jerarquía (los paneles transparentes se saltan).</summary>
        public static Color FondoDe(Control c)
        {
            for (Control p = c.Parent; p != null; p = p.Parent)
                if (p.BackColor.A == 255) return p.BackColor;
            return SystemColors.Control;
        }

        public static Color Oscurecer(Color c, float factor)
        {
            return Color.FromArgb(c.A, (int)(c.R * (1 - factor)), (int)(c.G * (1 - factor)), (int)(c.B * (1 - factor)));
        }
    }

    /// <summary>Tarjeta con esquinas redondeadas, borde fino y sombra suave.</summary>
    public class PanelRedondeado : Panel
    {
        public PanelRedondeado()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            BackColor = Color.White;
        }

        private int _radio = 16;
        [DefaultValue(16)]
        public int Radio { get { return _radio; } set { _radio = value; Invalidate(); } }

        private bool _sombra = true;
        [DefaultValue(true)]
        public bool Sombra { get { return _sombra; } set { _sombra = value; Invalidate(); } }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Tema.FondoDe(this));
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int pie = _sombra ? 4 : 1;
            var rect = new Rectangle(0, 0, Width - 1, Height - pie);
            if (rect.Width < 4 || rect.Height < 4) return;

            if (_sombra)
            {
                for (int i = 3; i >= 1; i--)
                {
                    var s = new Rectangle(rect.X, rect.Y + i, rect.Width, rect.Height);
                    using (GraphicsPath sp = Tema.Redondeado(s, _radio))
                    using (var b = new SolidBrush(Color.FromArgb(9, 20, 40, 30)))
                        g.FillPath(b, sp);
                }
            }

            using (GraphicsPath path = Tema.Redondeado(rect, _radio))
            using (var fill = new SolidBrush(BackColor))
            using (var pen = new Pen(Tema.Borde))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }
        }
    }

    /// <summary>Panel con fondo degradado y círculos decorativos (pantalla de marca).</summary>
    public class PanelDegradado : Panel
    {
        public PanelDegradado()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        public Color Color1 { get; set; } = Color.FromArgb(14, 40, 31);
        public Color Color2 { get; set; } = Color.FromArgb(38, 120, 84);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Width < 2 || Height < 2) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (var b = new LinearGradientBrush(ClientRectangle, Color1, Color2, 60f))
                g.FillRectangle(b, ClientRectangle);

            using (var c = new SolidBrush(Color.FromArgb(16, 255, 255, 255)))
            {
                g.FillEllipse(c, Width - 190, -110, 380, 380);
                g.FillEllipse(c, -120, Height - 230, 340, 340);
            }
            using (var c2 = new SolidBrush(Color.FromArgb(12, 255, 255, 255)))
                g.FillEllipse(c2, Width - 120, Height - 170, 200, 200);
        }
    }

    /// <summary>Botón plano con esquinas redondeadas y efecto hover.</summary>
    public class BotonRedondeado : Button
    {
        private bool _hover, _presionado;

        public BotonRedondeado()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            BackColor = Tema.Acento;
            ForeColor = Color.White;
            Font = new Font("Segoe UI Semibold", 10F);
        }

        private int _radio = 12;
        [DefaultValue(12)]
        public int Radio { get { return _radio; } set { _radio = value; Invalidate(); } }

        [DefaultValue(typeof(Color), "")]
        public Color ColorHover { get; set; }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _presionado = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _presionado = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _presionado = false; Invalidate(); base.OnMouseUp(e); }
        protected override void OnEnabledChanged(EventArgs e) { Invalidate(); base.OnEnabledChanged(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color padre = Tema.FondoDe(this);
            g.Clear(padre);

            Color fondo = BackColor.A == 0 ? padre : BackColor;
            if (!Enabled) fondo = Color.FromArgb(190, 205, 198);
            else if (_presionado) fondo = Tema.Oscurecer(ColorHover.IsEmpty ? fondo : ColorHover, 0.1f);
            else if (_hover) fondo = ColorHover.IsEmpty ? Tema.Oscurecer(fondo, 0.08f) : ColorHover;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = Tema.Redondeado(rect, _radio))
            using (var b = new SolidBrush(fondo))
                g.FillPath(b, path);

            TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPadding;
            switch (TextAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.BottomLeft:
                    flags |= TextFormatFlags.Left; break;
                case ContentAlignment.TopRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.BottomRight:
                    flags |= TextFormatFlags.Right; break;
                default:
                    flags |= TextFormatFlags.HorizontalCenter; break;
            }
            var area = new Rectangle(Padding.Left, 0, Width - Padding.Horizontal, Height);
            TextRenderer.DrawText(g, Text, Font, area, Enabled ? ForeColor : Color.FromArgb(120, 135, 128), flags);
        }
    }

    /// <summary>Campo de texto redondeado con resaltado al enfocar y texto de ayuda (placeholder).</summary>
    public class CampoTexto : Control
    {
        private const int EM_SETCUEBANNER = 0x1501;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private readonly TextBox _txt = new TextBox();
        private bool _foco;
        private string _placeholder = "";

        public CampoTexto()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            Size = new Size(320, 46);

            _txt.BorderStyle = BorderStyle.None;
            _txt.Font = new Font("Segoe UI", 11F);
            _txt.BackColor = Tema.CampoFondo;
            _txt.ForeColor = Tema.Texto;
            _txt.GotFocus += (s, e) => { _foco = true; Invalidate(); };
            _txt.LostFocus += (s, e) => { _foco = false; Invalidate(); };
            _txt.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
            _txt.HandleCreated += (s, e) => AplicarPlaceholder();
            Controls.Add(_txt);
            Acomodar();
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string Text
        {
            get { return _txt.Text; }
            set { _txt.Text = value; }
        }

        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get { return _txt.UseSystemPasswordChar; }
            set { _txt.UseSystemPasswordChar = value; }
        }

        [DefaultValue("")]
        public string Placeholder
        {
            get { return _placeholder; }
            set { _placeholder = value ?? ""; AplicarPlaceholder(); }
        }

        public void Clear() { _txt.Clear(); }

        public new bool Focus() { return _txt.Focus(); }

        private void AplicarPlaceholder()
        {
            if (_txt.IsHandleCreated)
                SendMessage(_txt.Handle, EM_SETCUEBANNER, (IntPtr)1, _placeholder);
        }

        private void Acomodar()
        {
            _txt.Width = Math.Max(10, Width - 32);
            _txt.Location = new Point(16, Math.Max(0, (Height - _txt.Height) / 2));
        }

        protected override void OnResize(EventArgs e) { base.OnResize(e); Acomodar(); }
        protected override void OnMouseDown(MouseEventArgs e) { base.OnMouseDown(e); _txt.Focus(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Tema.FondoDe(this));

            var rect = new Rectangle(1, 1, Width - 3, Height - 3);
            using (GraphicsPath path = Tema.Redondeado(rect, 12))
            using (var fill = new SolidBrush(Tema.CampoFondo))
            using (var pen = new Pen(_foco ? Tema.Acento : Tema.Borde, _foco ? 2f : 1f))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }
        }
    }
}
