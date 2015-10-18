using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BrowserFrame : Form
    {


        public BrowserFrame()
        {
            InitializeComponent();
            newTab();
            //listBox1.Items.Add(books.addBookmark());
        }

        public void newTab()
        {
            tabGUI frm2 = new tabGUI();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            tabControl1.TabPages[0].Controls.Add(frm2);

        }

        private void tabPage2_Click(object sender, System.EventArgs e)
        {
            tabGUI tpage = new tabGUI();
            tpage.TopLevel = false;
            tpage.Dock = DockStyle.Fill;
            tpage.Show();
            //tabControl1.TabPages[tabControl1.TabCount +1].Controls.Add(tpage);
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, tpage);
            //tpage.Controls.Add(tpage);
            //tabControl1.SelectTab(tpage);
        }
    }
}
