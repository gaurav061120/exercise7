using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleAppex7
{
    public class ValidationExc : Exception
    {
        public ValidationExc(string msg) : base(msg) { }
    }
    public class UserRegSystem
    {
        internal class program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("user registration :");
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter email");
                    string email = Console.ReadLine();
                    Console.WriteLine("enter password");
                    string pswd = Console.ReadLine();
                    Validate(name);
                    Validate(email);
                    Validate(pswd);
                    checkLength(name);
                    checkLength(pswd);
                    Console.WriteLine("registration successful");
                }
                catch (ValidationExc) { Console.WriteLine("Validation unsuccessful" ); }
                catch (Exception ex) { Console.WriteLine("error " + ex.Message); }
                finally { Console.WriteLine("end of program"); }
                Console.ReadKey();

            }
            public static void Validate(string token)
            {
                if (string.IsNullOrEmpty(token))
                {
                    throw new ValidationExc("validation error");

                }
            }
            public static void checkLength(string token) { if(token.Length <= 6)
                    {
                    throw new ValidationExc($"{token} length is too small");
                } }
        }
    }
}



        


        
                
                
            
            
        
    

