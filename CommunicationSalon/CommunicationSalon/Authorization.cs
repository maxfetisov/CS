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
        }

        private void EnterB_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source =DESKTOP-PNOODSG\\SQLEXPRESS; Initial Catalog = CommunicationSalon; Integrated Security = False; User ID={loginTB.Text};Password={passwordTB.Text}";
            EnterInMainFrom(connectionString);
        }
        private void EnterInMainFrom(string connectionString)
        {
            StaticContext sc = new StaticContext(connectionString);
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source =DESKTOP-PNOODSG\\SQLEXPRESS; Initial Catalog = CommunicationSalon; Integrated Security = True";
            EnterInMainFrom(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartData s = new StartData();
            s.createUser();
        }
    }
}
