using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Library_Management_System
{
    internal class Book
    {
        public int Id;
        public string Title;
        public string Author;
        public double Price;
        public bool IsBorrowed;



        public Book(int id, string title, string author, double price)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
            IsBorrowed = false;
        }
        public void display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Is Borrowed: " + IsBorrowed);
        }

    }
}
