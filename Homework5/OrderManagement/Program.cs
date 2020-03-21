using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Order Management System!");
            OrderService service = new OrderService();
            while(true)
            {
                try
                {
                    String orderID;
                    String customerName;
                    String customerAddress;
                    String action = GetInput("1.add an order\t2.delete an order\t3.modify an order\t4.select the orders\nPlease select an action: ");
                    switch (action)
                    {
                        case "1":
                            customerName = GetInput("Customer name:");
                            customerAddress = GetInput("Customer address:");
                            Console.WriteLine("Add an order successful!");
                            Console.WriteLine("Your order ID is:" + service.AddOrder(new Order(0,
                                new Customer(customerName, customerAddress), DateTime.Now, new HashSet<OrderItem>())));
                            break;
                        case "2":
                            orderID = GetInput("Order ID:");
                            service.DeleteOrder(Int32.Parse(orderID));
                            Console.WriteLine("Delete the order successful!");
                            break;
                        case "3":
                            orderID = GetInput("Order ID:");
                            String operation = GetInput(
                                "customer name\tcustomer address\torder time\tadd item\n" +
                                "delete item\tquantity\nPlease select an operation:"
                                );
                            String modifyData = "";
                            if(operation != "add item")
                            {
                                modifyData = GetInput("The data After modify:");
                            }
                            object data = null;
                            int goodsID = 0;
                            switch (operation)
                            {
                                case "customer name":
                                case "customer address":
                                    data = modifyData;
                                    break;
                                case "order time":
                                    data = DateTime.Parse(modifyData);
                                    break;
                                case "add item":
                                    goodsID = Int32.Parse(GetInput("Goods ID:"));
                                    int quantity = Int32.Parse(GetInput("Quantity:"));
                                    data = new OrderItem(new Goods(goodsID), quantity);
                                    break;
                                case "delete item":
                                    goodsID = Int32.Parse(GetInput("Quantity:"));
                                    break;
                                case "quantity":
                                    goodsID = Int32.Parse(GetInput("Quantity:"));
                                    data = Int32.Parse(modifyData);
                                    break;
                                default:
                                    throw new ArgumentException("Invalid argument!");
                            }
                            service.AlterOrder(Int32.Parse(orderID), operation, data, goodsID);
                            Console.WriteLine("Modify successful!");
                            Console.Write(service.FindOrder(int.Parse(orderID), null, null)[0]);
                            break;
                        case "4":
                            Console.WriteLine("Please enter search conditions:");
                            orderID = GetInput("Order ID:");
                            String goodsName = GetInput("Goods name:");
                            customerName = GetInput("Customer name:");
                            int orderId = orderID == "" ? int.MinValue : int.Parse(orderID);
                            goodsName = goodsName == "" ? null : goodsName;
                            customerName = customerName == "" ? null : customerName;
                            List<Order> results = service.FindOrder(orderId, goodsName, customerName);
                            Console.WriteLine("Result:");
                            foreach(Order order in results)
                            {
                                Console.WriteLine(order);
                            }
                            break;
                        default:
                            throw new ArgumentException("No such operation!");
                    }
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        private static String GetInput(String tip)
        {
            Console.Write(tip);
            return Console.ReadLine();
        }
    }
}
