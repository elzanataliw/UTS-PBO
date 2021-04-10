using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            days bankday = new days();
            banner show = new banner();
            account bank = new account();
            mainmenu bankmenu = new mainmenu();
            show.load();
            Console.Clear();
            
            show.showintro();
            bankday.showactivedays();
            bank.createaccount();
            bankmenu.menu();
        }
    }
}
