using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    class mainmenu
    {
        public void menu()
        {
            int n;
            banner show = new banner();
            account bank = new account();

            do
            {
                Console.Write("\n------------------------------------------");
                Console.Write("\n              Main Menu");
                Console.Write("\n------------------------------------------");
                Console.Write("\n\t01. Deposit Amount");
                Console.Write("\n\t02. Withdraw Amount");
                Console.Write("\n\t03. Balance Enquiry");
                Console.Write("\n\t04. Create New Account");
                Console.Write("\n\t05. Exit");
                Console.Write("\n\tSelect your option (1-5) : ");
                n = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 1:
                        {
                            Console.Clear();
                            show.load();
                            bank.accountdep();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            show.load();
                            bank.accountdraw();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            show.load();
                            bank.accountreport();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            show.load();
                            bank.createaccount();
                            break;
                        }
                }
            }
            while (n != 5);
        }
    }
}
