namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        //{
        //    //Q1

        //    double[] prices = { 25.5, 40.0, 33.75 };

        //    Console.WriteLine(prices[1]);
        //}

        //    //Q2
        //{
        //    int[,] shelfCopies =
        //    {
        //    { 3, 5 },
        //    { 1, 4 }
        //};

        //    //    Console.WriteLine(shelfCopies[1, 0]);
        //    }
        //}
        //        Console.WriteLine("Welcome to the Library!");
        //    }

        //    static void Main()
        //        {
        //            PrintWelcomeMessage();
        //        }

        //        //Q4
        //    }
        //    Console.WriteLine("Book title: " + title);
        //    }

        //    static void Main()
        //{
        //    PrintBookTitle("Clean Code");

        //Q5

        //    pages += 50;
        //}

        //static void Main()
        //    {
        //        int pages = 400;

        //        AddBonusPages(pages);


        //        Console.WriteLine(pages);

        //Q6
        //    prices[0] -= 5;
        //}

        //static void Main()
        //    {
        //        double[] prices = { 25.5, 40.0 };

        //        ApplyDiscount(prices);

        //        Console.WriteLine(prices[0]);


        ////Q7
        //static void AddBonusPagesByRef(ref int pages)
        //{
        //    pages += 50;
        //}

        //static void Main()
        //{
        //    int pages = 400;

        //    AddBonusPagesByRef(ref pages);

        //    Console.WriteLine(pages);
        //}

        //Q8    static void ReplaceArray(ref double[] prices)
    {
        prices = new double[] { 10.0, 12.5, 15.0 };
    }

    static void Main()
        {
            double[] prices = { 25.5, 40.0 };

            ReplaceArray(ref prices);

            Console.WriteLine(prices.Length);
        }
    }