namespace MegaDesk_1._0
{
    partial class SearchQuotes
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
            components = new System.ComponentModel.Container();
            matlBox = new ComboBox();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            QuotesListBox = new DataGridView();
            dataBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuotesListBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // matlBox
            // 
            matlBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            matlBox.FormattingEnabled = true;
            matlBox.Location = new Point(713, 6);
            matlBox.Name = "matlBox";
            matlBox.Size = new Size(206, 29);
            matlBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(579, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 1;
            label1.Text = "Desktop Material";
            // 
            // QuotesListBox
            // 
            QuotesListBox.AutoGenerateColumns = false;
            QuotesListBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QuotesListBox.DataSource = dataBindingSource;
            QuotesListBox.Location = new Point(28, 49);
            QuotesListBox.Name = "QuotesListBox";
            QuotesListBox.RowTemplate.Height = 25;
            QuotesListBox.Size = new Size(843, 383);
            QuotesListBox.TabIndex = 2;
            // 
            // dataBindingSource
            // 
            dataBindingSource.DataSource = typeof(BindingSource);
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(923, 450);
            Controls.Add(QuotesListBox);
            Controls.Add(label1);
            Controls.Add(matlBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchQuotes";
            Text = "SearchQuotes";
            Load += SearchQuotes_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuotesListBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox matlBox;
        private Label label1;
        private BindingSource bindingSource1;
        private DataGridView QuotesListBox;
        private BindingSource dataBindingSource;
        private DataGridViewTextBoxColumn quoteID;
        private DataGridViewTextBoxColumn deskWidth;
    }
}