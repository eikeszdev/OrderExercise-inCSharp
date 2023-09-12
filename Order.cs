using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Entities.Enums;

namespace Exercicios.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item) {  Items.Remove(item); }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        
        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            foreach(OrderItem item in Items)
            {
                sb.Append(item);
                sb.Append('\n');
            }
            sb.Append("\n");
            sb.Append("Total Price: $");
            sb.Append(Total());
            return sb.ToString();
        }
    }
}
