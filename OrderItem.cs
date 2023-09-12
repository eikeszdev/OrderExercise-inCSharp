using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Exercicios.Entities;

namespace Exercicios.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            this.Quantity = quantity;
            this.Price = product.Price;
            this.Product = product;
        }

        public double SubTotal()
        {
            return this.Quantity * this.Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Product);
            sb.Append(", Quantity: ");
            sb.Append(Quantity);
            sb.Append(", Subtotal: $");
            sb.Append(SubTotal());
            return sb.ToString();
        }
    }
}
