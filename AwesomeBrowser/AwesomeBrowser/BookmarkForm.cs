using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BookmarkForm : Form
    {
        public BookmarkForm()
        {
            InitializeComponent();
        }

        private void bookmark_submit_btn_Click(object sender, EventArgs e)
        {
            tabGUI.books.addBookmark(url_textbox.Text.ToString(), title_textbox.Text.ToString());
            this.Close();
        }

        internal void editBookmark(string value)
        {
            this.label1.Text = "Edit Bookmark";
            this.Text = "Edit Bookmark";
            this.url_textbox.Text = tabGUI.books.getBookmark(value);
            this.title_textbox.Text = value;
        }
    }
}
