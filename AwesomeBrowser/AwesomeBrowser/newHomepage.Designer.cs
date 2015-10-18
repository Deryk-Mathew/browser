namespace AwesomeBrowser
{
    partial class HomepageDialog
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
            this.homepage_address = new System.Windows.Forms.TextBox();
            this.submit_new_homepage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homepage_address
            // 
            this.homepage_address.Location = new System.Drawing.Point(12, 36);
            this.homepage_address.Name = "homepage_address";
            this.homepage_address.Size = new System.Drawing.Size(204, 20);
            this.homepage_address.TabIndex = 0;
            
            // 
            // submit_new_homepage
            // 
            this.submit_new_homepage.Location = new System.Drawing.Point(126, 62);
            this.submit_new_homepage.Name = "submit_new_homepage";
            this.submit_new_homepage.Size = new System.Drawing.Size(90, 20);
            this.submit_new_homepage.TabIndex = 1;
            this.submit_new_homepage.Text = "Submit";
            this.submit_new_homepage.UseVisualStyleBackColor = true;
            this.submit_new_homepage.Click += new System.EventHandler(this.submit_new_homepage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter New Homepage";
            // 
            // Homepage_Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 101);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_new_homepage);
            this.Controls.Add(this.homepage_address);
            this.Name = "Homepage_Dialog";
            this.Text = "New Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox homepage_address;
        private System.Windows.Forms.Button submit_new_homepage;
        private System.Windows.Forms.Label label1;
    }
}