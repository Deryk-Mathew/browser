namespace AwesomeBrowser
{
    partial class tabGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabGUI));
            this.back_btn = new System.Windows.Forms.ToolStripButton();
            this.forward_btn = new System.Windows.Forms.ToolStripButton();
            this.home_btn = new System.Windows.Forms.ToolStripButton();
            this.address_bar = new System.Windows.Forms.ToolStripTextBox();
            this.go_btn = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.setHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookmark_tab = new System.Windows.Forms.TabPage();
            this.bookmark_list = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookmarkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.history_tab = new System.Windows.Forms.TabPage();
            this.history_list = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.bookmark_tab.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.history_tab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.back_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(23, 23);
            this.back_btn.Text = "Back";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forward_btn.Image = ((System.Drawing.Image)(resources.GetObject("forward_btn.Image")));
            this.forward_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forward_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(23, 23);
            this.forward_btn.Text = "Forward";
            this.forward_btn.ToolTipText = "Forward";
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(44, 23);
            this.home_btn.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // address_bar
            // 
            this.address_bar.BackColor = System.Drawing.Color.White;
            this.address_bar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address_bar.Name = "address_bar";
            this.address_bar.Size = new System.Drawing.Size(500, 25);
            this.address_bar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.address_bar_KeyUp);
            // 
            // go_btn
            // 
            this.go_btn.BackColor = System.Drawing.SystemColors.Control;
            this.go_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.go_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(26, 23);
            this.go_btn.Text = "Go";
            this.go_btn.ToolTipText = "Go";
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click_1);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setHomepageToolStripMenuItem,
            this.editHomepageToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearHistoryToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // setHomepageToolStripMenuItem
            // 
            this.setHomepageToolStripMenuItem.Name = "setHomepageToolStripMenuItem";
            this.setHomepageToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.setHomepageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.setHomepageToolStripMenuItem.Text = "Set Homepage";
            this.setHomepageToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setHomepageToolStripMenuItem.Click += new System.EventHandler(this.setHomepageToolStripMenuItem_Click);
            // 
            // editHomepageToolStripMenuItem
            // 
            this.editHomepageToolStripMenuItem.Name = "editHomepageToolStripMenuItem";
            this.editHomepageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editHomepageToolStripMenuItem.Text = "Edit Homepage";
            this.editHomepageToolStripMenuItem.Click += new System.EventHandler(this.editHomepageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_btn,
            this.forward_btn,
            this.home_btn,
            this.address_bar,
            this.go_btn,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1297, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.bookmark_tab);
            this.tabControl1.Controls.Add(this.history_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(1130, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(167, 598);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 2;
            this.tabControl1.DoubleClick += new System.EventHandler(this.tabControl1_DoubleClick);
            // 
            // bookmark_tab
            // 
            this.bookmark_tab.Controls.Add(this.bookmark_list);
            this.bookmark_tab.Location = new System.Drawing.Point(4, 4);
            this.bookmark_tab.Name = "bookmark_tab";
            this.bookmark_tab.Padding = new System.Windows.Forms.Padding(3);
            this.bookmark_tab.Size = new System.Drawing.Size(140, 590);
            this.bookmark_tab.TabIndex = 0;
            this.bookmark_tab.Text = "Bookmarks";
            this.bookmark_tab.UseVisualStyleBackColor = true;
            // 
            // bookmark_list
            // 
            this.bookmark_list.ContextMenuStrip = this.contextMenuStrip1;
            this.bookmark_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmark_list.FormattingEnabled = true;
            this.bookmark_list.Location = new System.Drawing.Point(3, 3);
            this.bookmark_list.Name = "bookmark_list";
            this.bookmark_list.Size = new System.Drawing.Size(134, 584);
            this.bookmark_list.TabIndex = 0;
            this.bookmark_list.DoubleClick += new System.EventHandler(this.bookmark_list_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBookmarkToolStripMenuItem,
            this.editBookmarkToolStripMenuItem1,
            this.deleteBookmarkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 92);
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // editBookmarkToolStripMenuItem1
            // 
            this.editBookmarkToolStripMenuItem1.Name = "editBookmarkToolStripMenuItem1";
            this.editBookmarkToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.editBookmarkToolStripMenuItem1.Text = "Edit Bookmark";
            this.editBookmarkToolStripMenuItem1.Click += new System.EventHandler(this.editBookmarkToolStripMenuItem1_Click);
            // 
            // history_tab
            // 
            this.history_tab.Controls.Add(this.history_list);
            this.history_tab.Location = new System.Drawing.Point(4, 4);
            this.history_tab.Name = "history_tab";
            this.history_tab.Padding = new System.Windows.Forms.Padding(3);
            this.history_tab.Size = new System.Drawing.Size(140, 590);
            this.history_tab.TabIndex = 1;
            this.history_tab.Text = "Histroy";
            this.history_tab.UseVisualStyleBackColor = true;
            // 
            // history_list
            // 
            this.history_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_list.FormattingEnabled = true;
            this.history_list.Location = new System.Drawing.Point(3, 3);
            this.history_list.Name = "history_list";
            this.history_list.Size = new System.Drawing.Size(134, 584);
            this.history_list.TabIndex = 0;
            this.history_list.DoubleClick += new System.EventHandler(this.history_list_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.richTextBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 598);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1124, 592);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.clearHistoryToolStripMenuItem.Text = "Clear History";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // deleteBookmarkToolStripMenuItem
            // 
            this.deleteBookmarkToolStripMenuItem.Name = "deleteBookmarkToolStripMenuItem";
            this.deleteBookmarkToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.deleteBookmarkToolStripMenuItem.Text = "Delete Bookmark";
            this.deleteBookmarkToolStripMenuItem.Click += new System.EventHandler(this.deleteBookmarkToolStripMenuItem_Click);
            // 
            // tabGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1297, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabGUI";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.bookmark_tab.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.history_tab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton back_btn;
        private System.Windows.Forms.ToolStripButton forward_btn;
        private System.Windows.Forms.ToolStripButton home_btn;
        private System.Windows.Forms.ToolStripButton go_btn;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem setHomepageToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox address_bar;
        private System.Windows.Forms.ToolStripMenuItem editHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookmark_tab;
        private System.Windows.Forms.TabPage history_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox bookmark_list;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editBookmarkToolStripMenuItem1;
        private System.Windows.Forms.ListBox history_list;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmarkToolStripMenuItem;
    }
}