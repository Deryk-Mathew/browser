namespace AwesomeBrowser
{
    partial class BookmarkForm
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
            this.bookmark_submit_btn = new System.Windows.Forms.Button();
            this.url_textbox = new System.Windows.Forms.TextBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bookmark_submit_btn
            // 
            this.bookmark_submit_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bookmark_submit_btn.Location = new System.Drawing.Point(166, 148);
            this.bookmark_submit_btn.Name = "bookmark_submit_btn";
            this.bookmark_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.bookmark_submit_btn.TabIndex = 0;
            this.bookmark_submit_btn.Text = "Submit";
            this.bookmark_submit_btn.UseVisualStyleBackColor = true;
            this.bookmark_submit_btn.Click += new System.EventHandler(this.bookmark_submit_btn_Click);
            // 
            // url_textbox
            // 
            this.url_textbox.Location = new System.Drawing.Point(21, 45);
            this.url_textbox.Name = "url_textbox";
            this.url_textbox.Size = new System.Drawing.Size(219, 20);
            this.url_textbox.TabIndex = 1;
            // 
            // title_textbox
            // 
            this.title_textbox.Location = new System.Drawing.Point(22, 107);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(219, 20);
            this.title_textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Title";
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 196);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.url_textbox);
            this.Controls.Add(this.bookmark_submit_btn);
            this.Name = "BookmarkForm";
            this.Text = "Bookmark Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bookmark_submit_btn;
        private System.Windows.Forms.TextBox url_textbox;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}