using System;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class tabGUI : Form
    {
        LocalHistory local_hist = new LocalHistory();
        static GlobalHistory global_hist = new GlobalHistory();
        public static Bookmarks books = new Bookmarks();

        public tabGUI()
        {
            InitializeComponent();
            local_hist.addLocalHistory(Properties.Settings.Default.homepage);
            richTextBox1.Text = GetWebPage.getPage(local_hist.getHomePage());
            bookmark_list.Items.Add(books.readBookmark());
        }

        private void go_btn_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(address_bar.Text);
            local_hist.addLocalHistory(address_bar.Text);
         }

        private void home_btn_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = GetWebPage.getPage(Properties.Settings.Default.homepage);
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

        private void addBookmarkMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            bookForm.Show();
        }

        private void editBookmarkMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
