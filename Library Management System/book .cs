using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Book
    {
        public int id;
        public string title;
        public string author;
        public double price;
        public bool IsBorrowed;



        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Is Borrowed: " + IsBorrowed);
        }

    }
}
