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
    public partial class AddChangeRoleConsumerForm : Form
    {
        private RoleConsumer rc;
        public AddChangeRoleConsumerForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }
        public AddChangeRoleConsumerForm(RoleConsumer rc)
        {
            InitializeComponent();
            addB.Visible = false;
            this.rc = rc;
            nameTB.Text = rc.Name;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.RoleConsumers.Remove(rc);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            rc.Name = nameTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.RoleConsumers.Add(new RoleConsumer(StaticContext.context.RoleConsumers.ToList().Last().Id + 1, nameTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
