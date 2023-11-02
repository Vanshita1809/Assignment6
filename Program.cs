namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            string c = "y";
            while (c == "y")
            {
                Console.WriteLine("Who are you");
                string userType = Console.ReadLine();
                switch (userType.ToLower())
                {
                    case "admin":
                        Console.WriteLine("What to do");
                        int ch = Byte.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                {
                                    string choice = "y";
                                    while (choice == "y")
                                    {
                                        Console.WriteLine("Enter P Code");
                                        string pCode = Console.ReadLine();
                                        Product product = new Product();
                                        product.GetProductDetails();
                                        Product temp = new Product(pCode, product);
                                        products.Add(temp);
                                        Console.WriteLine("Add more record");
                                        choice = Console.ReadLine();
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    foreach (Product product in products)
                                    {
                                        product.DisplayProducts();
                                    }
                                    break;
                                }
                        }
                        break;
                    case "customer":
                        break;
                }
            }
            Console.WriteLine("Want to repeat");
            c = Console.ReadLine();
        }
    }
}