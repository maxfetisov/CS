using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationSalon
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            modeCB.SelectedIndex = 0;
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source =DESKTOP-PNOODSG\\SQLEXPRESS; Initial Catalog = CommunicationSalon; Integrated Security = False; User ID={loginTB.Text};Password={passwordTB.Text}";
            EnterInMainFrom(connectionString);
        }
        private void EnterInMainFrom(string connectionString)
        {
            StaticContext sc = new StaticContext(connectionString);
            MainForm mainForm;
            if (modeCB.SelectedIndex == 0)
            {
                mainForm = new MainForm(false);
            }
            else
            {
                mainForm = new MainForm(true);
            }
            mainForm.Show();
            Close();
        }
        private void startDataB_Click(object sender, EventArgs e)
        {
            StartData sd = new StartData();
            sd.fill();
            sd.createUser();
        }

        private void windowsAuthB_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source =DESKTOP-PNOODSG\\SQLEXPRESS; Initial Catalog = CommunicationSalon; Integrated Security = True";
            EnterInMainFrom(connectionString);
        }
    }
}
