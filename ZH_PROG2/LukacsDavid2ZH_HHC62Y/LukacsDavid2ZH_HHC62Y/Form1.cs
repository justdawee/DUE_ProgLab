using System;
using System.Drawing;
using System.Windows.Forms;

namespace LukacsDavid2ZH_HHC62Y
{
    public partial class Form1 : Form
    {
        private float ratio = 1.0f; // Átló hányadosa
        private int ellipseSize = 50; // Ellipszis mérete (alapértelmezett)
        
        public Form1()
        {
            InitializeComponent();
            trackBar_size.Value = ellipseSize; // TrackBar értékének beállítása
            trackBar_size.Scroll += trackBar_size_Scroll; // TrackBar eseménykezelője
            txtBox_numbers.TextChanged += txtBox_numbers_TextChanged; // TextBox eseménykezelője
            
            // Form double buffering beállítása
            // Hogy ne villogjon :)
            DoubleBuffered = true; 
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
        
        private void trackBar_size_Scroll(object sender, EventArgs e)
        {
            ellipseSize = trackBar_size.Value;
            Invalidate(); // Újrarajzolás
        }
        
        private void txtBox_numbers_TextChanged(object sender, EventArgs e)
        {
            // Validálás (csak 0 és 1 közötti érték elfogadott)
            if (float.TryParse(txtBox_numbers.Text, out float newRatio) && newRatio > 0 && newRatio <= 1)
            {
                lbl_hibas.Visible = false; // Hibás érték esetén ne jelenjen meg a hibaüzenet
                ratio = newRatio; // Érvényes érték esetén beállítjuk az új értéket
                Invalidate(); // Újrarajzolás
            }
            else
            {
                lbl_hibas.Visible = true; // Hibás érték esetén jelenjen meg a hibaüzenet
                ratio = 0; // Hibás érték esetén ne jelenjen meg az ellipszis
                Invalidate(); // Újrarajzolás
            }
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (ratio > 0) // Csak érvényes érték esetén rajzoljuk ki az ellipszist
            {
                Graphics g = e.Graphics;

                // Ellipszis mérete
                int width = ellipseSize;
                int height = (int)(ellipseSize * ratio);

                // Középpont kiszámítása
                int centerX = ClientSize.Width / 2;
                int centerY = ClientSize.Height / 2 - 50;

                // Ellipszis határai
                Rectangle ellipseBounds = new Rectangle(centerX - width / 2, centerY - height / 2, width, height);

                // Ellipszis rajzolása
                g.FillEllipse(Brushes.Blue, ellipseBounds);
            }
        }
    }
}