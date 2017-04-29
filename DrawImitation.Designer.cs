namespace RiverPolution
{
    partial class DrawImitation
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
            this.checkBoxShowGrid = new System.Windows.Forms.CheckBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxShowGrid
            // 
            this.checkBoxShowGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowGrid.AutoSize = true;
            this.checkBoxShowGrid.Location = new System.Drawing.Point(904, 661);
            this.checkBoxShowGrid.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowGrid.Name = "checkBoxShowGrid";
            this.checkBoxShowGrid.Size = new System.Drawing.Size(128, 21);
            this.checkBoxShowGrid.TabIndex = 0;
            this.checkBoxShowGrid.Text = "Показати сітку";
            this.checkBoxShowGrid.UseVisualStyleBackColor = true;
            this.checkBoxShowGrid.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelInfo
            // 
            this.labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(39, 656);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(971, 26);
            this.labelInfo.TabIndex = 2;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DrawImitation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 692);
            this.Controls.Add(this.checkBoxShowGrid);
            this.Controls.Add(this.labelInfo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(18, 112);
            this.Name = "DrawImitation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Матриця забруднення";
            this.Load += new System.EventHandler(this.DrawImitation_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawImitation_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawImitation_MouseMove);
            this.Resize += new System.EventHandler(this.DrawImitation_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowGrid;
        private System.Windows.Forms.Label labelInfo;

    }
}