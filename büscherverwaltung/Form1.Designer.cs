namespace büscherverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.verwarungen = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.büscherregal = new System.Windows.Forms.ListView();
            this.info_p = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.verdienst_l = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Library";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button1.Location = new System.Drawing.Point(34, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "new book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button2.Location = new System.Drawing.Point(255, 582);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "ran book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // verwarungen
            // 
            this.verwarungen.FormattingEnabled = true;
            this.verwarungen.ItemHeight = 20;
            this.verwarungen.Location = new System.Drawing.Point(669, 441);
            this.verwarungen.Name = "verwarungen";
            this.verwarungen.Size = new System.Drawing.Size(441, 124);
            this.verwarungen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label2.Location = new System.Drawing.Point(661, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Warnings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label3.Location = new System.Drawing.Point(661, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Info";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button3.Location = new System.Drawing.Point(473, 582);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Borrow";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button4.Location = new System.Drawing.Point(908, 582);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "buy";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // büscherregal
            // 
            this.büscherregal.HideSelection = false;
            this.büscherregal.Location = new System.Drawing.Point(34, 97);
            this.büscherregal.Name = "büscherregal";
            this.büscherregal.Size = new System.Drawing.Size(615, 470);
            this.büscherregal.TabIndex = 0;
            this.büscherregal.UseCompatibleStateImageBehavior = false;
            // 
            // info_p
            // 
            this.info_p.FormattingEnabled = true;
            this.info_p.ItemHeight = 20;
            this.info_p.Location = new System.Drawing.Point(669, 147);
            this.info_p.Name = "info_p";
            this.info_p.Size = new System.Drawing.Size(441, 244);
            this.info_p.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button5.Location = new System.Drawing.Point(690, 582);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 58);
            this.button5.TabIndex = 12;
            this.button5.Text = "return";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // verdienst_l
            // 
            this.verdienst_l.AutoSize = true;
            this.verdienst_l.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.verdienst_l.Location = new System.Drawing.Point(12, 7);
            this.verdienst_l.Name = "verdienst_l";
            this.verdienst_l.Size = new System.Drawing.Size(234, 48);
            this.verdienst_l.TabIndex = 13;
            this.verdienst_l.Text = "Verdienst: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.verdienst_l);
            this.panel1.Location = new System.Drawing.Point(669, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 63);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.info_p);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verwarungen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.büscherregal);
            this.Name = "Form1";
            this.Text = "library";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox verwarungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView büscherregal;
        private System.Windows.Forms.ListBox info_p;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label verdienst_l;
        private System.Windows.Forms.Panel panel1;
    }
}

