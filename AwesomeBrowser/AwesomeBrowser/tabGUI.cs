using System;
using System.Linq;
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
            global_hist.addHistory(address_bar.Text);
            generateBookMarks();
            generateHistory();
        }

        private void go_btn_Click_1(object sender, EventArgs e)
        {
            if(address_bar.Text != "") {
                richTextBox1.Text = GetWebPage.getPage(address_bar.Text);
                local_hist.addLocalHistory(address_bar.Text);
                global_hist.addHistory(address_bar.Text);
                history_list.Refresh();
            }           
         }

        //
        // Home button click event
        //
        private void home_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(Properties.Settings.Default.homepage);
        }

        //
        // Set hompage tool menu event
        //
        private void setHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomepageDialog home = new HomepageDialog();
            home.Show();
        }

        //
        // Back Button key event
        //
        private void back_btn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(local_hist.back());
        }

        //
        // Forward Button key event
        //
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
            foreach (string value in list.OrderBy(x => x))
            {
               bookmark_list.Items.Add(value);
            }
        }

        public void generateHistory()
        {
            System.Collections.Generic.HashSet<string> list = global_hist.displayHistory();
            history_list.Items.Clear();
            foreach (string value in list)
            {
                history_list.Items.Add(value);
            }
        }

        private void bookmark_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = books.getBookmark(bookmark_list.SelectedItem.ToString());
            richTextBox1.Text = GetWebPage.getPage(temp);
            global_hist.addHistory(temp);
            generateHistory();
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
            generateBookMarks();
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookmarkForm bookForm = new BookmarkForm();
            if(bookForm.ShowDialog() == DialogResult.OK)
            {
                generateBookMarks();
            }
        }

        private void address_bar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (address_bar.Text != "")
                {
                    richTextBox1.Text = GetWebPage.getPage(address_bar.Text);
                    local_hist.addLocalHistory(address_bar.Text);
                    global_hist.addHistory(address_bar.Text);
                    generateHistory();
                }
            }
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global_hist.clearHistory();
            generateHistory();
        }

        private void history_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = GetWebPage.getPage(global_hist.getHistory(history_list.SelectedItem.ToString()));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           // global_hist.addHistory(local_hist., DateTime.Now.ToString("h:mm:ss tt"));
          //  generateHistory();
        }

        private void deleteBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            books.deleteBookmark(bookmark_list.SelectedItem.ToString());
            generateBookMarks();
        }
    }
}
