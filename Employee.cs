using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Exercise_2
{
    public class Employee
    {
        //constructor that initialize class variable
        public Employee(string First_BF, string Last_BF, decimal Salary_BF)
        {
            First = First_BF;
            Last = Last_BF;
            Salary = Salary_BF; 
            Benefits = "Medical"; 
            TypeEmployee = "Contractor" ;
        }   

        public Employee(string Benefits_BF, string First_BF, string Last_BF, decimal Salary_BF): this(First_BF, Last_BF, Salary_BF)
        {
            Benefits = Benefits_BF; 
        }
        public string Benefits {get; set;}
        public string First {get; set;}
        public string Last {get; set;}
        public decimal Salary {get; set;}
        public string TypeEmployee { get; } 
        // property that returs a string
        public string strToCheckPalindrome {get;} = "reconocer";

        public void PrintSequenceNumbers (List<int> lstInt1)
        {
            if (lstInt1.Count > 0)
            {
                Console.WriteLine("\nAplying Method overloading to \"PrintSequenceNumbers\". Print a sequense of numbers from a List: "); 
                foreach(int n in lstInt1)
                {
                    Console.Write("{0} ", n);
                }
            }
            else
            {
                Console.WriteLine("\nSequense not printed. Reason: The list is empty ");
            }    
        }

         public void PrintSequenceNumbers ()
        {
            Console.WriteLine("\nAplying Method overloading to \"PrintSequenceNumbers\". Print by default a sequense of numbers from 1 to 5 in diagonal: "); 
            StringBuilder SB = new StringBuilder();  
            string blankSpace = " ", breakSpace = "\n";   
            SB.Append(breakSpace);   
            for (var i = 0; i < 5 ; i++)
            {
                for (var j = 0; j <= i ; j++)
                {
                    SB.Append(blankSpace); 
                }
                SB.Append(i+1);
                SB.Append(breakSpace); 
            }
            Console.WriteLine("{0}", SB.ToString());
        }

        public void IsPalindrome(string strWord)
        {
            char[] myArray = strWord.ToCharArray(); 
            Array.Reverse(myArray); 
            var strToCheckPalindrome2 = new string (myArray); 
            Console.WriteLine("\nCheck if a word is palindrome using the created property: \"strToCheckPalindrome\"");
            if(strToCheckPalindrome.Trim().CompareTo(strToCheckPalindrome2.Trim()) == 0)
            {
                Console.WriteLine("The string \"{0}\" is palindrome", strWord); 
            } 
            else 
            {
                Console.WriteLine("The string \"{0}\" is not palindrome", strWord); 
            }  
        }

        public void DiagonalPrint(int intLimit)
        {
            if (intLimit > 0)
            {
                StringBuilder SB = new StringBuilder();  
                string blankSpace = " ", breakSpace = "\n";   
                SB.Append(breakSpace);   
                for (var i = 0; i < intLimit ; i++)
                {
                    for (var j = 0; j <= i ; j++)
                    {
                        SB.Append(blankSpace); 
                    }
                    SB.Append(i+1);
                    SB.Append(breakSpace); 
                }
                    Console.WriteLine("\nPrint {0} numbers in diagonal {1}\n", intLimit, SB.ToString());
            }
            else 
            {
                Console.WriteLine("\nNot able to print numbers in diagonal. Reason: limit = 0 ");
            }
        }
    }    
}