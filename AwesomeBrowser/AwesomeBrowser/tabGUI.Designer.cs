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
            this.tabGUIToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bookmark_tab = new System.Windows.Forms.TabPage();
            this.bookmark_list = new System.Windows.Forms.ListBox();
            this.bookmarksContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editBookmarkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBookmarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.history_tab = new System.Windows.Forms.TabPage();
            this.history_list = new System.Windows.Forms.ListBox();
            this.historyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.browserText = new System.Windows.Forms.RichTextBox();
            this.myWorker = new System.ComponentModel.BackgroundWorker();
            this.tabGUIToolStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.bookmark_tab.SuspendLayout();
            this.bookmarksContextMenu.SuspendLayout();
            this.history_tab.SuspendLayout();
            this.historyContextMenu.SuspendLayout();
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
            this.home_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.home_btn.Image = ((System.Drawing.Image)(resources.GetObject("home_btn.Image")));
            this.home_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.home_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(23, 23);
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
            this.go_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.go_btn.Image = ((System.Drawing.Image)(resources.GetObject("go_btn.Image")));
            this.go_btn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(23, 23);
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
            this.editHomepageToolStripMenuItem});
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
            this.setHomepageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.setHomepageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.setHomepageToolStripMenuItem.Text = "Set Homepage";
            this.setHomepageToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setHomepageToolStripMenuItem.Click += new System.EventHandler(this.setHomepageToolStripMenuItem_Click);
            // 
            // editHomepageToolStripMenuItem
            // 
            this.editHomepageToolStripMenuItem.Name = "editHomepageToolStripMenuItem";
            this.editHomepageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.H)));
            this.editHomepageToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.editHomepageToolStripMenuItem.Text = "Edit Homepage";
            this.editHomepageToolStripMenuItem.Click += new System.EventHandler(this.editHomepageToolStripMenuItem_Click);
            // 
            // tabGUIToolStrip
            // 
            this.tabGUIToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.back_btn,
            this.forward_btn,
            this.home_btn,
            this.address_bar,
            this.go_btn,
            this.toolStripDropDownButton1});
            this.tabGUIToolStrip.Location = new System.Drawing.Point(0, 0);
            this.tabGUIToolStrip.Name = "tabGUIToolStrip";
            this.tabGUIToolStrip.Size = new System.Drawing.Size(1297, 25);
            this.tabGUIToolStrip.Stretch = true;
            this.tabGUIToolStrip.TabIndex = 0;
            this.tabGUIToolStrip.Text = "tabGUIToolStrip";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.bookmark_tab);
            this.tabControl1.Controls.Add(this.history_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(1277, 25);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(20, 598);
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
            this.bookmark_tab.Size = new System.Drawing.Size(0, 590);
            this.bookmark_tab.TabIndex = 0;
            this.bookmark_tab.Text = "Bookmarks";
            this.bookmark_tab.UseVisualStyleBackColor = true;
            // 
            // bookmark_list
            // 
            this.bookmark_list.ContextMenuStrip = this.bookmarksContextMenu;
            this.bookmark_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmark_list.FormattingEnabled = true;
            this.bookmark_list.Location = new System.Drawing.Point(3, 3);
            this.bookmark_list.Name = "bookmark_list";
            this.bookmark_list.Size = new System.Drawing.Size(0, 584);
            this.bookmark_list.TabIndex = 0;
            this.bookmark_list.DoubleClick += new System.EventHandler(this.bookmark_list_SelectedIndexChanged);
            // 
            // bookmarksContextMenu
            // 
            this.bookmarksContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPageToolStripMenuItem,
            this.addBookmarkToolStripMenuItem,
            this.editBookmarkToolStripMenuItem1,
            this.deleteBookmarkToolStripMenuItem});
            this.bookmarksContextMenu.Name = "contextMenuStrip1";
            this.bookmarksContextMenu.Size = new System.Drawing.Size(230, 92);
            // 
            // loadPageToolStripMenuItem
            // 
            this.loadPageToolStripMenuItem.Name = "loadPageToolStripMenuItem";
            this.loadPageToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.loadPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.loadPageToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.loadPageToolStripMenuItem.Text = "&Load Page";
            this.loadPageToolStripMenuItem.Click += new System.EventHandler(this.bookmark_list_SelectedIndexChanged);
            // 
            // addBookmarkToolStripMenuItem
            // 
            this.addBookmarkToolStripMenuItem.Name = "addBookmarkToolStripMenuItem";
            this.addBookmarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.addBookmarkToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.addBookmarkToolStripMenuItem.Text = "Add Bookmark";
            this.addBookmarkToolStripMenuItem.Click += new System.EventHandler(this.addBookmarkToolStripMenuItem_Click);
            // 
            // editBookmarkToolStripMenuItem1
            // 
            this.editBookmarkToolStripMenuItem1.Name = "editBookmarkToolStripMenuItem1";
            this.editBookmarkToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.E)));
            this.editBookmarkToolStripMenuItem1.Size = new System.Drawing.Size(229, 22);
            this.editBookmarkToolStripMenuItem1.Text = "Edit Bookmark";
            this.editBookmarkToolStripMenuItem1.Click += new System.EventHandler(this.editBookmarkToolStripMenuItem1_Click);
            // 
            // deleteBookmarkToolStripMenuItem
            // 
            this.deleteBookmarkToolStripMenuItem.Name = "deleteBookmarkToolStripMenuItem";
            this.deleteBookmarkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.deleteBookmarkToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.deleteBookmarkToolStripMenuItem.Text = "&Delete Bookmark";
            this.deleteBookmarkToolStripMenuItem.Click += new System.EventHandler(this.deleteBookmarkToolStripMenuItem_Click);
            // 
            // history_tab
            // 
            this.history_tab.Controls.Add(this.history_list);
            this.history_tab.Location = new System.Drawing.Point(4, 4);
            this.history_tab.Name = "history_tab";
            this.history_tab.Padding = new System.Windows.Forms.Padding(3);
            this.history_tab.Size = new System.Drawing.Size(0, 590);
            this.history_tab.TabIndex = 1;
            this.history_tab.Text = "Histroy";
            this.history_tab.UseVisualStyleBackColor = true;
            // 
            // history_list
            // 
            this.history_list.ContextMenuStrip = this.historyContextMenu;
            this.history_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_list.FormattingEnabled = true;
            this.history_list.Location = new System.Drawing.Point(3, 3);
            this.history_list.Name = "history_list";
            this.history_list.Size = new System.Drawing.Size(0, 584);
            this.history_list.TabIndex = 0;
            this.history_list.DoubleClick += new System.EventHandler(this.history_list_SelectedIndexChanged);
            // 
            // historyContextMenu
            // 
            this.historyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPageToolStripMenuItem1,
            this.clearHistoryToolStripMenuItem1});
            this.historyContextMenu.Name = "historyContextMenu";
            this.historyContextMenu.Size = new System.Drawing.Size(208, 48);
            // 
            // loadPageToolStripMenuItem1
            // 
            this.loadPageToolStripMenuItem1.Name = "loadPageToolStripMenuItem1";
            this.loadPageToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.L)));
            this.loadPageToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.loadPageToolStripMenuItem1.Text = "&Load Page";
            this.loadPageToolStripMenuItem1.Click += new System.EventHandler(this.history_list_SelectedIndexChanged);
            // 
            // clearHistoryToolStripMenuItem1
            // 
            this.clearHistoryToolStripMenuItem1.Name = "clearHistoryToolStripMenuItem1";
            this.clearHistoryToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.clearHistoryToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.clearHistoryToolStripMenuItem1.Text = "&Clear History";
            this.clearHistoryToolStripMenuItem1.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.browserText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1277, 598);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // browserText
            // 
            this.browserText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserText.Location = new System.Drawing.Point(3, 3);
            this.browserText.Name = "browserText";
            this.browserText.Size = new System.Drawing.Size(1271, 592);
            this.browserText.TabIndex = 0;
            this.browserText.Text = "";
            // 
            // myWorker
            // 
            this.myWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myWorker_DoWork);
            // 
            // tabGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1297, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabGUIToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabGUI";
            this.Text = "Form2";
            this.tabGUIToolStrip.ResumeLayout(false);
            this.tabGUIToolStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.bookmark_tab.ResumeLayout(false);
            this.bookmarksContextMenu.ResumeLayout(false);
            this.history_tab.ResumeLayout(false);
            this.historyContextMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStrip tabGUIToolStrip;
        private System.Windows.Forms.ToolStripMenuItem setHomepageToolStripMenuItem;
        public System.Windows.Forms.ToolStripTextBox address_bar;
        private System.Windows.Forms.ToolStripMenuItem editHomepageToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage bookmark_tab;
        private System.Windows.Forms.TabPage history_tab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox browserText;
        private System.Windows.Forms.ListBox bookmark_list;
        private System.Windows.Forms.ContextMenuStrip bookmarksContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editBookmarkToolStripMenuItem1;
        private System.Windows.Forms.ListBox history_list;
        private System.Windows.Forms.ToolStripMenuItem addBookmarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmarkToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip historyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem1;
        private System.ComponentModel.BackgroundWorker myWorker;
        private System.Windows.Forms.ToolStripMenuItem loadPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPageToolStripMenuItem1;
    }
}