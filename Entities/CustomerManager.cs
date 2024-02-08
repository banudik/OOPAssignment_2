using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment_2.Entities;

public class CustomerManager
{
    //sadece bu classın içinde kullanılır
    private Customer _customer;
    private ICreditManager _creditManager;

    //Constructor bloğu
    public CustomerManager(Customer customer, ICreditManager creditManager)
    {
        _customer = customer;
        _creditManager = creditManager;

    }
    //bir müşteri nesnesini parametre olarak gönderiyoruz. 
    public void Save()
    {
        Console.WriteLine("Müşteri kaydedildi.");
    }

    public void Delete()
    {
        Console.WriteLine("Müşteri silindi. ");
    }

    public void GiveCredit()
    {
        _creditManager.Calculate();
        Console.WriteLine("Kredi verildi.");
    }
}
