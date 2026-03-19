using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library_Management_System
{

    abstract class Member
    {
        public int id;
        public string name;
        public int phone;
       public Book[] borrowedBooks = new Book[2];

        public void BorrowBook(Book book)
        {

        }


        public void ReturnBook(Book book)
        {

        }

        public abstract int GetMaxBorrowLimit();


    }
}
