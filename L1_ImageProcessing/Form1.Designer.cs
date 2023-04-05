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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_R = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.button_IP_lidar = new System.Windows.Forms.Button();
            this.checkBox_claster = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_angl = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angl)).BeginInit();
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
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
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
            this.textBox_path.Text = "C:\\Users\\user\\Downloads\\HokuyoLidar_lidarlog\\HokuyoLidar_lidarlog.txt";
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
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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
            this.numericUpDownKlaster.Location = new System.Drawing.Point(280, 12);
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
            131072});
            this.numericUpDownSize.Location = new System.Drawing.Point(280, 38);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Кластеры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Масштаб ";
            // 
            // numericUpDown_R
            // 
            this.numericUpDown_R.DecimalPlaces = 2;
            this.numericUpDown_R.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_R.Location = new System.Drawing.Point(280, 100);
            this.numericUpDown_R.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_R.Name = "numericUpDown_R";
            this.numericUpDown_R.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_R.TabIndex = 79;
            this.numericUpDown_R.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Радиус";
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(223, 143);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(69, 20);
            this.textBox_IP.TabIndex = 81;
            this.textBox_IP.Text = "127.0.0.1";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(313, 143);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(69, 20);
            this.textBox_Port.TabIndex = 82;
            this.textBox_Port.Text = "2368";
            // 
            // button_IP_lidar
            // 
            this.button_IP_lidar.Location = new System.Drawing.Point(223, 169);
            this.button_IP_lidar.Name = "button_IP_lidar";
            this.button_IP_lidar.Size = new System.Drawing.Size(159, 54);
            this.button_IP_lidar.TabIndex = 83;
            this.button_IP_lidar.Text = "Подключится";
            this.button_IP_lidar.UseVisualStyleBackColor = true;
            this.button_IP_lidar.Click += new System.EventHandler(this.button_IP_lidar_Click);
            // 
            // checkBox_claster
            // 
            this.checkBox_claster.AutoSize = true;
            this.checkBox_claster.Checked = true;
            this.checkBox_claster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_claster.Location = new System.Drawing.Point(13, 370);
            this.checkBox_claster.Name = "checkBox_claster";
            this.checkBox_claster.Size = new System.Drawing.Size(76, 17);
            this.checkBox_claster.TabIndex = 86;
            this.checkBox_claster.Text = "Кластеры";
            this.checkBox_claster.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Допуск градусов";
            // 
            // numericUpDown_angl
            // 
            this.numericUpDown_angl.Location = new System.Drawing.Point(313, 255);
            this.numericUpDown_angl.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_angl.Name = "numericUpDown_angl";
            this.numericUpDown_angl.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_angl.TabIndex = 87;
            this.numericUpDown_angl.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_angl);
            this.Controls.Add(this.checkBox_claster);
            this.Controls.Add(this.button_IP_lidar);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.textBox_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_R);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angl)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_R;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Button button_IP_lidar;
        private System.Windows.Forms.CheckBox checkBox_claster;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_angl;
    }
}

