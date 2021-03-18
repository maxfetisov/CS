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
    public partial class Registration : Form
    {
        List<RoleConsumer> roleConsumers = StaticContext.context.RoleConsumers.ToList();
        List<Gender> genders = StaticContext.context.Gender.ToList();
        public Registration()
        {
            InitializeComponent();
            fillRoleConsumerCB();
            fillGenderCB();
        }
        private void fillRoleConsumerCB()
        {
            foreach (RoleConsumer rc in roleConsumers)
            {
                roleConsumerCB.Items.Add(rc.Name);
            }
        }
        private void fillGenderCB()
        {
            foreach (Gender g in genders)
            {
               genderCB.Items.Add(g.Name);
            }
        }
        private void registrateB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Consumer.Add(new Consumer(
                emailTB.Text, 
                passwordTB.Text, 
                roleConsumers[roleConsumerCB.SelectedIndex].Id, 
                lastNameTB.Text, 
                ferstNameTB.Text, 
                middleNameTB.Text, 
                genders[genderCB.SelectedIndex].Id
                ));
            CSDBContext context = new CSDBContext();
            string sql = $"CREATE LOGIN {emailTB.Text} WITH PASSWORD = '{passwordTB.Text}' CREATE USER {emailTB.Text} FOR LOGIN {emailTB.Text}";
            context.Database.ExecuteSqlCommand(sql);
            sql = $"ALTER ROLE {roleConsumerCB.SelectedItem} ADD MEMBER {emailTB.Text}";
            context.Database.ExecuteSqlCommand(sql);
            context.SaveChanges();
            StaticContext.context.SaveChanges();
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }
    }
}
