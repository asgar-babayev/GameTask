using GameClass.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameClass.Extension
{
    public static class ShowGameExtension
    {
        public static void ShowGameInfo(this Object obj)
        {
            foreach (var item in obj.GetType().GetProperties())
            {
                Console.WriteLine($"{item.Name} - {item.GetValue(obj)}");
            }
        }
    }
}
