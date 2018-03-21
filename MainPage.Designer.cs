namespace ESNET_MovieRentalReturnEx
{
    partial class MainPage
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
            this.RentalsButton = new System.Windows.Forms.Button();
            this.ReturnsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RentalsButton
            // 
            this.RentalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalsButton.Location = new System.Drawing.Point(12, 267);
            this.RentalsButton.Name = "RentalsButton";
            this.RentalsButton.Size = new System.Drawing.Size(270, 128);
            this.RentalsButton.TabIndex = 0;
            this.RentalsButton.Text = "Rentals";
            this.RentalsButton.UseVisualStyleBackColor = true;
            this.RentalsButton.Click += new System.EventHandler(this.RentalsButton_Click);
            // 
            // ReturnsButton
            // 
            this.ReturnsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnsButton.Location = new System.Drawing.Point(290, 267);
            this.ReturnsButton.Name = "ReturnsButton";
            this.ReturnsButton.Size = new System.Drawing.Size(270, 128);
            this.ReturnsButton.TabIndex = 1;
            this.ReturnsButton.Text = "Returns";
            this.ReturnsButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnsButton);
            this.Controls.Add(this.RentalsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RentalsButton;
        private System.Windows.Forms.Button ReturnsButton;
        private System.Windows.Forms.Button button1;
    }
}