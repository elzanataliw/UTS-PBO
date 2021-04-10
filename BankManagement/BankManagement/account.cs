using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    class account
    {
        private int accnumb;
        public int useraccnumb
        {
            get { return accnumb; }
            set { accnumb = value; }
        }

        protected string name;
        internal int deposit;

        protected void create_account()
        {
            Console.Write("\nEnter the account number : ");
            useraccnumb = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the account holder : ");
            name = Console.ReadLine();
            Console.Write("Enter the initial amount : ");
            deposit = int.Parse(Console.ReadLine());
            Console.Write("\n\nAccount created..\n");
        }

        public void createaccount()
        {
            create_account();
        }

        public void accountdep()
        {
            int x;
            Console.WriteLine("\nEnter the amount you want to deposit : ");
            x = int.Parse(Console.ReadLine());
            deposit += x;
        }

        public void accountdraw()
        {
            int x;
            Console.Write("\nEnter the amount you want to withdraw : ");
            x = int.Parse(Console.ReadLine());
            deposit -= x;
        }

        public void accountreport()
        {
            Console.Write("\nAccount Number : {0}\nName : {1}\nDeposit: {2}\n", accnumb, name, deposit);
        }

        public int retaccnumb()
        {
            return accnumb;
        }

        public int retdeposit()
        {
            return deposit;
        }
    }
}
