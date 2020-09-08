using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Projeto__Enumerações_e_Composição_.Entities.Enums;

namespace Projeto__Enumerações_e_Composição_.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(Client.BirthDate.ToString(" (dd/MM/yyyy) - "));
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");

            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append($", Quantity: {item.Quantity}, Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                total += item.SubTotal();
            }
            sb.Append("Total price: $");
            sb.AppendLine(total.ToString("F2", CultureInfo.InvariantCulture));
            
            return sb.ToString();
        }
    }
}
