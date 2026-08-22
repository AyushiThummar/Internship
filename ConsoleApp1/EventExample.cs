using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EventExample
    {
        //// Basic event
        //public delegate void WithdrawHandler();
        //public class BankAccount
        //{
        //    public event WithdrawHandler? MoneyWithdrawn;
        //    public void Withdraw()
        //    {
        //        Console.WriteLine("Money Withdrawn.");
        //        MoneyWithdrawn?.Invoke();
        //    }
        //}


        //// EventHandler
        //public class BankAccount
        //{
        //    public event EventHandler? MoneyWithdrawn;
        //    public void Withdraw()
        //    {
        //        Console.WriteLine("Money Withdrawn.");
        //        MoneyWithdrawn?.Invoke(this, EventArgs.Empty);
        //    }
        //}


        //// Event data
        //public class BankAccount
        //{
        //    public event EventHandler<bool>? MoneyWithdrawn;
        //    public void Withdraw()
        //    {
        //        Console.WriteLine("Money Withdrawn.");
        //        MoneyWithdrawn?.Invoke(this, true);
        //    }
        //}

        // Custom EventArgs
        public class BankAccount
        {
            public event EventHandler<ProcessEventArgs>? MoneyWithdrawn;
            public void Withdraw()
            {
                Console.WriteLine("Money Withdrawn.");

                var data = new ProcessEventArgs();

                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now;

                MoneyWithdrawn?.Invoke(this, data);
            }
        }
        public class ProcessEventArgs : EventArgs
        {
            public bool IsSuccessful { get; set; }
            public DateTime CompletionTime { get; set; }
        }
    }
}
