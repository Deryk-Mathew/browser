using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BrowserFrame : Form
    {


        public BrowserFrame()
        {
            InitializeComponent();
            populateTab();
            //listBox1.Items.Add(books.addBookmark());
        }

        public void populateTab()
        {
            tabGUI frm2 = new tabGUI();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            tabControl1.TabPages[0].Controls.Add(frm2);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void tabControl1_DoubleClick(object sender, System.EventArgs e)
        {
            tabGUI frm3 = new tabGUI();
            TabPage tp = new TabPage();

            frm3.TopLevel = false;
            frm3.Dock = DockStyle.Fill;
            frm3.Show();
            tp.Controls.Add(frm3);
            tabControl1.TabPages.Add(tp);
        }
    }
}
