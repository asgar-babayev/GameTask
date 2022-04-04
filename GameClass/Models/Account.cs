using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass
{
    public class Account
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Cash { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($@"Name - {Name}
Email - {Email}
Cash - {Cash}");
        }
    }
}
