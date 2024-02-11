using Intro.Business;
using Intro.Entities;

//CourseManager courseManager = new ();
//Course[] courses2 = courseManager.GetAll();

//for (int i = 0; i < courses2.Length; i++)
//{
//    Console.WriteLine(courses2[i].Name + " -- " + courses2[i].Price);
//}


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.FirstName = "Dogi";
customer1.LastName = "Atar";
customer1.NationalIdentity = "12345678910";
customer1.CustomerNumber = "12345";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.FirstName = "Batu";
customer2.LastName = "Gündoğdu";
customer2.NationalIdentity = "12345678920";
customer2.CustomerNumber = "12355";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "abc";
customer3.CustomerNumber = "12346";
customer3.TaxNumber = "3216549871";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 3;
customer4.Name = "abc";
customer4.CustomerNumber = "12346";
customer4.TaxNumber = "3216549871";


BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

