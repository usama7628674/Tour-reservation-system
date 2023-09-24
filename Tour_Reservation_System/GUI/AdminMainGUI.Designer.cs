namespace Tour_Reservation_System.GUI
{
    partial class AdminMainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_manage_routes = new System.Windows.Forms.Button();
            this.btn_terminal = new System.Windows.Forms.Button();
            this.btn_bus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_manage_routes);
            this.panel1.Controls.Add(this.btn_terminal);
            this.panel1.Controls.Add(this.btn_bus);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 696);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desire Travel & Tours";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_manage_routes
            // 
            this.btn_manage_routes.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_manage_routes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_routes.ForeColor = System.Drawing.Color.White;
            this.btn_manage_routes.Location = new System.Drawing.Point(11, 436);
            this.btn_manage_routes.Margin = new System.Windows.Forms.Padding(2);
            this.btn_manage_routes.Name = "btn_manage_routes";
            this.btn_manage_routes.Size = new System.Drawing.Size(178, 39);
            this.btn_manage_routes.TabIndex = 1;
            this.btn_manage_routes.Text = "Manage Tours";
            this.btn_manage_routes.UseVisualStyleBackColor = false;
            this.btn_manage_routes.Click += new System.EventHandler(this.btn_manage_routes_Click);
            // 
            // btn_terminal
            // 
            this.btn_terminal.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_terminal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_terminal.ForeColor = System.Drawing.Color.White;
            this.btn_terminal.Location = new System.Drawing.Point(11, 355);
            this.btn_terminal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_terminal.Name = "btn_terminal";
            this.btn_terminal.Size = new System.Drawing.Size(178, 39);
            this.btn_terminal.TabIndex = 1;
            this.btn_terminal.Text = "Add Terminal";
            this.btn_terminal.UseVisualStyleBackColor = false;
            this.btn_terminal.Click += new System.EventHandler(this.btn_terminal_Click);
            // 
            // btn_bus
            // 
            this.btn_bus.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bus.ForeColor = System.Drawing.Color.White;
            this.btn_bus.Location = new System.Drawing.Point(11, 273);
            this.btn_bus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_bus.Name = "btn_bus";
            this.btn_bus.Size = new System.Drawing.Size(178, 39);
            this.btn_bus.TabIndex = 0;
            this.btn_bus.Text = "Add trip";
            this.btn_bus.UseVisualStyleBackColor = false;
            this.btn_bus.Click += new System.EventHandler(this.btn_bus_Click);
            // 
            // AdminMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 604);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMainGUI";
            this.Text = "AdminMainGUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainGUI_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_manage_routes;
        private System.Windows.Forms.Button btn_terminal;
        private System.Windows.Forms.Button btn_bus;
        private System.Windows.Forms.Label label1;
    }
}