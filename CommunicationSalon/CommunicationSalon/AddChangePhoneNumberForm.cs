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
    public partial class AddChangePhoneNumberForm : Form
    {
        private PhoneNumber pn;
        private List<Tariff> tariffs = StaticContext.context.Tariff.ToList();
        private List<User> users = StaticContext.context.User.ToList();
        public AddChangePhoneNumberForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
            numberTB.ReadOnly = false;
            fillTariffCB();
            fillUserCB();
        }
        public AddChangePhoneNumberForm(PhoneNumber pn)
        {
            InitializeComponent();
            addB.Visible = false;
            numberTB.ReadOnly = true;
            this.pn = pn;
            fillTariffCB();
            fillUserCB();
            numberTB.Text = pn.Number;
            tariffCB.SelectedIndex = tariffs.IndexOf(StaticContext.context.Tariff.Find(pn.TariffId));
            userCB.SelectedIndex = users.IndexOf(StaticContext.context.User.Find(pn.UserId));
            balanceNUD.Value = pn.Balance;
        }
        private void fillTariffCB()
        {
            foreach (Tariff t in tariffs)
            {
                tariffCB.Items.Add(t.Name + "(" + t.Minutes + " минут, " + t.Internet + " ГБ) - " + t.Price);
            }
        }
        private void fillUserCB()
        {
            foreach (User u in users)
            {
                userCB.Items.Add(u.LastName + " " + u.FirstName + " " + u.MiddleName + "(" + u.Email + ")");
            }
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.PhoneNumber.Remove(pn);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.PhoneNumber.Add(new PhoneNumber(numberTB.Text, tariffs[tariffCB.SelectedIndex].Id, users[userCB.SelectedIndex].Id, balanceNUD.Value));
            StaticContext.context.SaveChanges();
            Close();
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            pn.TariffId = tariffs[tariffCB.SelectedIndex].Id;
            pn.UserId = users[userCB.SelectedIndex].Id;
            pn.Balance = balanceNUD.Value;
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
