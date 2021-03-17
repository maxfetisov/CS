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
    public partial class AddChangeUserForm : Form
    {
        private User u;
        private List<Gender> genders = StaticContext.context.Gender.ToList();
        public AddChangeUserForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;            
            fillGenderCB();
        }
        public AddChangeUserForm(User u)
        {
            InitializeComponent();
            addB.Visible = false;
            this.u = u;
            lastNameTB.Text = u.LastName;
            firstNameTB.Text = u.FirstName;
            middleNameTB.Text = u.MiddleName;
            emailTB.Text = u.Email;
            fillGenderCB();
            genderCB.SelectedIndex = genders.IndexOf(StaticContext.context.Gender.Find(u.GenderId));
        }

        private void fillGenderCB()
        {        
            foreach(Gender g in genders)
            {
                genderCB.Items.Add(g.Name);
            }
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.User.Remove(u);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            u.LastName = lastNameTB.Text;
            u.FirstName = firstNameTB.Text;
            u.MiddleName = middleNameTB.Text;
            u.GenderId = genders[genderCB.SelectedIndex].Id;
            u.Email = emailTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.User.Add(new User(StaticContext.context.User.ToList().Last().Id + 1, lastNameTB.Text, firstNameTB.Text, middleNameTB.Text, genders[genderCB.SelectedIndex].Id, emailTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
