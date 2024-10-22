using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukacsDavid1ZH_HHC62Y
{
    public partial class Form1 : Form
    {
        private Point _direction;
        private Rectangle _bounds;
        private bool _isMoving = false;
        private CancellationTokenSource _cts;
        private readonly Random _random = new Random();
        
        private readonly List<(Rectangle rectangle, Pen penColor)> _storedRects = new List<(Rectangle, Pen)>(5192);
        
        // Készítette: Lukács Dávid Roland (HHC62Y)
        // 2024.10.07.
        // Made with JetBrains Rider 2024
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            startBtn.Left = (ClientSize.Width - startBtn.Width) / 2; //képernyő közepére a gombot
            startBtn.Top = (ClientSize.Height - startBtn.Height) / 2;
            _bounds = new Rectangle(0, 0, ClientSize.Width, ClientSize.Height-speedTrackBar.Height-20);
            _direction = new Point(_random.Next(2) * 2 - 1, _random.Next(2) * 2 - 1);
            
            //ezek azért kellenek hogy ne villogjon az egész
            DoubleBuffered = true; 
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            if (!_isMoving) //ha nem mozog, akkor elindítjuk
            {
                startBtn.Text = "Stop";
                _cts = new CancellationTokenSource();
                _direction = new Point(_random.Next(2) == 0 ? 1 : -1, _random.Next(2) == 0 ? 1 : -1);
                _isMoving = true;
                await StartMoving(_cts.Token);
            }
            else //ha mozog, akkor leállítjuk
            {
                _cts.Cancel();
                startBtn.Text = "Start";
                _isMoving = false;
            }
        }
        
        private async Task StartMoving(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                MoveButton(); // mozgatjuk a gombot
                try
                {
                    await Task.Delay(1000 / speedTrackBar.Value, token); //a sebesség a trackbar értékétől függ
                }
                catch (TaskCanceledException)
                {
                    // ignored
                }
            }
        }
        
        private void MoveButton()
        {
            Point newLocation = startBtn.Location;
            newLocation.X += _direction.X * 2;
            newLocation.Y += _direction.Y * 2;
            
            if (newLocation.X < _bounds.Left || newLocation.X + startBtn.Width > _bounds.Right)
            {
                _direction.X = -_direction.X; //ha elérte a széleket, akkor megfordítjuk az irányát
            }
            if (newLocation.Y < _bounds.Top || newLocation.Y + startBtn.Height > _bounds.Bottom)
            {
                _direction.Y = -_direction.Y;
            }
            
            var penColor = new Pen(Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256)));
            var rectangle = new Rectangle(startBtn.Location.X, startBtn.Location.Y, startBtn.Width, startBtn.Height);
            
            _storedRects.Add((rectangle, penColor)); //a gomb új helyét és színét hozzáadjuk a listához
            startBtn.Location = newLocation;
            
            Invalidate();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); //rajzoljuk ki a gombokat
            foreach (var rectangle in _storedRects)
            {
                e.Graphics.FillRectangle(rectangle.penColor.Brush, rectangle.rectangle); //kitöltjük a gombokat
            }
            startBtn.Refresh(); //frissítjük a gombot hogy ne tűnjön el
        }
    }
}