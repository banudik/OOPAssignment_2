using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment_2.Entities;

public abstract class BaseCreditManager : ICreditManager
{
    public abstract void Calculate();

    public virtual void Save()
    {
        Console.WriteLine("Kaydedildi.");
    }
}

//abstract sınıflar bizim için ortak op. tutar ama bu opların tamamlanmış ve tamamlanmamış olanları bu şekilde tutar.
