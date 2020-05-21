using System;
using System.Collections.Generic;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var objEmployeeManager = new Employee("Medical + annual bonus", "Miriam", "Ramírez", 1000);
                var objEmployeeWorker = new Employee("Griselda", "Ortega", 500);
                Console.WriteLine("\nAplying Constructor overloading for \"Benefits\""); 
                Console.WriteLine("- Manager - \nBenefits: {0} \nFirst Name: {1} \nLast Name: {2} \nSalary: {3}", 
                                    objEmployeeManager.Benefits, objEmployeeManager.First, objEmployeeManager.Last, objEmployeeManager.Salary); 
                Console.WriteLine("- Worker  - \nBenefits: {0} \nFirst Name: {1} \nLast Name: {2} \nSalary: {3}", 
                                    objEmployeeWorker.Benefits, objEmployeeWorker.First, objEmployeeWorker.Last, objEmployeeWorker.Salary); 
             
                Console.WriteLine("\nValue of the variable initialized with the constructor");
                Console.WriteLine("- Manager - \nType Of Employee: {0}", objEmployeeManager.TypeEmployee);
                Console.WriteLine("- Worker  - \nType Of Employee: {0}", objEmployeeManager.TypeEmployee);

                List<int> myList1 = new List<int> {6, 8, 2, 5, 20, 18, 7, 35, 0, 19}; 
                objEmployeeManager.PrintSequenceNumbers(myList1);
                objEmployeeManager.PrintSequenceNumbers();

                var myWord = objEmployeeManager.strToCheckPalindrome;
                objEmployeeManager.IsPalindrome(myWord); 

                var numLimit = 10; 
                objEmployeeManager.DiagonalPrint(numLimit); 

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message); 
            }
        }
    }
}
