using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());

//foreach (var car in carManager.GetCarDetails())
//{
//    Console.WriteLine(car.BrandName + " " + car.CarName + " = " + car.ColorName);
//}


//CarManager carManager = new CarManager(new EfCarDal());
//var result = carManager.GetAll();

//foreach (var item in result.Data)
//{
//    Console.WriteLine(item.Description);
//}

//Customer customer = new Customer();
//customer.CustomerId = 1;
//customer.UserId = 1;
//customer.CompanyName = "Beserek A.Ş";

//Rental rental1 = new Rental();
//rental1.CustomerId = 1;
//rental1.Id = 2;
//rental1.CarId = 2;
//rental1.RentDate = new DateTime(2024, 1, 15, 15, 30, 10);
//rental1.ReturnDate = new DateTime(2024, 1, 17, 15, 30, 10); ;


//RentalManager rentalManager = new RentalManager(new EfRentalDal());
//var result = rentalManager.GetAll();

//foreach (var resultItem in result.Data)
//{
//    Console.WriteLine(resultItem.Id);
//}

//var result2 =  rentalManager.Add(rental1);
//Console.WriteLine(result2.Message);
