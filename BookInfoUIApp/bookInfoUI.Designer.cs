namespace BookInfoUIApp
{
    partial class bookInfoUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addInfoButton = new System.Windows.Forms.Button();
            this.bookDetailsAddTextBox = new System.Windows.Forms.TextBox();
            this.isbnToAddBookTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchInfoButton = new System.Windows.Forms.Button();
            this.bookDetailsSearchTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnToSearchBookTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addInfoButton);
            this.groupBox1.Controls.Add(this.bookDetailsAddTextBox);
            this.groupBox1.Controls.Add(this.isbnToAddBookTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Book Info";
            // 
            // addInfoButton
            // 
            this.addInfoButton.Location = new System.Drawing.Point(504, 54);
            this.addInfoButton.Name = "addInfoButton";
            this.addInfoButton.Size = new System.Drawing.Size(124, 23);
            this.addInfoButton.TabIndex = 2;
            this.addInfoButton.Text = "Add Info";
            this.addInfoButton.UseVisualStyleBackColor = true;
            this.addInfoButton.Click += new System.EventHandler(this.addInfoButton_Click);
            // 
            // bookDetailsAddTextBox
            // 
            this.bookDetailsAddTextBox.Location = new System.Drawing.Point(131, 54);
            this.bookDetailsAddTextBox.Multiline = true;
            this.bookDetailsAddTextBox.Name = "bookDetailsAddTextBox";
            this.bookDetailsAddTextBox.Size = new System.Drawing.Size(331, 123);
            this.bookDetailsAddTextBox.TabIndex = 1;
            // 
            // isbnToAddBookTextBox
            // 
            this.isbnToAddBookTextBox.Location = new System.Drawing.Point(131, 20);
            this.isbnToAddBookTextBox.Name = "isbnToAddBookTextBox";
            this.isbnToAddBookTextBox.Size = new System.Drawing.Size(331, 20);
            this.isbnToAddBookTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchInfoButton);
            this.groupBox2.Controls.Add(this.bookDetailsSearchTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.isbnToSearchBookTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(633, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Book";
            // 
            // searchInfoButton
            // 
            this.searchInfoButton.Location = new System.Drawing.Point(503, 54);
            this.searchInfoButton.Name = "searchInfoButton";
            this.searchInfoButton.Size = new System.Drawing.Size(124, 23);
            this.searchInfoButton.TabIndex = 1;
            this.searchInfoButton.Text = "Search Info";
            this.searchInfoButton.UseVisualStyleBackColor = true;
            this.searchInfoButton.Click += new System.EventHandler(this.searchInfoButton_Click);
            // 
            // bookDetailsSearchTextBox
            // 
            this.bookDetailsSearchTextBox.Location = new System.Drawing.Point(130, 54);
            this.bookDetailsSearchTextBox.Multiline = true;
            this.bookDetailsSearchTextBox.Name = "bookDetailsSearchTextBox";
            this.bookDetailsSearchTextBox.Size = new System.Drawing.Size(331, 123);
            this.bookDetailsSearchTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ISBN";
            // 
            // isbnToSearchBookTextBox
            // 
            this.isbnToSearchBookTextBox.Location = new System.Drawing.Point(130, 20);
            this.isbnToSearchBookTextBox.Name = "isbnToSearchBookTextBox";
            this.isbnToSearchBookTextBox.Size = new System.Drawing.Size(331, 20);
            this.isbnToSearchBookTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Details";
            // 
            // bookInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 412);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "bookInfoUI";
            this.Text = "Book Info UI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addInfoButton;
        private System.Windows.Forms.TextBox bookDetailsAddTextBox;
        private System.Windows.Forms.TextBox isbnToAddBookTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchInfoButton;
        private System.Windows.Forms.TextBox bookDetailsSearchTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnToSearchBookTextBox;
        private System.Windows.Forms.Label label4;

    }
}

