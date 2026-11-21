namespace Assignment1
{
    class Book {
        public string Title = "";
        public int Pages ;
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Q01

            Book book = new Book();
            book.Title= "c# Programming";
            book.Pages = 500;
            object obj = book;
            Console.WriteLine(obj);

            // Q02

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());

            //Q03 -  compile-time error


            int Pages = 464;
            Console.WriteLine(Pages);


            //Q04


            try
            {
                int num = 10;
                int zero = 0;
                int divisionResult = num / zero;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done.");
            }


            //Q05


            int Pages1 = 300;
            double pagesDouble = Pages1;
            Console.WriteLine(pagesDouble);


            //Q06


            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);


            //Q07


            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesInt);


            //Q08


            string yearText = "2023";
            int yearInt = int.Parse(yearText);
            Console.WriteLine(yearInt);

            string badText = "abc";
            int badInt;
            bool result = int.TryParse(badText, out badInt);
            if (result)
            {
                Console.WriteLine(badInt);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            //Q09


            int pages = 464;
            string pagesString = pages.ToString();
            Console.WriteLine(pagesString);
            Console.WriteLine(pagesString.GetType());


            //Q10


            int copies = 100;
            object copiesObject = copies;
            int copiesInt = (int)copiesObject;
            Console.WriteLine(copies);
            Console.WriteLine(copiesInt);



        }
    }
}
