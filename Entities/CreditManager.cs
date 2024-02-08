using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment_2.Entities;

//class: yapıcağımız işlemleri tutan veya herhangi bir konuda bilgi tutan yapılardır.
public class CreditManager
{
    //method /operation /operasyonları tutar
    public void Calculate(int creditType)
    {
        if (creditType == 1)
        {

        }
        if (creditType == 2)
        {

        }
        Console.WriteLine("Hesaplandı.");
    }

    public void Save()
    {
        Console.WriteLine("Kredi verildi.");
    }
}

public class TeacherCreditManager : BaseCreditManager, ICreditManager
{
    public override void Calculate()
    {
        //hesaplamalar
        Console.WriteLine("Öğretmen kredisi hesaplandı.");
    }

    public override void Save()
    {
        base.Save();
    }
}

public class MilitaryCreditManager : BaseCreditManager, ICreditManager
{
    //override üstüne yaz
    public override void Calculate()
    {
        Console.WriteLine("Asker kredisi hesaplandı.");
    }

    public override void Save()
    {
        base.Save();
    }
}

