namespace RiverPolution
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxFone = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxGDK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxPlants = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonDraw = new System.Windows.Forms.Button();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(152, 129);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(132, 22);
            this.textBoxHeight.TabIndex = 0;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(152, 161);
            this.textBoxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(132, 22);
            this.textBoxWidth.TabIndex = 1;
            // 
            // textBoxFone
            // 
            this.textBoxFone.Location = new System.Drawing.Point(152, 193);
            this.textBoxFone.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFone.Name = "textBoxFone";
            this.textBoxFone.Size = new System.Drawing.Size(132, 22);
            this.textBoxFone.TabIndex = 2;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(119, 380);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(112, 28);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Далі";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxGDK
            // 
            this.textBoxGDK.Location = new System.Drawing.Point(152, 225);
            this.textBoxGDK.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGDK.Name = "textBoxGDK";
            this.textBoxGDK.Size = new System.Drawing.Size(132, 22);
            this.textBoxGDK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Висота:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ширина:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Фон:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "ГДК:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(96, 89);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Початкові дані";
            // 
            // listBoxPlants
            // 
            this.listBoxPlants.FormattingEnabled = true;
            this.listBoxPlants.ItemHeight = 16;
            this.listBoxPlants.Location = new System.Drawing.Point(13, 9);
            this.listBoxPlants.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxPlants.Name = "listBoxPlants";
            this.listBoxPlants.Size = new System.Drawing.Size(341, 196);
            this.listBoxPlants.Sorted = true;
            this.listBoxPlants.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(96, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Координати скиду:";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(17, 343);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(46, 17);
            this.labelInfo.TabIndex = 20;
            this.labelInfo.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 270);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Кількість речовини:";
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(215, 267);
            this.textBoxCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(77, 22);
            this.textBoxCapacity.TabIndex = 13;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(68, 380);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(111, 28);
            this.buttonPrev.TabIndex = 16;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(187, 380);
            this.buttonDraw.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(111, 28);
            this.buttonDraw.TabIndex = 17;
            this.buttonDraw.Text = "Побудувати";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(99, 237);
            this.numericUpDownX.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownX.TabIndex = 11;
            this.numericUpDownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(221, 237);
            this.numericUpDownY.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownY.TabIndex = 12;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(187, 299);
            this.buttonRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(100, 28);
            this.buttonRemoveItem.TabIndex = 15;
            this.buttonRemoveItem.Text = "Видалити";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 240);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 240);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Х:";
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(76, 299);
            this.buttonAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(103, 28);
            this.buttonAddItem.TabIndex = 14;
            this.buttonAddItem.Text = "Додати";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 423);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonDraw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.textBoxCapacity);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxGDK);
            this.Controls.Add(this.textBoxFone);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxPlants);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введення параметрів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxFone;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxGDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        /// <summary>
        /// /////////////////////
        /// </summary>
        private System.Windows.Forms.ListBox listBoxPlants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAddItem;
    }
}
