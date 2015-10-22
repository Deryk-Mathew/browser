using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class BrowserFrame : Form
    {
            

        public BrowserFrame()
        {
            InitializeComponent();
            populateTab();
        }

        public void populateTab()
        {
            tabGUI frm2 = new tabGUI();
            frm2.TopLevel = false;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
            tabControl1.TabPages[0].Controls.Add(frm2);
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
            tp.Text = "New Page";
        }

        private void newTabToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabControl1_DoubleClick(sender, e);
        }

        private void closeTabToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
        }
    }
}
