namespace Tour_Reservation_System.GUI
{
    partial class tours
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_seater = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_add_bus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.comboBox_from_terminal = new System.Windows.Forms.ComboBox();
            this.comboBox_to_terminal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_departure_time = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_travel_date = new System.Windows.Forms.DateTimePicker();
            this.DataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.combo_bus_class = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_fare = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_bus_number = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tour_Reservation_System.Properties.Resources.Red_Close_Button_Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(904, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 4);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(292, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 44);
            this.label1.TabIndex = 60;
            this.label1.Text = "Create Tour";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(478, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 96;
            this.label8.Text = "To Terminal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(169, 211);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 94;
            this.label7.Text = "From Terminal";
            // 
            // tb_seater
            // 
            this.tb_seater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_seater.Location = new System.Drawing.Point(649, 149);
            this.tb_seater.Margin = new System.Windows.Forms.Padding(2);
            this.tb_seater.Name = "tb_seater";
            this.tb_seater.Size = new System.Drawing.Size(147, 32);
            this.tb_seater.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(478, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 92;
            this.label6.Text = "Trip people capacity";
            // 
            // btn_add_bus
            // 
            this.btn_add_bus.BackColor = System.Drawing.Color.White;
            this.btn_add_bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_bus.ForeColor = System.Drawing.Color.Black;
            this.btn_add_bus.Location = new System.Drawing.Point(400, 340);
            this.btn_add_bus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_bus.Name = "btn_add_bus";
            this.btn_add_bus.Size = new System.Drawing.Size(146, 46);
            this.btn_add_bus.TabIndex = 90;
            this.btn_add_bus.Text = "Add Tour";
            this.btn_add_bus.UseVisualStyleBackColor = false;
            this.btn_add_bus.Click += new System.EventHandler(this.btn_add_bus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(179, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "Trip Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(394, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 26);
            this.label5.TabIndex = 88;
            this.label5.Text = "Add New Tour";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(800, 124);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(4, 243);
            this.pictureBox5.TabIndex = 87;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(146, 124);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(4, 243);
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.Location = new System.Drawing.Point(147, 365);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(657, 4);
            this.pictureBox8.TabIndex = 85;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Location = new System.Drawing.Point(146, 121);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(657, 4);
            this.pictureBox9.TabIndex = 84;
            this.pictureBox9.TabStop = false;
            // 
            // comboBox_from_terminal
            // 
            this.comboBox_from_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_from_terminal.FormattingEnabled = true;
            this.comboBox_from_terminal.Location = new System.Drawing.Point(314, 197);
            this.comboBox_from_terminal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_from_terminal.Name = "comboBox_from_terminal";
            this.comboBox_from_terminal.Size = new System.Drawing.Size(147, 34);
            this.comboBox_from_terminal.TabIndex = 97;
            // 
            // comboBox_to_terminal
            // 
            this.comboBox_to_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_to_terminal.FormattingEnabled = true;
            this.comboBox_to_terminal.Location = new System.Drawing.Point(649, 192);
            this.comboBox_to_terminal.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_to_terminal.Name = "comboBox_to_terminal";
            this.comboBox_to_terminal.Size = new System.Drawing.Size(147, 34);
            this.comboBox_to_terminal.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(478, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 101;
            this.label2.Text = "Travel Date";
            // 
            // tb_departure_time
            // 
            this.tb_departure_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_departure_time.Location = new System.Drawing.Point(314, 244);
            this.tb_departure_time.Margin = new System.Windows.Forms.Padding(2);
            this.tb_departure_time.Name = "tb_departure_time";
            this.tb_departure_time.Size = new System.Drawing.Size(147, 32);
            this.tb_departure_time.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(179, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 99;
            this.label4.Text = "Time";
            // 
            // dt_travel_date
            // 
            this.dt_travel_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_travel_date.Location = new System.Drawing.Point(649, 240);
            this.dt_travel_date.Margin = new System.Windows.Forms.Padding(2);
            this.dt_travel_date.Name = "dt_travel_date";
            this.dt_travel_date.Size = new System.Drawing.Size(147, 32);
            this.dt_travel_date.TabIndex = 102;
            // 
            // DataGridViewDetails
            // 
            this.DataGridViewDetails.AllowUserToAddRows = false;
            this.DataGridViewDetails.AllowUserToOrderColumns = true;
            this.DataGridViewDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewDetails.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDetails.Location = new System.Drawing.Point(9, 456);
            this.DataGridViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewDetails.Name = "DataGridViewDetails";
            this.DataGridViewDetails.RowTemplate.Height = 24;
            this.DataGridViewDetails.Size = new System.Drawing.Size(931, 203);
            this.DataGridViewDetails.TabIndex = 103;
            // 
            // combo_bus_class
            // 
            this.combo_bus_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_bus_class.FormattingEnabled = true;
            this.combo_bus_class.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "Executive"});
            this.combo_bus_class.Location = new System.Drawing.Point(314, 292);
            this.combo_bus_class.Margin = new System.Windows.Forms.Padding(2);
            this.combo_bus_class.Name = "combo_bus_class";
            this.combo_bus_class.Size = new System.Drawing.Size(147, 34);
            this.combo_bus_class.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(179, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 104;
            this.label9.Text = "Trip Class";
            // 
            // tb_fare
            // 
            this.tb_fare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fare.Location = new System.Drawing.Point(649, 292);
            this.tb_fare.Margin = new System.Windows.Forms.Padding(2);
            this.tb_fare.Name = "tb_fare";
            this.tb_fare.Size = new System.Drawing.Size(147, 32);
            this.tb_fare.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(479, 299);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 18);
            this.label10.TabIndex = 106;
            this.label10.Text = "Fare";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(428, 427);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 26);
            this.label12.TabIndex = 110;
            this.label12.Text = "Tours List";
            // 
            // comboBox_bus_number
            // 
            this.comboBox_bus_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_bus_number.FormattingEnabled = true;
            this.comboBox_bus_number.Location = new System.Drawing.Point(314, 149);
            this.comboBox_bus_number.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_bus_number.Name = "comboBox_bus_number";
            this.comboBox_bus_number.Size = new System.Drawing.Size(147, 34);
            this.comboBox_bus_number.TabIndex = 111;
            // 
            // Routes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 640);
            this.Controls.Add(this.comboBox_bus_number);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tb_fare);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combo_bus_class);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DataGridViewDetails);
            this.Controls.Add(this.dt_travel_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_departure_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_to_terminal);
            this.Controls.Add(this.comboBox_from_terminal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_seater);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_add_bus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Routes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Routes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_seater;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_add_bus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.ComboBox comboBox_from_terminal;
        private System.Windows.Forms.ComboBox comboBox_to_terminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_departure_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dt_travel_date;
        private System.Windows.Forms.DataGridView DataGridViewDetails;
        private System.Windows.Forms.ComboBox combo_bus_class;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_fare;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox_bus_number;
    }
}