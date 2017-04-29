namespace RiverPolution
{
    partial class DrawChart
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
            this.checkBoxShowText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxShowText
            // 
            this.checkBoxShowText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowText.AutoSize = true;
            this.checkBoxShowText.Location = new System.Drawing.Point(652, 459);
            this.checkBoxShowText.Name = "checkBoxShowText";
            this.checkBoxShowText.Size = new System.Drawing.Size(160, 21);
            this.checkBoxShowText.TabIndex = 0;
            this.checkBoxShowText.Text = "Показати значення";
            this.checkBoxShowText.UseVisualStyleBackColor = true;
            this.checkBoxShowText.CheckedChanged += new System.EventHandler(this.checkBoxShowText_CheckedChanged);
            // 
            // DrawChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 488);
            this.Controls.Add(this.checkBoxShowText);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "DrawChart";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Графік забруднення";
            this.Load += new System.EventHandler(this.DrawChart_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawChart_Paint);
            this.Resize += new System.EventHandler(this.DrawChart_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowText;
    }
}