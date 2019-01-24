using System;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isQuit = false;
            string name = "";
            string pizzaname = "";
            decimal discount = 0.0m;
            double totalCost = 0.0;
            double cost = 0.0;
            char quit = '\0';
            int quantity = 0;
            char isStudent = '\0';
            Console.WriteLine("Welcome to Adusumalli's Pizaa Den!");
            do{
                discount = 0.0m;
                Console.WriteLine("Enter your Name");
                name = Console.ReadLine();
                Console.WriteLine("Please enter the Pizza name (chicken,mozerella,pepperoni)");
                pizzaname = Console.ReadLine();
                Console.WriteLine("Enter the quantity");
                quantity = Convert.ToInt32(Console.ReadLine()); 
                Console.WriteLine("Are you a student (Y/N)?(student discount)");
                isStudent = Convert.ToChar(Console.ReadLine());
                isStudent = Char.ToUpper(isStudent);
                if(isStudent == 'Y'){
                    discount = 10.0m;
                }
                switch(pizzaname.ToUpper()){
                    case "CHICKEN":
                        cost = 10.0;
                        break;
                    case "MOZERELLA":
                        cost = 8.0;
                        break;
                    case "PEPPERONI":
                        cost = 11.0;
                        break;    
                }
                totalCost = GetTotalCost(quantity,cost,discount);
                Console.WriteLine("************Bill************");
                Console.WriteLine($"Name : {name}\n");
                Console.WriteLine($"Pizza : {pizzaname.ToUpper()} Pizza \t Quantity : {quantity}\n");
                Console.WriteLine("Discount : 10%\n");
                Console.WriteLine($"totalCost : ${totalCost}\n");
                Console.WriteLine("************Thank you************");
                Console.WriteLine("Do you want to  Quit?(Y/N)");
                quit = Convert.ToChar(Console.ReadLine());
                quit = Char.ToUpper(quit);
                isQuit = quit == 'N' ? true:false;
            }
            while(isQuit);
        }
        static double GetTotalCost(int quantity,double cost,decimal discount){
            double actualCost = quantity*cost;
            double totalCost = actualCost - (actualCost*Convert.ToDouble(discount)/100);
            return totalCost;
        }
    }
}
