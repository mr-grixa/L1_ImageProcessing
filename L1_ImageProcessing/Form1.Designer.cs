namespace L1_ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_next = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_start = new System.Windows.Forms.Button();
            this.numericUpDownKlaster = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pictureBoxMain.Location = new System.Drawing.Point(388, 12);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxMain.TabIndex = 0;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(405, 422);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(130, 393);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 5;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(12, 419);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(111, 23);
            this.button_load.TabIndex = 68;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(130, 422);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(269, 20);
            this.textBox_path.TabIndex = 71;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 355);
            this.listBox1.TabIndex = 72;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 393);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(111, 23);
            this.button_start.TabIndex = 73;
            this.button_start.Text = "Старт";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // numericUpDownKlaster
            // 
            this.numericUpDownKlaster.Location = new System.Drawing.Point(229, 12);
            this.numericUpDownKlaster.Name = "numericUpDownKlaster";
            this.numericUpDownKlaster.Size = new System.Drawing.Size(102, 20);
            this.numericUpDownKlaster.TabIndex = 75;
            this.numericUpDownKlaster.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.DecimalPlaces = 2;
            this.numericUpDownSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSize.Location = new System.Drawing.Point(229, 68);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(102, 20);
            this.numericUpDownSize.TabIndex = 76;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSize.ValueChanged += new System.EventHandler(this.numericUpDownSize_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.numericUpDownKlaster);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.NumericUpDown numericUpDownKlaster;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
    }
}

