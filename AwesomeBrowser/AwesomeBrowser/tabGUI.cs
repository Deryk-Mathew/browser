using System;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class tabGUI : Form
    {
        LocalHistory local_hist = new LocalHistory();
       
        public static Bookmarks books = new Bookmarks();

        public tabGUI()
        {
            InitializeComponent();
            local_hist.addLocalHistory(Properties.Settings.Default.homepage);
            richTextBox1.Text = GetWebPage.getPage(local_hist.getHomePage());
            generateBookMarks();
        }

        private void go_btn_Click_1(object sender, EventArgs e)
        {
            if(address_bar.Text != "") {
                richTextBox1.Text = GetWebPage.getPage(address_bar.Text);
                local_hist.addLocalHistory(address_bar.Text);
            }           
         }

        private void home_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(local_hist.getHomePage());
        }

        private void setHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomepageDialog home = new HomepageDialog();
            home.Show();
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(local_hist.back());
            //richTextBox1.Text = hist.back();
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(local_hist.forward());
            //richTextBox1.Text = hist.forward();
        }

        private void editHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomepageDialog home = new HomepageDialog();
            home.urlEditName();
            home.Show();
        }

        public void generateBookMarks()
        {
            System.Collections.Generic.List<string> list = books.displayBookmarks();
            
            foreach (string value in list)
            {
                bookmarksToolStripMenuItem.DropDownItems.Add(value);
                bookmark_list.Items.Add(value);
            }
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            bookForm.Show();
        }

        private void editBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            bookForm.Show();
        }

        private void bookmark_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(books.getBookmark(bookmark_list.SelectedItem.ToString()));

        }

        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.Size.Width > 20)
                this.tabControl1.Size = new System.Drawing.Size(20, 566);
            else
                this.tabControl1.Size = new System.Drawing.Size(200, 566);
        }
    }
}
