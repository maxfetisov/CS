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
                string sql = $"DROP ROLE {rc.Name}";
                StaticContext.context.Database.ExecuteSqlCommand(sql);
                StaticContext.context.RoleConsumers.Remove(rc);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            string sql = $"DROP ROLE {rc.Name}";
            StaticContext.context.Database.ExecuteSqlCommand(sql);
            rc.Name = nameTB.Text;
            sql = $"CREATE ROLE {rc.Name}";
            StaticContext.context.Database.ExecuteSqlCommand(sql);
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.RoleConsumers.Add(new RoleConsumer(StaticContext.context.RoleConsumers.ToList().Last().Id + 1, nameTB.Text));
            string sql = $"CREATE ROLE {nameTB.Text}";
            StaticContext.context.Database.ExecuteSqlCommand(sql);
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
