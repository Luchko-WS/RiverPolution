namespace RiverPolution
{
    partial class ContainerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.матрицяЗабрудненьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.графікЗабрудненьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицяЗабрудненьToolStripMenuItem,
            this.графікЗабрудненьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // матрицяЗабрудненьToolStripMenuItem
            // 
            this.матрицяЗабрудненьToolStripMenuItem.Name = "матрицяЗабрудненьToolStripMenuItem";
            this.матрицяЗабрудненьToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.матрицяЗабрудненьToolStripMenuItem.Text = "Матриця забруднення";
            this.матрицяЗабрудненьToolStripMenuItem.Click += new System.EventHandler(this.матрицяЗабрудненьToolStripMenuItem_Click);
            // 
            // графікЗабрудненьToolStripMenuItem
            // 
            this.графікЗабрудненьToolStripMenuItem.Name = "графікЗабрудненьToolStripMenuItem";
            this.графікЗабрудненьToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.графікЗабрудненьToolStripMenuItem.Text = "Графік забруднення";
            this.графікЗабрудненьToolStripMenuItem.Click += new System.EventHandler(this.графікЗабрудненьToolStripMenuItem_Click);
            // 
            // ContainerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 538);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContainerForm";
            this.Text = "Результати розрахунків";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContainerForm_FormClosing);
            this.Load += new System.EventHandler(this.ContainerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem матрицяЗабрудненьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графікЗабрудненьToolStripMenuItem;
    }
}