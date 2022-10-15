using StudentManagement.BussinessLogicLayer;
using StudentMangement.Entities;
using System;
using System.Collections;

namespace StudentManagement.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice;
            Employee employee = new Employee();
           
                do
                {
                
                    Console.WriteLine("1.Add a Employee");
                    Console.WriteLine("2.Display a Employee");

                    Console.WriteLine("3.update a Employee");
                    Console.WriteLine("4.delete a Employee");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("Entert choice");

                    choice = Convert.ToInt32(Console.ReadLine());


                    EmployeeBussinessLogicLayer bussinessLogicLayer = new EmployeeBussinessLogicLayer();
                    switch (choice)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Enter Employee id");
                                employee.Id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter Employee name:");
                                employee.Name = Console.ReadLine();
                                Console.WriteLine("Enter age");
                                employee.Age = Convert.ToInt32(Console.ReadLine());

                                bussinessLogicLayer.AddEmployee(employee);
                                Console.WriteLine("Information Added Successfully");
                            }
                            catch
                            {
                                Console.WriteLine("Enter correct value");
                            }


                            break;
                        case 2:

                            bussinessLogicLayer.DisplayEmployee(employee);
                            break;


                        case 3:
                            Console.WriteLine("Enter Employee id");
                            int Id = Convert.ToInt32(Console.ReadLine());

                            if (Id == employee.Id)
                            {

                                bussinessLogicLayer.UpdateEmployee(employee);
                                break;
                            }

                            break;

                        case 4:
                            Console.WriteLine("Enter id");
                            Id = Convert.ToInt32(Console.ReadLine());

                            bussinessLogicLayer.DeleteEmployee(employee);



                            break;





                    }
               

                } while (choice !=0);


           
            }
    }
}
