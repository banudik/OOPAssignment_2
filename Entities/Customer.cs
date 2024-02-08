using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment_2.Entities;

public class Customer
{
    public Customer()
    {
        Console.WriteLine("Müşteri nesnesi başlatıldı.");
    }
    //property /getter setter
    public int Id { get; set; }
    public string City { get; set; }
}
