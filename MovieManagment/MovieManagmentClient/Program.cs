using MovieManagmentClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagmentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new AuthenticationServiceClient();
            try
            {
                string token = client.AuthenticateUser("testUser", "testPassword");
                Console.WriteLine("Authentication successful. Token: " + token);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            client.Close();
            Console.ReadLine();
        }
    }
}
