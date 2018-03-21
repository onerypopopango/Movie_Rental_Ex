namespace ESNET_MovieRentalReturnEx
{
    partial class SearchCustForm
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
            this.CustGridView = new System.Windows.Forms.DataGridView();
            this.CustName_TextBox = new System.Windows.Forms.TextBox();
            this.NameSearch_Button = new System.Windows.Forms.Button();
            this.PhoneNo_Button = new System.Windows.Forms.Button();
            this.PhoneNo_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustGridView
            // 
            this.CustGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGridView.Location = new System.Drawing.Point(12, 130);
            this.CustGridView.MultiSelect = false;
            this.CustGridView.Name = "CustGridView";
            this.CustGridView.ReadOnly = true;
            this.CustGridView.RowHeadersVisible = false;
            this.CustGridView.RowTemplate.Height = 28;
            this.CustGridView.Size = new System.Drawing.Size(611, 206);
            this.CustGridView.TabIndex = 0;
            this.CustGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustGridView_CellContentDoubleClick);
            // 
            // CustName_TextBox
            // 
            this.CustName_TextBox.Location = new System.Drawing.Point(15, 18);
            this.CustName_TextBox.Name = "CustName_TextBox";
            this.CustName_TextBox.Size = new System.Drawing.Size(209, 26);
            this.CustName_TextBox.TabIndex = 1;
            // 
            // NameSearch_Button
            // 
            this.NameSearch_Button.Location = new System.Drawing.Point(230, 12);
            this.NameSearch_Button.Name = "NameSearch_Button";
            this.NameSearch_Button.Size = new System.Drawing.Size(117, 38);
            this.NameSearch_Button.TabIndex = 2;
            this.NameSearch_Button.Text = "Search Name";
            this.NameSearch_Button.UseVisualStyleBackColor = true;
            this.NameSearch_Button.Click += new System.EventHandler(this.NameSearch_Button_Click);
            // 
            // PhoneNo_Button
            // 
            this.PhoneNo_Button.Location = new System.Drawing.Point(230, 66);
            this.PhoneNo_Button.Name = "PhoneNo_Button";
            this.PhoneNo_Button.Size = new System.Drawing.Size(183, 38);
            this.PhoneNo_Button.TabIndex = 4;
            this.PhoneNo_Button.Text = "Search Phone Number";
            this.PhoneNo_Button.UseVisualStyleBackColor = true;
            this.PhoneNo_Button.Click += new System.EventHandler(this.PhoneNo_Button_Click);
            // 
            // PhoneNo_TextBox
            // 
            this.PhoneNo_TextBox.Location = new System.Drawing.Point(15, 72);
            this.PhoneNo_TextBox.Name = "PhoneNo_TextBox";
            this.PhoneNo_TextBox.Size = new System.Drawing.Size(209, 26);
            this.PhoneNo_TextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(514, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // SearchCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(632, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhoneNo_Button);
            this.Controls.Add(this.PhoneNo_TextBox);
            this.Controls.Add(this.NameSearch_Button);
            this.Controls.Add(this.CustName_TextBox);
            this.Controls.Add(this.CustGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCustForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustGridView;
        private System.Windows.Forms.TextBox CustName_TextBox;
        private System.Windows.Forms.Button NameSearch_Button;
        private System.Windows.Forms.Button PhoneNo_Button;
        private System.Windows.Forms.TextBox PhoneNo_TextBox;
        private System.Windows.Forms.Label label1;
    }
}