using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary1
{

    public abstract class Member : IFineCalculator
    {
        public int Id;
        public string Name;
        public string Phone;
       public Book[] BorrowedBooks = new Book[10];
        int BorrowIndex ;

        public Member(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
            BorrowedBooks = new Book[10]; 
            BorrowIndex = 0;
        }



        public void BorrowBook(Book book)
        {

            if (BorrowIndex < GetMaxBorrowLimit() && book.IsBorrowed==false)
            {
                BorrowedBooks[BorrowIndex] = book;
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
                if (book == BorrowedBooks[i])
                {
                    BorrowedBooks[i] = null;
                    BorrowIndex--;
                    book.IsBorrowed = false;
                }
            }
        }
        public abstract int GetMaxBorrowLimit();
        public abstract double CalculateFine(int daysLate);


        //---------------------------------------------------//
        public static bool operator >(Member m1, Member m2)
        {
            return m1.BorrowIndex > m2.BorrowIndex;
        }

        public static bool operator <(Member m1, Member m2)
        {
            return m1.BorrowIndex < m2.BorrowIndex;
        }


        public static int operator +(Member m1, Member m2)
        {
            return m1.BorrowIndex + m2.BorrowIndex;
        }





    }
}
