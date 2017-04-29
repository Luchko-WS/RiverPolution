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
    public partial class ContainerForm : Form
    {
        public ContainerForm()
        {
            InitializeComponent();
        }

        DrawImitation newMDIChildMatrix;
        DrawChart newMDIChildChart;

        private void ContainerForm_Load(object sender, EventArgs e)
        {
            newMDIChildChart = new DrawChart();
            newMDIChildChart.MdiParent = this;
            newMDIChildChart.FormClosed += new FormClosedEventHandler(chartClosedChildForm);
            newMDIChildChart.WindowState = FormWindowState.Maximized;
            newMDIChildChart.Show();

            newMDIChildMatrix = new DrawImitation();
            newMDIChildMatrix.FormClosed += new FormClosedEventHandler(matrixClosedChildForm);
            newMDIChildMatrix.MdiParent = this;
            newMDIChildMatrix.WindowState = FormWindowState.Maximized;
            newMDIChildMatrix.Show();     
        }

        private void матрицяЗабрудненьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMDIChildMatrix.Select();
            newMDIChildMatrix.Show();
        }

        private void графікЗабрудненьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newMDIChildChart.Select();
            newMDIChildChart.Show();
        }

        private void chartClosedChildForm(object sender, FormClosedEventArgs args)
        {
            newMDIChildChart = new DrawChart();
            newMDIChildChart.MdiParent = this;
            newMDIChildChart.FormClosed += new FormClosedEventHandler(chartClosedChildForm);
        }
        private void matrixClosedChildForm(object sender, FormClosedEventArgs args)
        {
            newMDIChildMatrix = new DrawImitation();
            newMDIChildMatrix.MdiParent = this;
            newMDIChildMatrix.FormClosed += new FormClosedEventHandler(matrixClosedChildForm);
        }

        private void ContainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (var i = 0; i < PolutionParameters.PolutionArray.height; i++)
                for (var j = 0; j < PolutionParameters.PolutionArray.width; j++)
                    PolutionParameters.PolutionArray.values[i, j] = 0;
        }
    }
}
