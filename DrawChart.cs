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
    public partial class DrawChart : Form
    {
        public DrawChart()
        {
            InitializeComponent();
        }

        double [] maxValues;
        double maxValue = PolutionParameters.GDK;

        private void DrawChart_Load(object sender, EventArgs e)
        {
            maxValues = new double[PolutionParameters.PolutionArray.width];

            for (var i = 0; i < PolutionParameters.PolutionArray.width; i++)
            {
                maxValues[i] = PolutionParameters.PolutionArray.values[0, i];
                for (var j = 0; j < PolutionParameters.PolutionArray.height; j++)
                {
                    if (maxValues[i] < PolutionParameters.PolutionArray.values[j, i])
                        maxValues[i] = PolutionParameters.PolutionArray.values[j, i];
                }
                if (maxValue < maxValues[i]) maxValue = maxValues[i];
            }

        }

        const int topBorder = 20;
        const int bottonBorder = 50;
        const int leftBorder = 50;
        const int rightBorder = 10;

        private void DrawChart_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, leftBorder, topBorder,
                this.ClientSize.Width - leftBorder - rightBorder,
                this.ClientSize.Height - topBorder - bottonBorder);

            int deltaX;
            double deltaY;
            deltaX = (this.ClientSize.Width - leftBorder - rightBorder) / PolutionParameters.PolutionArray.width;
            deltaY = (this.ClientSize.Height - topBorder - bottonBorder) / maxValue;

            //Oy
            e.Graphics.DrawLine(new Pen(Color.Black, 2), leftBorder, topBorder,
                leftBorder, this.ClientSize.Height - bottonBorder);
            //Ox
            e.Graphics.DrawLine(new Pen(Color.Black, 2), leftBorder, this.ClientSize.Height - bottonBorder,
                this.ClientSize.Width - rightBorder, this.ClientSize.Height - bottonBorder);
            //ГДК
            e.Graphics.DrawLine(new Pen(Color.Red, 3), leftBorder, topBorder + (int)((maxValue -PolutionParameters.GDK) * deltaY),
                   leftBorder + deltaX * (PolutionParameters.PolutionArray.width - 1), topBorder + (int)((maxValue - PolutionParameters.GDK) * deltaY));

            Font fnt = new Font("Times New Roman", 10, FontStyle.Bold);
            e.Graphics.DrawString("ГДК", fnt, Brushes.Red, 10, (int)((maxValue - PolutionParameters.GDK) * deltaY));

            e.Graphics.DrawString("0", fnt, Brushes.Black, leftBorder, this.ClientSize.Height - 40);
           
            for (var i = 1; i < PolutionParameters.PolutionArray.width; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Blue, 3), leftBorder + (i - 1) * deltaX, 
                    topBorder + (int)((maxValue - maxValues[i-1]) * deltaY), 
                    leftBorder + i * deltaX, topBorder + (int)((maxValue - maxValues[i]) * deltaY));

                e.Graphics.DrawString(i.ToString(), fnt, Brushes.Black, leftBorder + i * deltaX, this.ClientSize.Height - 40); 
                e.Graphics.DrawLine(new Pen(Color.Black, 1), leftBorder + i * deltaX, topBorder,
                leftBorder + i * deltaX, this.ClientSize.Height - bottonBorder);
            }

            if(checkBoxShowText.Checked)
                for(var i = 0; i < PolutionParameters.PolutionArray.width; i++)
                    e.Graphics.DrawString(Math.Round(maxValues[i], 1).ToString(), fnt, Brushes.Black, leftBorder + i * deltaX,
                        topBorder + (int)((maxValue - maxValues[i]) * deltaY) - 15);

        }

        private void DrawChart_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void checkBoxShowText_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
