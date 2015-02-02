namespace WiiBannerWinForms
{
    partial class WiiBannerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BannersListBox = new System.Windows.Forms.ListBox();
            this.LoadBannersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wii Banner Example App";
            // 
            // BannersListBox
            // 
            this.BannersListBox.FormattingEnabled = true;
            this.BannersListBox.Location = new System.Drawing.Point(154, 53);
            this.BannersListBox.Name = "BannersListBox";
            this.BannersListBox.Size = new System.Drawing.Size(245, 277);
            this.BannersListBox.TabIndex = 1;
            // 
            // LoadBannersButton
            // 
            this.LoadBannersButton.Location = new System.Drawing.Point(154, 355);
            this.LoadBannersButton.Name = "LoadBannersButton";
            this.LoadBannersButton.Size = new System.Drawing.Size(245, 44);
            this.LoadBannersButton.TabIndex = 2;
            this.LoadBannersButton.Text = "Load Banners";
            this.LoadBannersButton.UseVisualStyleBackColor = true;
            this.LoadBannersButton.Click += new System.EventHandler(this.LoadBannersButton_Click);
            // 
            // WiiBannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 427);
            this.Controls.Add(this.LoadBannersButton);
            this.Controls.Add(this.BannersListBox);
            this.Controls.Add(this.label1);
            this.Name = "WiiBannerForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox BannersListBox;
        private System.Windows.Forms.Button LoadBannersButton;
    }
}

