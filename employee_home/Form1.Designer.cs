namespace employee_home
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.exit_btn = new System.Windows.Forms.Button();
            this.employee_Box = new System.Windows.Forms.PictureBox();
            this.roust_Box = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roust_Box)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGO";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(285, 39);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(103, 23);
            this.user_name.TabIndex = 1;
            this.user_name.Text = "User Name";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(268, 301);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(212, 32);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            // 
            // employee_Box
            // 
            this.employee_Box.Image = global::employee_home.Properties.Resources._1803695;
            this.employee_Box.Location = new System.Drawing.Point(49, 251);
            this.employee_Box.Name = "employee_Box";
            this.employee_Box.Size = new System.Drawing.Size(180, 180);
            this.employee_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.employee_Box.TabIndex = 6;
            this.employee_Box.TabStop = false;
            this.employee_Box.Click += new System.EventHandler(this.employeeBox_Click);
            this.employee_Box.MouseEnter += new System.EventHandler(this.employeeBox_enter);
            this.employee_Box.MouseLeave += new System.EventHandler(this.employeeBox_leave);
            // 
            // roust_Box
            // 
            this.roust_Box.Image = global::employee_home.Properties.Resources._621d85a4a3ffe6745774ef5f_Rostering_Page;
            this.roust_Box.Location = new System.Drawing.Point(49, 65);
            this.roust_Box.Name = "roust_Box";
            this.roust_Box.Size = new System.Drawing.Size(180, 180);
            this.roust_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roust_Box.TabIndex = 5;
            this.roust_Box.TabStop = false;
            this.roust_Box.Click += new System.EventHandler(this.roust_Box_Click);
            this.roust_Box.MouseEnter += new System.EventHandler(this.roust_Box_enter);
            this.roust_Box.MouseLeave += new System.EventHandler(this.roust_Box_leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.exit_btn);
            this.panel1.Location = new System.Drawing.Point(282, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 366);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employee_Box);
            this.Controls.Add(this.roust_Box);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.employee_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roust_Box)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox roust_Box;
        private System.Windows.Forms.PictureBox employee_Box;
        private System.Windows.Forms.Panel panel1;
    }
}

