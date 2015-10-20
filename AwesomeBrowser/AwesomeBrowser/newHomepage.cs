using System;
using System.Windows.Forms;

namespace AwesomeBrowser
{
    public partial class HomepageDialog : Form
    {
        public HomepageDialog()
        {
            InitializeComponent();
        }

        private void submit_new_homepage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.homepage = homepage_address.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        public void urlEditName()
        {
            this.label1.Text = "Edit Homepage";
            this.Text = "Edit Homepage";
            this.homepage_address.Text = Properties.Settings.Default.homepage;
        }
    }
}
