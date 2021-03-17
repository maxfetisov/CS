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
    public partial class AddChangeBrandForm : Form
    {
        private Brand b;
        public AddChangeBrandForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }
        public AddChangeBrandForm(Brand b)
        {
            InitializeComponent();
            addB.Visible = false;
            this.b = b;
            nameTB.Text = b.Name;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.Brand.Remove(b);
                StaticContext.context.SaveChanges();
                Close();
            }         
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            b.Name = nameTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Brand.Add(new Brand(StaticContext.context.Brand.ToList().Last().Id + 1, nameTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
