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
    public partial class AddChangeTypeProductForm : Form
    {
        private TypeProduct tp;
        public AddChangeTypeProductForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }

        public AddChangeTypeProductForm(TypeProduct tp)
        {
            InitializeComponent();
            addB.Visible = false;
            this.tp = tp;
            nameTB.Text = tp.Name;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.TypeProduct.Remove(tp);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            tp.Name = nameTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.TypeProduct.Add(new TypeProduct(StaticContext.context.TypeProduct.ToList().Last().Id + 1, nameTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
