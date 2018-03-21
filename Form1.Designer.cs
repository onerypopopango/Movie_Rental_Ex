namespace ESNET_MovieRentalReturnEx
{
    partial class RentalForm
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
            this.label_custId = new System.Windows.Forms.Label();
            this.label_movieId = new System.Windows.Forms.Label();
            this.CustId_TextBox = new System.Windows.Forms.TextBox();
            this.CustId_ButtonSearch = new System.Windows.Forms.Button();
            this.MovieId_ButtonSearch = new System.Windows.Forms.Button();
            this.MovieId_TextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.RentalStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Remark_TextBox = new System.Windows.Forms.TextBox();
            this.label_Remark = new System.Windows.Forms.Label();
            this.CustName_TextBox = new System.Windows.Forms.TextBox();
            this.MovieName_TextBox = new System.Windows.Forms.TextBox();
            this.label_dateIssued = new System.Windows.Forms.Label();
            this.DateIssued_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDate_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_dueDate = new System.Windows.Forms.Label();
            this.label_stockLeft = new System.Windows.Forms.Label();
            this.StockLeft_TextBox = new System.Windows.Forms.TextBox();
            this.label_transId = new System.Windows.Forms.Label();
            this.Confirm_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.CustCheck_Button = new System.Windows.Forms.Button();
            this.MovieCheck_Button = new System.Windows.Forms.Button();
            this.TransId_Label = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_custId
            // 
            this.label_custId.AutoSize = true;
            this.label_custId.Location = new System.Drawing.Point(37, 42);
            this.label_custId.Name = "label_custId";
            this.label_custId.Size = new System.Drawing.Size(99, 20);
            this.label_custId.TabIndex = 0;
            this.label_custId.Text = "Customer ID";
            // 
            // label_movieId
            // 
            this.label_movieId.AutoSize = true;
            this.label_movieId.Location = new System.Drawing.Point(37, 120);
            this.label_movieId.Name = "label_movieId";
            this.label_movieId.Size = new System.Drawing.Size(71, 20);
            this.label_movieId.TabIndex = 1;
            this.label_movieId.Text = "Movie ID";
            // 
            // CustId_TextBox
            // 
            this.CustId_TextBox.Location = new System.Drawing.Point(172, 39);
            this.CustId_TextBox.Name = "CustId_TextBox";
            this.CustId_TextBox.Size = new System.Drawing.Size(111, 26);
            this.CustId_TextBox.TabIndex = 2;
            // 
            // CustId_ButtonSearch
            // 
            this.CustId_ButtonSearch.Location = new System.Drawing.Point(289, 38);
            this.CustId_ButtonSearch.Name = "CustId_ButtonSearch";
            this.CustId_ButtonSearch.Size = new System.Drawing.Size(48, 31);
            this.CustId_ButtonSearch.TabIndex = 3;
            this.CustId_ButtonSearch.Text = "...";
            this.CustId_ButtonSearch.UseVisualStyleBackColor = true;
            this.CustId_ButtonSearch.Click += new System.EventHandler(this.CustId_ButtonSearch_Click);
            // 
            // MovieId_ButtonSearch
            // 
            this.MovieId_ButtonSearch.Location = new System.Drawing.Point(289, 116);
            this.MovieId_ButtonSearch.Name = "MovieId_ButtonSearch";
            this.MovieId_ButtonSearch.Size = new System.Drawing.Size(48, 31);
            this.MovieId_ButtonSearch.TabIndex = 5;
            this.MovieId_ButtonSearch.Text = "...";
            this.MovieId_ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // MovieId_TextBox
            // 
            this.MovieId_TextBox.Location = new System.Drawing.Point(172, 117);
            this.MovieId_TextBox.Name = "MovieId_TextBox";
            this.MovieId_TextBox.Size = new System.Drawing.Size(111, 26);
            this.MovieId_TextBox.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RentalStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1001, 30);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // RentalStatusLabel
            // 
            this.RentalStatusLabel.Name = "RentalStatusLabel";
            this.RentalStatusLabel.Size = new System.Drawing.Size(68, 25);
            this.RentalStatusLabel.Text = "Rentals";
            // 
            // Remark_TextBox
            // 
            this.Remark_TextBox.Location = new System.Drawing.Point(629, 36);
            this.Remark_TextBox.Multiline = true;
            this.Remark_TextBox.Name = "Remark_TextBox";
            this.Remark_TextBox.Size = new System.Drawing.Size(319, 171);
            this.Remark_TextBox.TabIndex = 8;
            // 
            // label_Remark
            // 
            this.label_Remark.AutoSize = true;
            this.label_Remark.Location = new System.Drawing.Point(541, 39);
            this.label_Remark.Name = "label_Remark";
            this.label_Remark.Size = new System.Drawing.Size(73, 20);
            this.label_Remark.TabIndex = 7;
            this.label_Remark.Text = "Remarks";
            // 
            // CustName_TextBox
            // 
            this.CustName_TextBox.Location = new System.Drawing.Point(172, 71);
            this.CustName_TextBox.Name = "CustName_TextBox";
            this.CustName_TextBox.ReadOnly = true;
            this.CustName_TextBox.Size = new System.Drawing.Size(242, 26);
            this.CustName_TextBox.TabIndex = 9;
            // 
            // MovieName_TextBox
            // 
            this.MovieName_TextBox.Location = new System.Drawing.Point(172, 149);
            this.MovieName_TextBox.Name = "MovieName_TextBox";
            this.MovieName_TextBox.ReadOnly = true;
            this.MovieName_TextBox.Size = new System.Drawing.Size(242, 26);
            this.MovieName_TextBox.TabIndex = 10;
            // 
            // label_dateIssued
            // 
            this.label_dateIssued.AutoSize = true;
            this.label_dateIssued.Location = new System.Drawing.Point(37, 286);
            this.label_dateIssued.Name = "label_dateIssued";
            this.label_dateIssued.Size = new System.Drawing.Size(96, 20);
            this.label_dateIssued.TabIndex = 11;
            this.label_dateIssued.Text = "Date Issued";
            // 
            // DateIssued_TimePicker
            // 
            this.DateIssued_TimePicker.Location = new System.Drawing.Point(172, 281);
            this.DateIssued_TimePicker.Name = "DateIssued_TimePicker";
            this.DateIssued_TimePicker.Size = new System.Drawing.Size(287, 26);
            this.DateIssued_TimePicker.TabIndex = 12;
            this.DateIssued_TimePicker.Value = new System.DateTime(2018, 3, 21, 0, 0, 0, 0);
            this.DateIssued_TimePicker.ValueChanged += new System.EventHandler(this.DateIssued_TimePicker_ValueChanged);
            // 
            // DueDate_TimePicker
            // 
            this.DueDate_TimePicker.Location = new System.Drawing.Point(172, 334);
            this.DueDate_TimePicker.Name = "DueDate_TimePicker";
            this.DueDate_TimePicker.Size = new System.Drawing.Size(287, 26);
            this.DueDate_TimePicker.TabIndex = 14;
            this.DueDate_TimePicker.Value = new System.DateTime(2018, 3, 21, 11, 30, 14, 0);
            this.DueDate_TimePicker.ValueChanged += new System.EventHandler(this.DueDate_TimePicker_ValueChanged);
            // 
            // label_dueDate
            // 
            this.label_dueDate.AutoSize = true;
            this.label_dueDate.Location = new System.Drawing.Point(37, 339);
            this.label_dueDate.Name = "label_dueDate";
            this.label_dueDate.Size = new System.Drawing.Size(78, 20);
            this.label_dueDate.TabIndex = 13;
            this.label_dueDate.Text = "Due Date";
            // 
            // label_stockLeft
            // 
            this.label_stockLeft.AutoSize = true;
            this.label_stockLeft.Location = new System.Drawing.Point(37, 181);
            this.label_stockLeft.Name = "label_stockLeft";
            this.label_stockLeft.Size = new System.Drawing.Size(82, 20);
            this.label_stockLeft.TabIndex = 15;
            this.label_stockLeft.Text = "Stock Left";
            // 
            // StockLeft_TextBox
            // 
            this.StockLeft_TextBox.Location = new System.Drawing.Point(172, 181);
            this.StockLeft_TextBox.Name = "StockLeft_TextBox";
            this.StockLeft_TextBox.ReadOnly = true;
            this.StockLeft_TextBox.Size = new System.Drawing.Size(242, 26);
            this.StockLeft_TextBox.TabIndex = 16;
            // 
            // label_transId
            // 
            this.label_transId.AutoSize = true;
            this.label_transId.Location = new System.Drawing.Point(37, 410);
            this.label_transId.Name = "label_transId";
            this.label_transId.Size = new System.Drawing.Size(113, 20);
            this.label_transId.TabIndex = 17;
            this.label_transId.Text = "Transaction ID";
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Location = new System.Drawing.Point(661, 349);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.Size = new System.Drawing.Size(261, 84);
            this.Confirm_Button.TabIndex = 19;
            this.Confirm_Button.Text = "Confirm";
            this.Confirm_Button.UseVisualStyleBackColor = true;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(731, 451);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(124, 36);
            this.Cancel_Button.TabIndex = 20;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // CustCheck_Button
            // 
            this.CustCheck_Button.Location = new System.Drawing.Point(343, 38);
            this.CustCheck_Button.Name = "CustCheck_Button";
            this.CustCheck_Button.Size = new System.Drawing.Size(71, 31);
            this.CustCheck_Button.TabIndex = 21;
            this.CustCheck_Button.Text = "Check";
            this.CustCheck_Button.UseVisualStyleBackColor = true;
            this.CustCheck_Button.Click += new System.EventHandler(this.CustCheck_Button_Click);
            // 
            // MovieCheck_Button
            // 
            this.MovieCheck_Button.Location = new System.Drawing.Point(343, 116);
            this.MovieCheck_Button.Name = "MovieCheck_Button";
            this.MovieCheck_Button.Size = new System.Drawing.Size(71, 31);
            this.MovieCheck_Button.TabIndex = 22;
            this.MovieCheck_Button.Text = "Check";
            this.MovieCheck_Button.UseVisualStyleBackColor = true;
            this.MovieCheck_Button.Click += new System.EventHandler(this.MovieCheck_Button_Click);
            // 
            // TransId_Label
            // 
            this.TransId_Label.AutoSize = true;
            this.TransId_Label.Location = new System.Drawing.Point(168, 410);
            this.TransId_Label.Name = "TransId_Label";
            this.TransId_Label.Size = new System.Drawing.Size(35, 20);
            this.TransId_Label.TabIndex = 23;
            this.TransId_Label.Text = "Null";
            // 
            // RentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 559);
            this.Controls.Add(this.TransId_Label);
            this.Controls.Add(this.MovieCheck_Button);
            this.Controls.Add(this.CustCheck_Button);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.label_transId);
            this.Controls.Add(this.StockLeft_TextBox);
            this.Controls.Add(this.label_stockLeft);
            this.Controls.Add(this.DueDate_TimePicker);
            this.Controls.Add(this.label_dueDate);
            this.Controls.Add(this.DateIssued_TimePicker);
            this.Controls.Add(this.label_dateIssued);
            this.Controls.Add(this.MovieName_TextBox);
            this.Controls.Add(this.CustName_TextBox);
            this.Controls.Add(this.Remark_TextBox);
            this.Controls.Add(this.label_Remark);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MovieId_ButtonSearch);
            this.Controls.Add(this.MovieId_TextBox);
            this.Controls.Add(this.CustId_ButtonSearch);
            this.Controls.Add(this.CustId_TextBox);
            this.Controls.Add(this.label_movieId);
            this.Controls.Add(this.label_custId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RentalForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rentals";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_custId;
        private System.Windows.Forms.Label label_movieId;
        private System.Windows.Forms.TextBox CustId_TextBox;
        private System.Windows.Forms.Button CustId_ButtonSearch;
        private System.Windows.Forms.Button MovieId_ButtonSearch;
        private System.Windows.Forms.TextBox MovieId_TextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel RentalStatusLabel;
        private System.Windows.Forms.TextBox Remark_TextBox;
        private System.Windows.Forms.Label label_Remark;
        private System.Windows.Forms.TextBox CustName_TextBox;
        private System.Windows.Forms.TextBox MovieName_TextBox;
        private System.Windows.Forms.Label label_dateIssued;
        private System.Windows.Forms.DateTimePicker DateIssued_TimePicker;
        private System.Windows.Forms.DateTimePicker DueDate_TimePicker;
        private System.Windows.Forms.Label label_dueDate;
        private System.Windows.Forms.Label label_stockLeft;
        private System.Windows.Forms.TextBox StockLeft_TextBox;
        private System.Windows.Forms.Label label_transId;
        private System.Windows.Forms.Button Confirm_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button CustCheck_Button;
        private System.Windows.Forms.Button MovieCheck_Button;
        private System.Windows.Forms.Label TransId_Label;
    }
}

