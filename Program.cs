using Polymorphism_abstraction_home.Modes;

#region Task1
//Shape circle = new Circle(5.5);
//Console.WriteLine(circle.CalculateArea());
#endregion

#region Task2
//CurrentAccount ca = new();

//ca.Balance = 100;
//ca.Deposit(100);
//ca.CalculateInteres(20);

//SavingAccount sva=new SavingAccount();
//sva.Balance = 500;
//sva.Deposit(100);
//sva.CalculateInteres(20);

//Console.WriteLine(sva.AccountNumber);
#endregion


#region Task3
//Employee fultimeWorker = new FullTimeEmployee( 1,"Veli");
//fultimeWorker.CalculateSalary(9, 15);

//Employee parttimeWorker = new PartTimeEmployee(5, "Eli");
//parttimeWorker.CalculateSalary(5, 6);
#endregion


#region Task5
IlabiraryItem book = new Book("Xemse","Nizami Gencevi",2);

book.CheckOut(1);
book.Return(1, "Nizami Gencevi");
#endregion