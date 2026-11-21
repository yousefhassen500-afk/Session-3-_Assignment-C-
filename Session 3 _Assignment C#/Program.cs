using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Session_3__Assignment_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello,yousef ");


            #region session task 
            //string name;
            //int v;

            //do
            //{

            //    Console.WriteLine("Hello Yousef Enter your Name  ");
            //    name = Console.ReadLine();

            //}  while (string.IsNullOrEmpty(name) || int.TryParse(name, out v));


            //int Age;
            //bool flag;

            //do
            //{

            //    Console.WriteLine("Hello Yousef Enter your Age  ");
            //    flag=int.TryParse(Console.ReadLine(), out Age);
            //}
            //while (!flag || Age<0);

            //int grade1 , grade2 , grade3 ;

            //do
            //{

            //    Console.WriteLine("Hello Yousef Enter your Grade1  ");
            //    flag = int.TryParse(Console.ReadLine(), out grade1);
            //}
            //while (!flag || grade1 < 0);


            //do
            //{

            //    Console.WriteLine("Hello Yousef Enter your Grade2  ");
            //    flag = int.TryParse(Console.ReadLine(), out grade2);
            //}
            //while (!flag || grade2 < 0);

            //do
            //{

            //    Console.WriteLine("Hello Yousef Enter your Grade3  ");
            //    flag = int.TryParse(Console.ReadLine(), out grade3);
            //}
            //while (!flag || grade3 < 0);

            //int totalGrads = grade1 + grade2 + grade3;

            //double avgGrads = totalGrads / 3;
            //Console.Clear();
            //Console.WriteLine($"Total Grades = {totalGrads}" );
            //Console.WriteLine($"Average  = {avgGrads}" );

            //if (avgGrads>=50)
            //{
            //    Console.WriteLine("Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            //if (Age>=18)
            //{
            //    Console.WriteLine("you are 18 or older you adult ");
            //}
            //else
            //{
            //    Console.WriteLine("you are less than 18 you are minor ");
            //}

            #endregion

            #region Q1
            // Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.

            //string title = "clean code";
            //string upperTitle=title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);
            #endregion


            #region Q2

            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //  to check if they point to the same object in memory.

            //string t1 = "Clean Code";
            //string t2 = "Clean Code";
            //Console.WriteLine(string.ReferenceEquals(t1, t2));

            #endregion



            #region Q3

            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //  object.Print the final result.

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append("  -Updated ");
            //Console.WriteLine(sb.ToString());
            #endregion


            #region  Q4

            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //    Print the result.
            //sb.Replace("Book List","Library");

            //Console.WriteLine(sb.ToString());
            #endregion




            #region Q5
            // Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //  Pages: 464" using the + operator.

            //string title = "Clean Code";
            //int pages = 464;

            //Console.WriteLine("Book :  "+title  + "  Pages: " + pages);
            #endregion



            #region Q6
            // Build the same sentence as above, but using string interpolation ($"...").

            // Console.WriteLine($"Book : {title} Pages : {pages}");

            #endregion


            #region Q7

            //Build the same sentence again, but using string.Format().

            //   string msg = string.Format("Book : {0}   Pages : {1}",title,pages);

            //  Console.WriteLine(msg);
            #endregion


            #region Q8
            // Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than
            //  300, otherwise prints "Short Book".

            //int Pages = 464;

            //if (Pages>300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Q9

            //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is
            //greater than 300 and isAvailable is true.  Use the && operator.
            //int Pages = 464;

            //bool IsAvailable = true;


            //if (Pages>300 && IsAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");

            //} 

            //else
            //    Console.WriteLine("you can't borrow Book");

            #endregion




            #region Q10
            // Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is
            // "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.

            //    string Title = "Refactoring"; 

            //    switch (Title)
            //    {

            //        case ("Refactoring") : Console.WriteLine("Nice pick!");

            //            break;

            //            default :  Console.WriteLine("Never heard of it");

            //            break;
            //}    

            #endregion



            #region  Q11

            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a
            // variable sizeLabel(same rule as question 8: long if pages > 300).

            //int Pages = 464;

            //string sizeLabel = Pages > 300 ? "Long book" : "Shot Book";


            //Console.WriteLine(sizeLabel);

            #endregion

            #region Q12
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop
            // to print each book with its position number, like 1.Clean Code.

          //  string[] books = {"Clean Code", "The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{
            //    Console.WriteLine($" {i+1} . " +   books[i]);

            //}

            #endregion


            #region Q13
            //Using the same books array, use a while loop to print every book title.
            //int i = 0;


            //int i = books.Length;
            //while (i!=0)
            //{
            //    Console.WriteLine(books[i-1]);
            //    i--;
            //}




            //while (i <books.Length)
            //{
            //    Console.WriteLine(books[i ]);

            //    i++;
            //}


            #endregion


            #region q14
            // Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int i = 3;

            //do
            //{
            //    Console.WriteLine("Chcking Books");
            //    i--;
            //}
            //while (i!=0);

            #endregion

            #region  Q15

            // Using the same books array, use a foreach loop to print every book title.


            //foreach (string book in books)
            //{

            //    Console.WriteLine(book);

            //}

            #endregion


            #region Q16

            // Using the same books array, loop through it and print each title, but stop completely (break) once
            //  you reach "Refactoring".


            //for (int i = 0; i < books.Length; i++)
            //{




            //    Console.WriteLine(books[i]);

            //    if (i == 1)
            //    {
            //        break;
            //    }
            //}


            #endregion


            #region Q17


            // Using the same books array, print every title except "The Pragmatic Programmer" (skip it with
            //  continue, don't stop the loop).

            //for (int i = 0; i < books.Length; i++)
            //{


            //    if (i == 1)
            //    {

            //        continue;


            //    }

            //    Console.WriteLine(books[i]);




            //}


            #endregion


            #region Q18
            //Write a method PrintFirstBook() that prints the first book in the books array. If the array is empty,
            // use return to exit the method early instead of printing anything.

        //    void PrintFirstBook(string[] books)
        //    {

        //        if (books.Length == 0 || books is null)
        //    {
        //        return;
        //    }


        //    Console.WriteLine(books[0] );

        //}





        //PrintFirstBook(books);

            #endregion
    }
    }
}
