using System;

namespace Linq
{
    public class Invoice
    {
        public string Company { get; set; }
        public DateTime DueDate { get; set; }
        public int Price { get; set; }

        public Invoice(string company, DateTime dueDate, int price)
        {
            Company = company;
            DueDate = dueDate;
            Price = price;
        }
    }
}
