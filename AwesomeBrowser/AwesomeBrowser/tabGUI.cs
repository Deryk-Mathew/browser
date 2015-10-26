using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class tabGUI : Form
    {
        LocalHistory local_hist = new LocalHistory();
        GlobalHistory global_hist = new GlobalHistory();
        public static Bookmarks books = new Bookmarks();

        // Constructor
        public tabGUI()
        {
            InitializeComponent();
            myWorker.DoWork += new DoWorkEventHandler(myWorker_DoWork);
            myWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(myWorker_RunWorkerCompleted);
            object[] arrObjects = new object[] { Properties.Settings.Default.homepage };
            myWorker.RunWorkerAsync(arrObjects);
            generateBookMarks();
            generateHistory();
        }

        // 
        // Go button click event
        //
        private void go_btn_Click_1(object sender, EventArgs e)
        {
             // if address bar is not empty
            if (address_bar.Text != "")
            {
                object[] arrObjects = new object[] { address_bar.Text };
                myWorker.RunWorkerAsync(arrObjects); 
            }
        }

        //
        // address bar event when enter pressed
        //
        private void address_bar_KeyUp(object sender, KeyEventArgs e)
        {
            // if address bar is not empty
            if (address_bar.Text != "")
            {
                object[] arrObjects = new object[] { address_bar.Text };
                myWorker.RunWorkerAsync(arrObjects); 
            }
        
        }

        //
        // Home button click event
        //
        private void home_btn_Click(object sender, EventArgs e)
        {
            object[] arrObjects = new object[] { Properties.Settings.Default.homepage };
            myWorker.RunWorkerAsync(arrObjects);
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
        // Edit homepage tool menu event
        //
        private void editHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomepageDialog home = new HomepageDialog();
            home.urlEditName();
            home.Show();
        }

        //
        // Back Button key event
        //
        private void back_btn_Click(object sender, EventArgs e)
        {
            browserText.Text = local_hist.back();
        }

        //
        // Forward Button key event
        //
        private void forward_btn_Click(object sender, EventArgs e)
        {
            browserText.Text = local_hist.forward();
        }

        //
        // Populate the book mark tab in browser
        //
        public void generateBookMarks()
        {
            System.Collections.Generic.List<string> list = books.displayBookmarks();
            bookmark_list.Items.Clear();
            foreach (string value in list.OrderBy(x => x))
            {
                bookmark_list.Items.Add(value);
            }
        }

        //
        // Populate the history tab in browser
        //
        public void generateHistory()
        {
            System.Collections.Generic.HashSet<string> list = global_hist.displayHistory();
            history_list.Items.Clear();
            foreach (string value in list)
            {
                history_list.Items.Add(value);
            }
        }

        //
        // Load bookmarked web page event
        //
        private void bookmark_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string temp = books.getBookmark(bookmark_list.SelectedItem.ToString());
                global_hist.addHistory(temp);
                object[] arrObjects = new object[] { temp };
                myWorker.RunWorkerAsync(arrObjects);
                generateHistory();
            }
            catch (Exception) { }
        }

        //
        // Expand/Colapese history/bookmark tabs
        //
        private void tabControl1_DoubleClick(object sender, EventArgs e)
        {
            if (tabControl1.Size.Width > 20)
                this.tabControl1.Size = new System.Drawing.Size(20, 566);
            else
                this.tabControl1.Size = new System.Drawing.Size(200, 566);
        }

        //
        // Edit bookmark event from context menu
        //
        private void editBookmarkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                BookmarkForm bookForm = new BookmarkForm();
                bookForm.editBookmark(bookmark_list.SelectedItem.ToString());
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    bookForm.Show();
                    generateBookMarks();
                }
            }
            catch (Exception) { }
        }

        //
        // Add bookmark event from context menu
        // 
        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BookmarkForm bookForm = new BookmarkForm();
                if (bookForm.ShowDialog() == DialogResult.OK)
                {
                    generateBookMarks();
                }
            }
            catch (Exception) { }
        }

        //
        // delete selected bookmark event from context menu
        //
        private void deleteBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                books.deleteBookmark(bookmark_list.SelectedItem.ToString());
                generateBookMarks();
            }
            catch (Exception) { }
        }

        //
        // Clear history context menu event
        //
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global_hist.clearHistory();
            generateHistory();
        }

        //
        // load selected history page event
        //
        private void history_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object[] arrObjects = new object[] { global_hist.getHistory(history_list.SelectedItem.ToString()) };
                myWorker.RunWorkerAsync(arrObjects);
                generateHistory();
            }
            catch (Exception) { }
        }

        //
        // Getwebpage background worker
        //
        private void myWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker sendingWorker = (BackgroundWorker)sender;
            object[] arrObjects = (object[])e.Argument;

            // add http to all url addresses
            string urlAdd = "http://" + (string)arrObjects[0] + "/";

            // used to build entire input
            StringBuilder sb = new StringBuilder();

            byte[] buf = new byte[8192];

            try
            {
                try
                {
                    // prepare the web page we will be asking for
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAdd);

                    // execute the request
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream resStream = response.GetResponseStream();

                    string tempString = null;
                    int count = 0;

                    do
                    {
                        count = resStream.Read(buf, 0, buf.Length);

                        if (count != 0)
                        {
                            tempString = Encoding.ASCII.GetString(buf, 0, count);
                            sb.Append(tempString);
                        }
                    }
                    while (count > 0); 

                    e.Result = sb.ToString();
                }
                catch (UriFormatException ex) { e.Result = ex.Message; }

            }
            catch (WebException ex) { e.Result = ex.Message; }
        }
        
        //
        // Get webpage background worker complete
        //
        protected void myWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                string result = (string)e.Result;
                browserText.Text = result;
                local_hist.addLocalHistory(result);
                global_hist.addHistory(address_bar.Text);
                history_list.Refresh();
            }
        }
   }
}
