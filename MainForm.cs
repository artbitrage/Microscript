using System.Windows.Forms;

namespace Microscript
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            openChildForm(new RESTForm());

            btn_REST.Enabled = false;
            btn_SOAP.Enabled = true;
            btn_WDSL.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void scanRESTServiceToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            openChildForm(new RESTForm());

            btn_REST.Enabled = false;
            btn_SOAP.Enabled = true;
            btn_WDSL.Enabled = true;
        }
    }
}