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
    public partial class AddChangeOrderForm : Form
    {
        private Order o;
        private List<ProductInOrder> po;
        private List<User> users = StaticContext.context.User.ToList();
        private List<OrderStatus> orderStatuss = StaticContext.context.OrderStatus.ToList();
        public AddChangeOrderForm(Order o, List<ProductInOrder> po)
        {
            InitializeComponent();
            changeB.Visible = deleteB.Visible = false;
            this.o = o;
            this.po = po;
            fillUserCB();
            fillOrderStatusCB();
        }
        public AddChangeOrderForm(Order o)
        {
            InitializeComponent();
            addB.Visible = false;
            this.o = o;
            fillUserCB();
            fillOrderStatusCB();
            startDateDTP.Value = o.StartDate;
            finishDateDTP.Value = o.FinishDate;
            priceNUP.Value = o.Price;
            userCB.SelectedIndex = users.IndexOf(StaticContext.context.User.Find(o.UserId));
            statusCB.SelectedIndex = orderStatuss.IndexOf(StaticContext.context.OrderStatus.Find(o.OrderStatusId));
        }
        private void fillUserCB()
        {
            foreach (User u in users)
            {
                userCB.Items.Add(u.LastName + " " + u.FirstName + " " + u.MiddleName + "(" + u.Email + ")");
            }
        }
        private void fillOrderStatusCB()
        {
            foreach (OrderStatus os in orderStatuss)
            {
                statusCB.Items.Add(os.Name);
            }
        }
        private void deleteB_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
            {
                StaticContext.context.Order.Remove(o);
                StaticContext.context.SaveChanges();
                Close();
            }
        }

        private void changeB_Click(object sender, EventArgs e)
        {
            o.StartDate = startDateDTP.Value;
            o.FinishDate = finishDateDTP.Value;
            o.Price = priceNUP.Value;
            o.UserId = users[userCB.SelectedIndex].Id;
            o.OrderStatusId = orderStatuss[statusCB.SelectedIndex].Id;
            StaticContext.context.SaveChanges();
            Close();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            StaticContext.context.Order.Add(new Order(
                StaticContext.context.Order.ToList().Last().Id + 1, 
                startDateDTP.Value, 
                finishDateDTP.Value, 
                priceNUP.Value, 
                users[userCB.SelectedIndex].Id, 
                orderStatuss[statusCB.SelectedIndex].Id
                ));
            for (int i = 0; i < po.Count; i++)
            {
                po[i].Id = StaticContext.context.ProductInOrder.ToList().Last().Id + 1;
                StaticContext.context.ProductInOrder.Add(po[i]);
            }
            StaticContext.context.SaveChanges();
            MainForm.CreateOrder();
            Close();
        }
    }
}
