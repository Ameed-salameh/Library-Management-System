using System.Transactions;
using Library_Management_System;
namespace ClassLibrary1
{
    public class Library
    {
        public Book[] Books = new Book[100];
        public Member[] Members = new Member[50];
        public Transaction[] Transactions = new Transaction[200];

        public static int TotalBorrowedBooks = 0;

        int bookIndex = 0;
        int memberIndex = 0;
        int transactionIndex = 0;

        public void AddBook(Book book)
        {
            Books[bookIndex++] = book;
            Console.WriteLine("Book added successfully.");
        }

        public void AddMember(Member member)
        {
            Members[memberIndex++] = member;
            Console.WriteLine("Member added successfully.");
        }






    }
}
