using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BrowserFrame : Form
    {

        public BrowserFrame()
        {
            InitializeComponent();
            homeTab();
         }

        //
        // Create inittial tab for home tab
        //
        public void homeTab()
        {
            tabGUI frm2 = new tabGUI();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            tabControl1.TabPages[0].Controls.Add(frm2);
        }

        //
        // create new tab method
        //
        private void newTab()
        {
            tabGUI frm3 = new tabGUI();
            TabPage tp = new TabPage();
            frm3.TopLevel = false;
            frm3.Dock = DockStyle.Fill;
            frm3.Show();
            tp.Controls.Add(frm3);
            tabControl1.TabPages.Add(tp);
            tp.Text = "New Page";
        }

        //
        // new tab double click event
        //
        private void tabControl1_DoubleClick(object sender, System.EventArgs e)
        {
            newTab();
        }

        //
        // newTab tool strip menu event
        //
        private void newTabToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabControl1_DoubleClick(sender, e);
        }

        //
        // Close tab menu event
        //
        private void closeTabToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }
    }
}
