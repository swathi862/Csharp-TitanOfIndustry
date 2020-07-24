using System;
using System.Collections.Generic;

namespace industry_titan
{

    class Program
    {

        static void Main(string[] args)
        {

            AutoIndustry CarsRUs = new AutoIndustry(){
                factoryName = "CarsRUs",
                minEmployeeCount = 2,
                maxEmployeeCount = 50
            };

            FoodIndustry ChimkenNugget = new FoodIndustry(){
                factoryName = "Chimken Nugget",
                minEmployeeCount = 2,
                maxEmployeeCount = 3
            };

            SteelIndustry Blech = new SteelIndustry(){
                factoryName = "Blech",
                minEmployeeCount = 2,
                maxEmployeeCount = 100
            };

            AutoWorker autoEmployee1 = new AutoWorker(){
                Name = "Ron Weasley",
                DateHired = new DateTime (2015,8,15),
                PayRate = 20.0
            };

            AutoWorker autoEmployee2 = new AutoWorker(){
                Name = "Bill Weasley",
                DateHired = new DateTime (2010,6,4),
                PayRate = 35.0
            };

            AutoWorker autoEmployee3 = new AutoWorker(){
                Name = "Arthur Weasley",
                DateHired = new DateTime (2002,3,10),
                PayRate = 30.0
            };

            FoodProcessor foodEmployee1 = new FoodProcessor(){
                Name = "Molly Weasley",
                DateHired = new DateTime (2003,9,6),
                PayRate = 40.0
            };

            FoodProcessor foodEmployee2 = new FoodProcessor(){
                Name = "Fred Weasley",
                DateHired = new DateTime (2014,5,12),
                PayRate = 25.0
            };

            FoodProcessor foodEmployee3 = new FoodProcessor(){
                Name = "George Weasley",
                DateHired = new DateTime (2014,5,12),
                PayRate = 25.0
            };

            FoodProcessor foodEmployee4 = new FoodProcessor(){
                Name = "Angelina Johnson",
                DateHired = new DateTime (2014,5,18),
                PayRate = 26.50
            };

            SteelWorker steelEmployee1 = new SteelWorker(){
                Name = "Ginny Weasley",
                DateHired = new DateTime (2018,2,16),
                PayRate = 26.0
            };

            SteelWorker steelEmployee2 = new SteelWorker(){
                Name = "Percy Weasley",
                DateHired = new DateTime (2014,11,21),
                PayRate = 28.0
            };

            SteelWorker steelEmployee3 = new SteelWorker(){
                Name = "Charlie Weasley",
                DateHired = new DateTime (2008,4,23),
                PayRate = 45.0
            };

            
            CarsRUs.HireEmployees(new List<AutoWorker>(){autoEmployee1, autoEmployee2, autoEmployee3});
            ChimkenNugget.HireEmployees(new List<FoodProcessor>(){foodEmployee1, foodEmployee2, foodEmployee3});
            Blech.HireEmployees(new List<SteelWorker>(){steelEmployee1, steelEmployee2});

            ChimkenNugget.HireEmployee(foodEmployee4);
            Blech.HireEmployee(steelEmployee3);

            bool exit = false;
            while(exit == false){
                Console.WriteLine("\nWelcome to H.E. Pennypacker Industries!");
                Console.WriteLine("1. View employees at a factory");
                Console.WriteLine("2. Hire a new employee");
                Console.WriteLine("3. Exit\n");

                string response = Console.ReadLine();

                if(response == "1"){
                    Console.WriteLine("\nSelect a factory");
                    Console.WriteLine("1. Automobiles");
                    Console.WriteLine("2. Chicken Nuggets");
                    Console.WriteLine("3. Steel\n");

                    string factoryResponse = Console.ReadLine();

                    if(factoryResponse == "1"){
                        CarsRUs.ListEmployees();
                    }
                    else if (factoryResponse == "2"){
                        ChimkenNugget.ListEmployees();
                    }
                    else if(factoryResponse == "3"){
                        Blech.ListEmployees();
                    }
                }

                else if (response == "2"){
                    Console.WriteLine("\n Which factory is this worker being hired in? \n 1.Auto\n 2.Food \n 3.Steel");
                    string placeOfWork = Console.ReadLine();
                    Console.WriteLine("\nAdd Employee Details");
                    Console.WriteLine("Enter the employee's full name.");
                    string employeeName = Console.ReadLine();
                    Console.WriteLine("Enter the employee's rate of pay.");
                    double pay = Convert.ToDouble(Console.ReadLine());


                    if(placeOfWork == "1"){
                        AutoWorker employee = new AutoWorker(){
                            Name = employeeName,
                            DateHired = DateTime.Now,
                            PayRate = pay
                        };

                        CarsRUs.HireEmployee(employee);

                    }
                    else if (placeOfWork == "2"){
                        FoodProcessor employee = new FoodProcessor(){
                            Name = employeeName,
                            DateHired = DateTime.Now,
                            PayRate = pay
                        };

                        ChimkenNugget.HireEmployee(employee);

                    }
                    else if (placeOfWork == "3"){
                        SteelWorker employee = new SteelWorker(){
                            Name = employeeName,
                            DateHired = DateTime.Now,
                            PayRate = pay
                        };

                        Blech.HireEmployee(employee);

                    }
                    
                }
                else if(response == "3"){
                    Console.WriteLine("Thanks for visiting!");
                    exit = true;
                }
            }

            Console.WriteLine();
        }
    }
}
