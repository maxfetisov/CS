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
    public partial class AddChangeGenderForm : Form
    {
        Gender g;
        public AddChangeGenderForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }
        public AddChangeGenderForm(Gender g)
        {
            InitializeComponent();
            addB.Visible = false;
            this.g = g;
            nameTB.Text = g.Name;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.Gender.Remove(g);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            g.Name = nameTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Gender.Add(new Gender(StaticContext.context.Gender.ToList().Last().Id + 1, nameTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
