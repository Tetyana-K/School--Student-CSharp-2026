using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Dict_Login_Password
{
    internal class Account
    {
        private Dictionary<string, string> accounts = new Dictionary<string, string>();
        public void Register(string login, string password)
        {
            if (accounts.ContainsKey(login))
            {
                Console.WriteLine($"Login '{login}' is already taken. Please choose another one.");
                return;
            }
            accounts[login] = password;
            Console.WriteLine($"Account with login '{login}' has been registered successfully.");
        }
    }
}
