using ProgramBusiness;

namespace ProgramUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username:");
            string Username = Console.ReadLine();   
            Console.WriteLine("Enter Password:");
            string Password = Console.ReadLine();

            VerificationUser DataService = new VerificationUser();
            bool result = DataService.VerifyUser(Username, Password);

           

            if (result && result)
            {
                Console.WriteLine("Login Succeed");
            }
            else
            {
                Console.WriteLine("Login Failed");
            }

        }
    }

}