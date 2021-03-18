using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    class StartData
    {
        public StartData()
        {

        }
        public void createRoles()
        {
            try 
            {
                CSDBContext context = new CSDBContext();
                string sql = $"CREATE ROLE operator";
                context.Database.ExecuteSqlCommand(sql);
                sql = "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Brand TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Consumer TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Gender TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [Order] TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON OrderStatus TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON PhoneNumber TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Product TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON ProductInOrder TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON RoleConsumer TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Tariff TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON TypeProduct TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [User] TO operator " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [__MigrationHistory] TO operator";
                context.Database.ExecuteSqlCommand(sql);
                sql = $"CREATE ROLE [admin]";
                context.Database.ExecuteSqlCommand(sql);
                sql = "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Brand TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Consumer TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Gender TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [Order] TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON OrderStatus TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON PhoneNumber TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Product TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON ProductInOrder TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON RoleConsumer TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON Tariff TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON TypeProduct TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [User] TO [admin] " +
                    "GRANT SELECT, DELETE, UPDATE, INSERT " +
                    "ON [__MigrationHistory] TO [admin] " +
                    "GRANT CREATE TABLE TO [admin]";
                context.Database.ExecuteSqlCommand(sql);
                context.SaveChanges();
            }
            catch (Exception) { }
        }
        public void createUser()
        {
            createRoles();
            try
            {
                string userLogin = "Masima";
                string userPassword = "123";
                string sql = $"CREATE LOGIN {userLogin} WITH PASSWORD = '{userPassword}' CREATE USER Masima FOR LOGIN {userLogin}";
                CSDBContext context = new CSDBContext();
                context.Database.ExecuteSqlCommand(sql);
                
                sql = "ALTER ROLE [admin]  " +
                    "ADD MEMBER Masima";
                context.Database.ExecuteSqlCommand(sql);
                context.Consumer.Add(new Consumer(userLogin, userPassword, 2, "Фетисов", "Максим", "Андреевия", 3));
                context.SaveChanges();
            }
            catch (Exception) { }
        }
        public void fill()
        {
            try
            {
                CSDBContext context = new CSDBContext();
                Brand b1 = new Brand(1, "Долбич Инк");
                context.Brand.Add(b1);

                Brand b2 = new Brand(2, "Van&Billy");
                context.Brand.Add(b2);

                Brand b3 = new Brand(3, "Samsum");
                context.Brand.Add(b3);

                Brand b4 = new Brand("Samsum");
                context.Brand.Add(b4);

                Gender g1 = new Gender(1, "Мужской");
                context.Gender.Add(g1);

                Gender g2 = new Gender(2, "Женский");
                context.Gender.Add(g2);

                Gender g3 = new Gender(3, "Монке");
                context.Gender.Add(g3);

                TypeProduct tp1 = new TypeProduct(1, "Телефон");
                context.TypeProduct.Add(tp1);

                TypeProduct tp2 = new TypeProduct(2, "Банан");
                context.TypeProduct.Add(tp2);

                TypeProduct tp3 = new TypeProduct(3, "Чехол");
                context.TypeProduct.Add(tp3);

                OrderStatus os1 = new OrderStatus(1, "Ожидание подтверждения");
                context.OrderStatus.Add(os1);

                OrderStatus os2 = new OrderStatus(2, "В процессе");
                context.OrderStatus.Add(os2);

                OrderStatus os3 = new OrderStatus(3, "Готов");
                context.OrderStatus.Add(os3);

                RoleConsumer r1 = new RoleConsumer(1, "operator");
                context.RoleConsumers.Add(r1);

                RoleConsumer r2 = new RoleConsumer(2, "admin");
                context.RoleConsumers.Add(r2);

                User u1 = new User(1, "Чортов", "Чорт", "Чортович", 1, "арпап");
                context.User.Add(u1);

                User u2 = new User(2, "1", "1", "1", 1, "1");
                context.User.Add(u2);

                User u3 = new User(3, "Чор4в", "Чорт", "Чортович", 3, "арпап");
                context.User.Add(u3);

                Order o1 = new Order(1, new DateTime(2000, 2, 1), new DateTime(2000, 2, 2), 12, 1, 1);
                context.Order.Add(o1);

                Order o2 = new Order(2, new DateTime(2200, 3, 1), new DateTime(2000, 2, 1), 2, 2, 3);
                context.Order.Add(o2);

                Order o3 = new Order(3, new DateTime(2100, 2, 2), new DateTime(2000, 2, 2), 12, 3, 2);
                context.Order.Add(o3);

                Tariff t1 = new Tariff(1, "Классика", "Херота", 13, 1, 3);
                context.Tariff.Add(t1);

                Tariff t2 = new Tariff(2, "Чорт", "Херота", 13, 1, 3);
                context.Tariff.Add(t2);

                Tariff t3 = new Tariff(3, "КДка", "Херота", 13, 1, 3);
                context.Tariff.Add(t3);

                PhoneNumber pn1 = new PhoneNumber("2143423", 1, 2, 34);
                context.PhoneNumber.Add(pn1);

                PhoneNumber pn2 = new PhoneNumber("214423", 2, 2, 34);
                context.PhoneNumber.Add(pn2);

                PhoneNumber pn3 = new PhoneNumber("214313", 3, 1, 34);
                context.PhoneNumber.Add(pn3);

                Product p1 = new Product("hfjsr", 1, "Note", "20", 2, 80000, 2);
                context.Product.Add(p1);

                Product p2 = new Product("h4fgr", 2, "S", "20", 1, 21313000, 2);
                context.Product.Add(p2);

                Product p3 = new Product("h3r", 3, "S", "21", 2, 22000000, 3);
                context.Product.Add(p3);

                ProductInOrder pin1 = new ProductInOrder(1, 1, "h4fgr", 2);
                context.ProductInOrder.Add(pin1);

                ProductInOrder pin2 = new ProductInOrder(2, 2, "h3r", 2);
                context.ProductInOrder.Add(pin2);

                ProductInOrder pin3 = new ProductInOrder(3, 3, "h4fgr", 2);
                context.ProductInOrder.Add(pin3);

                context.SaveChanges();
            }
            catch(Exception) { }
}
    }
}
