namespace büscherverwaltung
{
    partial class borrow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname_i = new System.Windows.Forms.TextBox();
            this.name_i = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email_i = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.info_p = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "Book Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label1.Location = new System.Drawing.Point(433, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 48);
            this.label1.TabIndex = 11;
            this.label1.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label2.Location = new System.Drawing.Point(433, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "Firstname:";
            // 
            // firstname_i
            // 
            this.firstname_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.firstname_i.Location = new System.Drawing.Point(646, 134);
            this.firstname_i.Name = "firstname_i";
            this.firstname_i.Size = new System.Drawing.Size(363, 56);
            this.firstname_i.TabIndex = 13;
            // 
            // name_i
            // 
            this.name_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.name_i.Location = new System.Drawing.Point(646, 210);
            this.name_i.Name = "name_i";
            this.name_i.Size = new System.Drawing.Size(363, 56);
            this.name_i.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label4.Location = new System.Drawing.Point(433, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            // 
            // email_i
            // 
            this.email_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.email_i.Location = new System.Drawing.Point(646, 292);
            this.email_i.Name = "email_i";
            this.email_i.Size = new System.Drawing.Size(363, 56);
            this.email_i.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label5.Location = new System.Drawing.Point(433, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 48);
            this.label5.TabIndex = 16;
            this.label5.Text = "E-mail:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(706, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label6.Location = new System.Drawing.Point(433, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 48);
            this.label6.TabIndex = 19;
            this.label6.Text = "borrow until:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button1.Location = new System.Drawing.Point(438, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 58);
            this.button1.TabIndex = 20;
            this.button1.Text = "borrow book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // info_p
            // 
            this.info_p.FormattingEnabled = true;
            this.info_p.ItemHeight = 20;
            this.info_p.Location = new System.Drawing.Point(33, 134);
            this.info_p.Name = "info_p";
            this.info_p.Size = new System.Drawing.Size(312, 264);
            this.info_p.TabIndex = 21;
            // 
            // borrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 553);
            this.Controls.Add(this.info_p);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.email_i);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name_i);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstname_i);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "borrow";
            this.Text = "Borrow";
            this.Load += new System.EventHandler(this.borrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname_i;
        private System.Windows.Forms.TextBox name_i;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_i;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox info_p;
    }
}