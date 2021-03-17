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
    public partial class AddChangeOrderStatusForm : Form
    {
        OrderStatus os;
        public AddChangeOrderStatusForm()
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
        }

        public AddChangeOrderStatusForm(OrderStatus os)
        {
            InitializeComponent();
            addB.Visible = false;
            this.os = os;
            nameTB.Text = os.Name;
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.OrderStatus.Remove(os);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            os.Name = nameTB.Text;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.OrderStatus.Add(new OrderStatus(StaticContext.context.OrderStatus.ToList().Last().Id + 1, nameTB.Text));
            StaticContext.context.SaveChanges();
            Close();
        }
    }
}
