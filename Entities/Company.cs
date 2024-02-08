using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment_2.Entities;

//şirket müşteri nesnesinden inherit olur.
public class Company:Customer
{
    //müşteri temel nesne
    public string CompanyName { get; set; }
    public string TaxNumber { get; set; }
}
