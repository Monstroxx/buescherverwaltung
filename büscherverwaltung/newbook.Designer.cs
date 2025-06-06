namespace büscherverwaltung
{
    partial class newbook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booktitle_i = new System.Windows.Forms.TextBox();
            this.isbn_i = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sellprice_i = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 48);
            this.label2.TabIndex = 8;
            this.label2.Text = "Book Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "ISBN:";
            // 
            // booktitle_i
            // 
            this.booktitle_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.booktitle_i.Location = new System.Drawing.Point(257, 43);
            this.booktitle_i.Name = "booktitle_i";
            this.booktitle_i.Size = new System.Drawing.Size(363, 56);
            this.booktitle_i.TabIndex = 10;
            // 
            // isbn_i
            // 
            this.isbn_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.isbn_i.Location = new System.Drawing.Point(257, 119);
            this.isbn_i.Name = "isbn_i";
            this.isbn_i.Size = new System.Drawing.Size(363, 56);
            this.isbn_i.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.button1.Location = new System.Drawing.Point(300, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "new book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sellprice_i
            // 
            this.sellprice_i.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.sellprice_i.Location = new System.Drawing.Point(257, 200);
            this.sellprice_i.Name = "sellprice_i";
            this.sellprice_i.Size = new System.Drawing.Size(363, 56);
            this.sellprice_i.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F);
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 48);
            this.label3.TabIndex = 13;
            this.label3.Text = "sell price:";
            // 
            // newbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sellprice_i);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.isbn_i);
            this.Controls.Add(this.booktitle_i);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "newbook";
            this.Text = "new book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox booktitle_i;
        private System.Windows.Forms.TextBox isbn_i;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sellprice_i;
        private System.Windows.Forms.Label label3;
    }
}