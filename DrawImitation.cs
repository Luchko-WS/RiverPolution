using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiverPolution
{
    public partial class DrawImitation : Form
    {
        public DrawImitation()
        {
            InitializeComponent();
        }

        double maxValue = 0;

        private void DrawImitation_Load(object sender, EventArgs e)
        {
            for (var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                for (var j = 0; j < PolutionParameters.PolutionArray.width; j++)
                    if (PolutionParameters.PolutionArray.values[i, j] > maxValue) maxValue = PolutionParameters.PolutionArray.values[i, j];
        }

        int deltaX, deltaY;
        
        struct RGB
        {
            public int R;
            public int G;
            public int B;

            public RGB(int r, int g, int b)
            {
                R = r;
                G = g;
                B = b;
            }
        }

        const int leftBorder = 40;
        const int rightBorder = 90;
        const int topBorder = 20;
        const int bottonBorder = 50;

        private void DrawImitation_Paint(object sender, PaintEventArgs e)
        {
            deltaX = (this.ClientSize.Width - leftBorder - rightBorder) / PolutionParameters.PolutionArray.width;
            deltaY = (this.ClientSize.Height - topBorder - bottonBorder) / PolutionParameters.PolutionArray.height; 

            RGB colorRGB = new RGB(0,0,0);
            for (var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                for (var j = 0; j < PolutionParameters.PolutionArray.width; j++)
                {
                    colorRGB = getColor(PolutionParameters.PolutionArray.values[i, j]);
                    e.Graphics.FillRectangle(new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(colorRGB.R)))), ((int)(((byte)(colorRGB.G)))),
                        ((int)(((byte)(colorRGB.B)))))), leftBorder + j * deltaX, topBorder + i * deltaY, deltaX, deltaY);
                }

            var myBrush = new System.Drawing.Drawing2D.ColorBlend();

            Color[] Colors;

            double middlePoint;
            if (PolutionParameters.GDK < maxValue)
            {
                middlePoint = PolutionParameters.GDK / maxValue;

                Color[] colors = {
                    Color.FromArgb(0, 0, 255),
                    Color.FromArgb(255, 0, 0),
                    Color.FromArgb(0, 255, 0)
                };
                Colors = colors;
            }
            else
            {
                Color[] colors = {
                    Color.FromArgb(255, 0, 0),
                    Color.FromArgb(122, 122, 0),
                    Color.FromArgb(0, 255, 0)
                };
                Colors = colors;
            }

            myBrush.Colors = Colors;

            float[] arr = { 0, 0.5F, 1 };
            myBrush.Positions = arr;

            Single[] bPts = { 0, 0.5F, 1};
            myBrush.Positions = bPts;

            var br = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(this.ClientSize.Width - rightBorder + 10 ,
                topBorder + 10, 30, this.ClientSize.Height - bottonBorder - 30), Color.White, Color.Black,
                System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            br.InterpolationColors = myBrush;
            e.Graphics.FillRectangle(br, new Rectangle(this.ClientSize.Width - rightBorder + 10, topBorder + 10,
                30, this.ClientSize.Height - bottonBorder - topBorder - 40));

            Font fnt = new Font("Times New Roman", 10, FontStyle.Bold);

            double val1, val2;
            if (maxValue > PolutionParameters.GDK)
            {
                val1 = maxValue;
                val2 = PolutionParameters.GDK;
            }
            else
            {
                val1 = PolutionParameters.GDK;
                val2 = PolutionParameters.GDK / 2;
            }  

            e.Graphics.DrawString(Convert.ToString(Math.Round(val1, 2)), fnt, Brushes.Black,
                this.ClientSize.Width - 65, 5);
            e.Graphics.DrawString(Convert.ToString(Math.Round(val2)), fnt, Brushes.Black,
                this.ClientSize.Width - 65, (int)(this.ClientSize.Height - 100)/2 + 20);
            e.Graphics.DrawString("0", fnt, Brushes.Black,
                this.ClientSize.Width - 50, this.ClientSize.Height - 80);

            if (checkBoxShowGrid.Checked)
            {
                for (var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                    for (var j = 0; j < PolutionParameters.PolutionArray.width; j++)
                        e.Graphics.DrawRectangle(new Pen(Color.Black, 1), leftBorder + j * deltaX, topBorder + i * deltaY, deltaX, deltaY);

                for(var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                    e.Graphics.DrawString(Convert.ToString(i+1), fnt, Brushes.Black, 5, topBorder + deltaY * i + (int)(deltaY/2));

                for (var i = 0; i < PolutionParameters.PolutionArray.width; i++)
                    e.Graphics.DrawString(Convert.ToString(i + 1), fnt, Brushes.Black,
                        leftBorder + i * deltaX + (int)(deltaX / 2), 2);

            }
        }

        private RGB getColor(double concentration)
        {
            int r = 0, g = 0, b = 0;

            if(concentration <= PolutionParameters.GDK)
            {   
               r = (int)(255 * (concentration / PolutionParameters.GDK));
               g = 255 - (int)(255 * (concentration / PolutionParameters.GDK));
            }
            else
            {
                b = (int)(255 * (concentration / maxValue));
                r = 255 - (int)(255 * (concentration / maxValue));
            }

            return new RGB(r, g, b);
        }

        private void DrawImitation_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (deltaX != 0 && deltaY != 0 && e.Location.X > leftBorder && e.Location.X < leftBorder + PolutionParameters.PolutionArray.width * deltaX
                    && e.Location.Y > topBorder && e.Location.Y < PolutionParameters.PolutionArray.height * deltaY + topBorder)
                    this.labelInfo.Text = "Коорд.: (" + Convert.ToInt32(((e.Location.X - leftBorder) / deltaX) + 1) + "; " +
                        Convert.ToInt32(((e.Location.Y - topBorder) / deltaY) + 1) + "). Забруднення: " +
                        Math.Round(PolutionParameters.PolutionArray.values[(int)((e.Location.Y - topBorder) / deltaY),
                        (int)((e.Location.X - leftBorder) / deltaX)], 3);
            }
            catch(Exception)
            {

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void DrawImitation_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
