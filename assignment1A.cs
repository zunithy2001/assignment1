namespace Assignment1___1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalUserName = "username";
            string originalPassword = "password";

            string userName, password;
            int attempt = 0;
            const int maxAttempts = 3;


            while (attempt < maxAttempts)
            {
                Console.Write("Enter user name");
                userName = Console.ReadLine();

                Console.Write("enter password");
                password = Console.ReadLine();


                if (userName == originalUserName && password == originalPassword)
                {
                    Console.WriteLine("Login Successfully!");
                    break;
                }
                else
                {
                    attempt++;
                    Console.WriteLine($"invalid username or password. Attempt {attempt} out of {maxAttempts}!!");
                }

                if (attempt == maxAttempts)
                {
                    Console.WriteLine("you have been rejected after 3 wrong attempts!!");
                }
            }
            Console.WriteLine("press any key to exit....");
            Console.ReadLine();
        }
    }
}
