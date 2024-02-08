using OOPAssignment_2.Entities;

////değer tip value type
//int number1 = 10;
//int number2 = 20;
//number1 = number2;
//number2 = 100;

//Console.WriteLine(number1);

////array reference type// diziler ref. tiptir.
////newlemek(örneğini bellekte oluşturur).
//int[] numbers1 = new[] { 1, 2, 3 };
//int[] numbers2 = new[] { 10, 20, 30 };
//numbers1 = numbers2;

//numbers2[0] = 1000;

//Console.WriteLine(numbers1[0]);


//CreditManager creditManager = new CreditManager();
//creditManager.Calculate();
//creditManager.Calculate();
//creditManager.Save();

////örneğini oluşturmak, instance oluşturmak, instance creation
//Customer customer = new Customer();
//customer.Id = 1;
//customer.City = "İstanbul";

//CustomerManager customerManager = new CustomerManager(customer);
//customerManager.Save();
//customerManager.Delete();

//Company company = new Company();
//company.TaxNumber = "1454577";
//company.CompanyName = "Arçelik";
//company.Id = 100;

//CustomerManager companyManager2 = new CustomerManager(new Person());

//Person person = new Person();
//person.FirstName = "Banu";
//person.NationalIdentity = "465465477889";

//Customer customer1 = new Customer();
//Customer customer2 = new Person();
//Customer customer3 = new Company();
////eğer inheritance varsa // heapteki ref. numarasını tutabilmek

//Console.ReadLine();

//interface(arayüz) iş yapan sınıfların operasyonlarının sadece imza seviyesinde yazarak yazılımda bağımlılığı korumak adına yapılan çalışmadır.

CustomerManager customerManager = new CustomerManager(new Customer(), new TeacherCreditManager());
customerManager.GiveCredit();
Console.ReadLine();

//IoC Container(Yapı) // dependency injection(olay)

//interfacelerin amacı yazılımdaki bağımlılıkları engellemek if lerden kurtulmak

//bir sınıf sadece bir sınıfı inherit edebilir.Bir sınıf birden fazla interface i implemente edebilir.

//abstract classlar sınıf özelliği gösterir.Bir class sadece bir abstract classı inherit edebilir.Bir sınıf sadece bir abstract class ı veya başka bir classı inherit edebilir. !! Abstract classlar ve interfaceler asla newlenemez. İkisi de ref. tiplerin özelliklerinden yararlanılır.

