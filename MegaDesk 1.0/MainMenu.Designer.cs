namespace MegaDesk_1._0
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            newQuoteBtn = new Button();
            viewQuoteBtn = new Button();
            searchQuoteBtn = new Button();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.desk_img;
            pictureBox1.Location = new Point(733, 109);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(437, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // newQuoteBtn
            // 
            newQuoteBtn.Location = new Point(75, 71);
            newQuoteBtn.Margin = new Padding(2, 3, 2, 3);
            newQuoteBtn.Name = "newQuoteBtn";
            newQuoteBtn.Size = new Size(447, 123);
            newQuoteBtn.TabIndex = 1;
            newQuoteBtn.Text = "Add New Quote";
            newQuoteBtn.UseVisualStyleBackColor = true;
            newQuoteBtn.Click += newQuoteBtn_Click;
            // 
            // viewQuoteBtn
            // 
            viewQuoteBtn.Location = new Point(75, 210);
            viewQuoteBtn.Margin = new Padding(2, 3, 2, 3);
            viewQuoteBtn.Name = "viewQuoteBtn";
            viewQuoteBtn.Size = new Size(447, 123);
            viewQuoteBtn.TabIndex = 2;
            viewQuoteBtn.Text = "View Quotes";
            viewQuoteBtn.UseVisualStyleBackColor = true;
            viewQuoteBtn.Click += viewAllQuotesBtnClick;
            // 
            // searchQuoteBtn
            // 
            searchQuoteBtn.Location = new Point(75, 347);
            searchQuoteBtn.Margin = new Padding(2, 3, 2, 3);
            searchQuoteBtn.Name = "searchQuoteBtn";
            searchQuoteBtn.Size = new Size(447, 123);
            searchQuoteBtn.TabIndex = 3;
            searchQuoteBtn.Text = "Search Quotes";
            searchQuoteBtn.UseVisualStyleBackColor = true;
            searchQuoteBtn.Click += searchQuotesBtnClick;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(75, 487);
            exitBtn.Margin = new Padding(2, 3, 2, 3);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(447, 123);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtnClick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 713);
            Controls.Add(exitBtn);
            Controls.Add(searchQuoteBtn);
            Controls.Add(viewQuoteBtn);
            Controls.Add(newQuoteBtn);
            Controls.Add(pictureBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainMenu";
            Text = "MegaDesk 1.0 Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button newQuoteBtn;
        private Button viewQuoteBtn;
        private Button searchQuoteBtn;
        private Button exitBtn;
    }
}