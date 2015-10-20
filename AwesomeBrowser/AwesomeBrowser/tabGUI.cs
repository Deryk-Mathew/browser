using System;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class tabGUI : Form
    {
        LocalHistory local_hist = new LocalHistory();
        GlobalHistory global_hist = new GlobalHistory();
       
        public static Bookmarks books = new Bookmarks();

        public tabGUI()
        {
            InitializeComponent();
            local_hist.addLocalHistory(Properties.Settings.Default.homepage);
            richTextBox1.Text = GetWebPage.getPage(local_hist.getHomePage());
            generateBookMarks();
            generateHistory();
        }

        private void go_btn_Click_1(object sender, EventArgs e)
        {
            if(address_bar.Text != "") {
                richTextBox1.Text = GetWebPage.getPage(address_bar.Text);
                local_hist.addLocalHistory(address_bar.Text);
                global_hist.addHistory(address_bar.Text, DateTime.Now.ToString("h:mm:ss tt"));
                history_list.Refresh();
            }           
         }

        private void home_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(Properties.Settings.Default.homepage);
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
            bookmark_list.Items.Clear();
            foreach (string value in list)
            {
               bookmark_list.Items.Add(value);
            }
        }

        public void generateHistory()
        {
            System.Collections.Generic.List<string> list = global_hist.displayHistory();

            foreach (string value in list)
            {
                history_list.Items.Add(value);
            }
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

        private void editBookmarkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            bookForm.editBookmark(bookmark_list.SelectedItem.ToString());
            bookForm.Show();
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            if(bookForm.ShowDialog() == DialogResult.OK)
            {
                generateBookMarks();
            }
        }
    }
}
