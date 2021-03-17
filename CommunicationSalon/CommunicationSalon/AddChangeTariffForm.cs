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
    public partial class AddChangeTariffForm : Form
    {
        Tariff t;
        public AddChangeTariffForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }
        public AddChangeTariffForm(Tariff t)
        {
            InitializeComponent();
            addB.Visible = false;
            this.t = t;
            nameTB.Text = t.Name;
            descriptionRTB.Text = t.Description;
            priceNUD.Value = t.Price;
            minutesNUD.Value = t.Minutes;
            internetNUD.Value = t.Internet;
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.Tariff.Remove(t);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            t.Name = nameTB.Text;
            t.Description = descriptionRTB.Text;
            t.Price = priceNUD.Value;
            t.Minutes = (int)minutesNUD.Value;
            t.Internet = internetNUD.Value;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Tariff.Add(new Tariff(StaticContext.context.Tariff.ToList().Last().Id + 1, nameTB.Text, descriptionRTB.Text, priceNUD.Value, (int)minutesNUD.Value, internetNUD.Value));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
