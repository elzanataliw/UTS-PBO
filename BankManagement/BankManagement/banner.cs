using System;
using System.Collections.Generic;
using System.Text;

namespace BankManagement
{
    struct banner
    {
        private void intro()
        {
            Console.Write("------------------------------------------");
            Console.Write("\n          TABUNGAN KOPERASI\n");
            Console.Write("------------------------------------------");
        }

        public void showintro()
        {
            intro();
        }

        internal void load()
        {
            Console.Write("Loading");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
