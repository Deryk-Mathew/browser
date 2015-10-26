using System;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BookmarkForm : Form
    {
        public BookmarkForm()
        {
            InitializeComponent();
        }
        
        //
        // bookmark form submit event
        //
        private void bookmark_submit_btn_Click(object sender, EventArgs e)
        {
            tabGUI.books.editBookmark(url_textbox.Text.ToString(), title_textbox.Text.ToString());
            this.Close();
        }

        //
        // Edit bookmark procedure
        //
        internal void editBookmark(string value)
        {
            this.label1.Text = "Edit Bookmark";
            this.Text = "Edit Bookmark";
            this.url_textbox.Text = tabGUI.books.getBookmark(value);
            this.title_textbox.Text = value;
        }
    }
}
