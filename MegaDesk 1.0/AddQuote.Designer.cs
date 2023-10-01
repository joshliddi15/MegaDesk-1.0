namespace MegaDesk_1._0
{
    partial class AddQuote
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
            dateLabel = new Label();
            custNameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            matlBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(731, 25);
            dateLabel.Margin = new Padding(7, 0, 7, 0);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(130, 54);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "label2";
            // 
            // custNameInput
            // 
            custNameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            custNameInput.Location = new Point(459, 219);
            custNameInput.Margin = new Padding(7, 8, 7, 8);
            custNameInput.Name = "custNameInput";
            custNameInput.Size = new Size(611, 61);
            custNameInput.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 227);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(121, 0, 0, 0);
            label1.Size = new Size(431, 54);
            label1.TabIndex = 3;
            label1.Text = "Customer Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 347);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(121, 0, 0, 0);
            label2.Size = new Size(349, 54);
            label2.TabIndex = 5;
            label2.Text = "Desk Width";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(459, 339);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(611, 61);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += deskWidth_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 467);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(121, 0, 0, 0);
            label3.Size = new Size(351, 54);
            label3.TabIndex = 7;
            label3.Text = "Desk Depth";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(459, 459);
            textBox2.Margin = new Padding(7, 8, 7, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(611, 61);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += deskDepth_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-36, 588);
            label4.Margin = new Padding(7, 0, 7, 0);
            label4.Name = "label4";
            label4.Padding = new Padding(121, 0, 0, 0);
            label4.Size = new Size(491, 54);
            label4.TabIndex = 9;
            label4.Text = "Number of Drawers";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(459, 579);
            textBox3.Margin = new Padding(7, 8, 7, 8);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(611, 61);
            textBox3.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 708);
            label5.Margin = new Padding(7, 0, 7, 0);
            label5.Name = "label5";
            label5.Padding = new Padding(121, 0, 0, 0);
            label5.Size = new Size(430, 54);
            label5.TabIndex = 11;
            label5.Text = "Surface Material";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(121, 828);
            label6.Margin = new Padding(7, 0, 7, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(121, 0, 0, 0);
            label6.Size = new Size(326, 54);
            label6.TabIndex = 13;
            label6.Text = "Rush Days";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(459, 820);
            textBox5.Margin = new Padding(7, 8, 7, 8);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(611, 61);
            textBox5.TabIndex = 12;
            // 
            // matlBox
            // 
            matlBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            matlBox.FormattingEnabled = true;
            matlBox.Location = new Point(459, 700);
            matlBox.Margin = new Padding(7, 8, 7, 8);
            matlBox.Name = "matlBox";
            matlBox.Size = new Size(611, 62);
            matlBox.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(731, 1091);
            button1.Name = "button1";
            button1.Size = new Size(507, 185);
            button1.TabIndex = 15;
            button1.Text = "Submit Quote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SubmitQuote_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(121, 1091);
            button2.Name = "button2";
            button2.Size = new Size(453, 185);
            button2.TabIndex = 15;
            button2.Text = "Return Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(459, 408);
            label7.Name = "label7";
            label7.Size = new Size(634, 41);
            label7.TabIndex = 16;
            label7.Text = "Desk width must be between 24 and 96 inches";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(459, 525);
            label8.Name = "label8";
            label8.Size = new Size(634, 41);
            label8.TabIndex = 17;
            label8.Text = "Desk width must be between 12 and 48 inches";
            label8.Visible = false;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 1356);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(matlBox);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(custNameInput);
            Controls.Add(dateLabel);
            Margin = new Padding(7, 8, 7, 8);
            Name = "AddQuote";
            Text = "AddQuote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label dateLabel;
        private TextBox custNameInput;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private ComboBox matlBox;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
    }
}