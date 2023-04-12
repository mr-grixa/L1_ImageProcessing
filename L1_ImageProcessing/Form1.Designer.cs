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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_next = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
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
            this.checkBox_DrawRadius = new System.Windows.Forms.CheckBox();
            this.checkBox_wall = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown_sdwid_R = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_sdwid_G = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sdwid_R)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sdwid_G)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.numericUpDownKlaster.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownKlaster.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKlaster.Name = "numericUpDownKlaster";
            this.numericUpDownKlaster.Size = new System.Drawing.Size(102, 20);
            this.numericUpDownKlaster.TabIndex = 75;
            this.numericUpDownKlaster.Value = new decimal(new int[] {
            50,
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
            5,
            0,
            0,
            131072});
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
            420,
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
            this.label4.Location = new System.Drawing.Point(220, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Допуск градусов";
            // 
            // numericUpDown_angl
            // 
            this.numericUpDown_angl.Location = new System.Drawing.Point(313, 253);
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
            // checkBox_DrawRadius
            // 
            this.checkBox_DrawRadius.AutoSize = true;
            this.checkBox_DrawRadius.Location = new System.Drawing.Point(95, 370);
            this.checkBox_DrawRadius.Name = "checkBox_DrawRadius";
            this.checkBox_DrawRadius.Size = new System.Drawing.Size(62, 17);
            this.checkBox_DrawRadius.TabIndex = 89;
            this.checkBox_DrawRadius.Text = "Радиус";
            this.checkBox_DrawRadius.UseVisualStyleBackColor = true;
            // 
            // checkBox_wall
            // 
            this.checkBox_wall.AutoSize = true;
            this.checkBox_wall.Location = new System.Drawing.Point(156, 370);
            this.checkBox_wall.Name = "checkBox_wall";
            this.checkBox_wall.Size = new System.Drawing.Size(58, 17);
            this.checkBox_wall.TabIndex = 90;
            this.checkBox_wall.Text = "Стены";
            this.checkBox_wall.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(221, 67);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(161, 45);
            this.trackBar1.TabIndex = 91;
            this.trackBar1.Value = 5;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Мин точек в кластере";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(221, 292);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown2.TabIndex = 93;
            this.numericUpDown2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Радиус";
            // 
            // numericUpDown_sdwid_R
            // 
            this.numericUpDown_sdwid_R.DecimalPlaces = 2;
            this.numericUpDown_sdwid_R.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_sdwid_R.Location = new System.Drawing.Point(280, 356);
            this.numericUpDown_sdwid_R.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_sdwid_R.Name = "numericUpDown_sdwid_R";
            this.numericUpDown_sdwid_R.Size = new System.Drawing.Size(102, 20);
            this.numericUpDown_sdwid_R.TabIndex = 94;
            this.numericUpDown_sdwid_R.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Допуск градусов";
            // 
            // numericUpDown_sdwid_G
            // 
            this.numericUpDown_sdwid_G.Location = new System.Drawing.Point(313, 379);
            this.numericUpDown_sdwid_G.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown_sdwid_G.Name = "numericUpDown_sdwid_G";
            this.numericUpDown_sdwid_G.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_sdwid_G.TabIndex = 96;
            this.numericUpDown_sdwid_G.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(221, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 97);
            this.groupBox1.TabIndex = 99;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск объектов";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(-1, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 79);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отслеживание объектов";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(221, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(161, 66);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Отслеживание объектов";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(-1, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(162, 79);
            this.groupBox4.TabIndex = 100;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Отслеживание объектов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(193, 324);
            this.dataGridView1.TabIndex = 102;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDown_sdwid_G);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown_sdwid_R);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox_wall);
            this.Controls.Add(this.checkBox_DrawRadius);
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
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKlaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_angl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sdwid_R)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sdwid_G)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.TextBox textBox_path;
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
        private System.Windows.Forms.CheckBox checkBox_DrawRadius;
        private System.Windows.Forms.CheckBox checkBox_wall;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown_sdwid_R;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_sdwid_G;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

