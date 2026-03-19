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
       public Book[] borrowedBooks = new Book[20];
        int BorrowIndex = 0;
        public void BorrowBook(Book book)
        {

            if (BorrowIndex < GetMaxBorrowLimit() && book.IsBorrowed==false)
            {
                borrowedBooks[BorrowIndex] = book;
                BorrowIndex++;
                book.IsBorrowed = true;
            }
            else
            {
                Console.WriteLine("Borrow  max limit ");
            }
        }

            


        public void ReturnBook(Book book)
        {
            for (int i = 0; i < BorrowIndex; i++)
            {
                if (book == borrowedBooks[i])
                {
                    borrowedBooks[i] = null;
                    BorrowIndex--;
                    book.IsBorrowed = false;
                }
            }
        }
        public abstract int GetMaxBorrowLimit();


    }
}
