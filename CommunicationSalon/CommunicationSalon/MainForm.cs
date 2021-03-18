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
    public partial class MainForm : Form
    {
        private static Order order;
        private static List<ProductInOrder> productInOrders;
        public MainForm(bool mode)
        {
            InitializeComponent();
            StaticContext.context.Brand.Find(1);
            StaticContext.context.SaveChanges();           
            if (mode)
            {
                BasketB.Visible = clientDGV.Visible =false;
                tableChoiceCB.SelectedIndex = 0;                
            }
            else
            {
                addB.Visible = deleteB.Visible = registrateB.Visible = tableChoiceCB.Visible = infoDGV.Visible= false;
                productInOrders = new List<ProductInOrder>();
                FillClientDGV();
                CreateOrder();
            }
        }
        public static void CreateOrder()
        {
            order = new Order(StaticContext.context.Order.ToList().Last().Id + 1);
            productInOrders.Clear();
        }
        public void FillClientDGV()
        {
            clientDGV.DataSource = (from p in StaticContext.context.Product
                                    join b in StaticContext.context.Brand on p.BrandId equals b.Id
                                    join tp in StaticContext.context.TypeProduct on p.TypeProductId equals tp.Id
                                    select new { p.Article, p.Name, p.Model, p.Price, p.QuantityInStock, brandName = b.Name, TypeProductName = tp.Name }).ToList();
        }
        public void FillDGV()
        {
            switch (tableChoiceCB.SelectedIndex)
            {
                case 0:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Brand.ToList();
                        break;
                    }
                case 1:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.Consumer.ToList();
                        break;
                    }
                case 2:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Gender.ToList();
                        break;
                    }
                case 3:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.Order.ToList();
                        break;
                    }
                case 4:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.OrderStatus.ToList();
                        break;
                    }
                case 5:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.PhoneNumber.ToList();
                        break;
                    }
                case 6:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Product.ToList();
                        break;
                    }
                case 7:
                    {
                        addB.Visible = false;
                        infoDGV.DataSource = StaticContext.context.ProductInOrder.ToList();
                        break;
                    }
                case 8:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.RoleConsumers.ToList();
                        break;
                    }
                case 9:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.Tariff.ToList();
                        break;
                    }
                case 10:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.TypeProduct.ToList();
                        break;
                    }
                case 11:
                    {
                        addB.Visible = true;
                        infoDGV.DataSource = StaticContext.context.User.ToList();
                        break;
                    }
            }
        }

        private void tableChoiceCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDGV();
        }
        private void registrateB_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            Close();
        }

        private void changeUserB_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Close();
        }

        private void infoDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            change(e);
        }
        private void change(DataGridViewCellEventArgs e)
        {
            switch (tableChoiceCB.SelectedItem.ToString())
            {
                case "Brand":
                    {
                        AddChangeBrandForm addChangeBrandForm = new AddChangeBrandForm(StaticContext.context.Brand.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeBrandForm.Show();
                        break;
                    }
                case "Consumer":
                    {

                        break;
                    }
                case "Gender":
                    {
                        AddChangeGenderForm addChangeGenderForm = new AddChangeGenderForm(StaticContext.context.Gender.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeGenderForm.Show();
                        break;
                    }
                case "Order":
                    {
                        AddChangeOrderForm addChangeOrderForm = new AddChangeOrderForm(StaticContext.context.Order.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeOrderForm.Show();
                        break;
                    }
                case "OrderStatus":
                    {
                        AddChangeOrderStatusForm addChangeOrderStatusForm = new AddChangeOrderStatusForm(StaticContext.context.OrderStatus.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeOrderStatusForm.Show();
                        break;
                    }
                case "PhoneNumber":
                    {
                        AddChangePhoneNumberForm addChangePhoneNumberForm = new AddChangePhoneNumberForm(StaticContext.context.PhoneNumber.Find(infoDGV.Rows[e.RowIndex].Cells[0].Value));
                        addChangePhoneNumberForm.Show();
                        break;
                    }
                case "Product":
                    {
                        AddChangeProductForm addChangeProductForm = new AddChangeProductForm(StaticContext.context.Product.Find(infoDGV.Rows[e.RowIndex].Cells[0].Value));
                        addChangeProductForm.Show();
                        break;
                    }
                case "ProductInOrder":
                    {
                        break;
                    }
                case "RoleConsumer":
                    {
                        AddChangeRoleConsumerForm addChangeRoleConsumerForm = new AddChangeRoleConsumerForm(StaticContext.context.RoleConsumers.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeRoleConsumerForm.Show();
                        break;
                    }
                case "Tariff":
                    {
                        AddChangeTariffForm addChangeTariffForm = new AddChangeTariffForm(StaticContext.context.Tariff.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeTariffForm.Show();
                        break;
                    }
                case "TypeProduct":
                    {
                        AddChangeTypeProductForm addChangeTypeProductForm = new AddChangeTypeProductForm(StaticContext.context.TypeProduct.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeTypeProductForm.Show();
                        break;
                    }
                case "User":
                    {
                        AddChangeUserForm addChangeUserForm = new AddChangeUserForm(StaticContext.context.User.Find(Convert.ToInt32(infoDGV.Rows[e.RowIndex].Cells[0].Value)));
                        addChangeUserForm.Show();
                        break;
                    }
            }
        }
        private void add()
        {
            switch (tableChoiceCB.SelectedItem.ToString())
            {
                case "Brand":
                    {
                        AddChangeBrandForm addChangeBrandForm = new AddChangeBrandForm();
                        addChangeBrandForm.Show();
                        break;
                    }
                case "Consumer":
                     {
                        
                        break;
                    }
                case "Gender":
                         {
                        AddChangeGenderForm addChangeGenderForm = new AddChangeGenderForm();
                        addChangeGenderForm.Show();
                        break;
                    }
                case "Order":
                         {
                        break;
                    }
                case "OrderStatus":
                    {
                        AddChangeOrderStatusForm addChangeOrderStatusForm = new AddChangeOrderStatusForm();
                        addChangeOrderStatusForm.Show();
                        break;
                    }
                case "PhoneNumber":
                    {
                        AddChangePhoneNumberForm addChangePhoneNumberForm = new AddChangePhoneNumberForm();
                        addChangePhoneNumberForm.Show();
                        break;
                    }
                case "Product":
                    {
                        AddChangeProductForm addChangeProductForm = new AddChangeProductForm();
                        addChangeProductForm.Show();
                        break;
                    }
                case "ProductInOrder":
                    {
                        break;
                    }
                case "RoleConsumer":
                    {
                        AddChangeRoleConsumerForm addChangeRoleConsumerForm = new AddChangeRoleConsumerForm();
                        addChangeRoleConsumerForm.Show();
                        break;
                    }
                case "Tariff":
                    {
                        AddChangeTariffForm addChangeTariffForm = new AddChangeTariffForm();
                        addChangeTariffForm.Show();
                        break;
                    }
                case "TypeProduct":
                    {
                        AddChangeTypeProductForm addChangeTypeProductForm = new AddChangeTypeProductForm();
                        addChangeTypeProductForm.Show();
                        break;
                    }
                case "User":
                    {
                        AddChangeUserForm addChangeUserForm = new AddChangeUserForm();
                        addChangeUserForm.Show();
                        break;
                    }
            }
        }

        private void addB_Click(object sender, EventArgs e)
        {
            add();
        }

        private void BasketB_Click(object sender, EventArgs e)
        {
            BasketForm basketForm = new BasketForm(productInOrders, order);
            basketForm.Show();
        }

        private void clientDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openProductForm(e);
        }
        private void openProductForm(DataGridViewCellEventArgs e)
        {
            AddChangeProductForm addChangeProductForm = new AddChangeProductForm(StaticContext.context.Product.Find(clientDGV.Rows[e.RowIndex].Cells[0].Value), ref order, ref productInOrders);
            addChangeProductForm.Show();
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            switch (tableChoiceCB.SelectedItem.ToString())
            {
                case "Brand":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Brand.Remove(StaticContext.context.Brand.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "Consumer":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Consumer.Remove(StaticContext.context.Consumer.Find(infoDGV.SelectedRows[0].Cells[0].Value));
                            string sql = $"DROP USER {StaticContext.context.Consumer.Find(infoDGV.SelectedRows[0].Cells[0].Value).Email}";
                            StaticContext.context.Database.ExecuteSqlCommand(sql);
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "Gender":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Gender.Remove(StaticContext.context.Gender.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "Order":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Order.Remove(StaticContext.context.Order.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "OrderStatus":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.OrderStatus.Remove(StaticContext.context.OrderStatus.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "PhoneNumber":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.PhoneNumber.Remove(StaticContext.context.PhoneNumber.Find(infoDGV.SelectedRows[0].Cells[0].Value));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "Product":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Product.Remove(StaticContext.context.Product.Find(infoDGV.SelectedRows[0].Cells[0].Value));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "ProductInOrder":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.ProductInOrder.Remove(StaticContext.context.ProductInOrder.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "RoleConsumer":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.RoleConsumers.Remove(StaticContext.context.RoleConsumers.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            string sql = $"DROP ROLE {StaticContext.context.RoleConsumers.Find(infoDGV.SelectedRows[0].Cells[0].Value).Name}";
                            StaticContext.context.Database.ExecuteSqlCommand(sql);
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "Tariff":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.Tariff.Remove(StaticContext.context.Tariff.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "TypeProduct":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.TypeProduct.Remove(StaticContext.context.TypeProduct.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
                case "User":
                    {
                        if (DialogResult.Yes == MessageBox.Show("Уверен?", "Предупреждение", MessageBoxButtons.YesNo))
                        {
                            StaticContext.context.User.Remove(StaticContext.context.User.Find(Convert.ToInt32(infoDGV.SelectedRows[0].Cells[0].Value)));
                            StaticContext.context.SaveChanges();
                        }
                        break;
                    }
            }
        }
    }
}
