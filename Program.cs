using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2Code

{
    class Program
    { 
        static void Main(string[] args)
        {
            string menuKey = "";
            while (menuKey != "E" && menuKey != "e") 

            {   //print out menu
                Console.WriteLine(" (C): Convert Currency \n (R): Restaraunt Point of Sale \n (E): Exit \n Please enter your choice");
                //change menu key
                menuKey = Console.ReadLine();

                //menu
                switch (menuKey)
                {
                    case "C":
                    case "c":
                        ConvertCurrency();
                        break;

                    case "R":
                    case "r":
                        RestarauntPOS();
                        break;
                    case "E":
                    case "e":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid value");
                        break;




                }

                

            }
            }

        static void ConvertCurrency()
        {
            //establish variables
            string toFromKey;
            string currencyKey;
            double value;

            //establish rates
            const double canadian = .9813;
            const double euro = .757;
            const double indian = 52.53;
            const double japanese = 80.92;
            const double mexican = 13.1544;
            const double british = .6178;



            //clear 
            Console.Clear();

            //to or from US dollars
            Console.WriteLine("Are you going (T)o or (F)rom US Dollars");

            //set toFrom
            toFromKey = Console.ReadLine();

            //how much do you have
            Console.WriteLine("Please enter your current amount");

            //set value
            value = double.Parse(Console.ReadLine());

            // to or from
            switch (toFromKey)
            {
                case "T":
                case "t":
                    Console.WriteLine("Select current currency: ");
                    currencyMenu();
                    currencyKey = Console.ReadLine();
                    ConvertTo(currencyKey, value);
                    break;
                case "F":
                case "f":
                    Console.WriteLine("Select desired currency");
                    currencyMenu();
                    currencyKey = Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("You did not enter a valid value");
                    break;
            }



            //set toFrom
            toFromKey = Console.ReadLine();

            Console.WriteLine("Please enter your current amount.");











        }
        static void ConvertTo(string currencyKey, double value)
        {//establish constants
            const double canadian = .9813;
            const double euro = .757;
            const double indian = 52.53;
            const double japanese = 80.92;
            const double mexican = 13.1544;
            const double british = .6178;
            //add others

            switch (currencyKey)
            {
                case "C":
                case "c":
                    value = value / canadian;
                    break;
                case "E":
                case "e":
                    value = value / euro;
                    break;
                case "I":
                case "i":
                    value = value / indian;
                    break;
                case "J":
                case "j":
                    value = value / japanese;
                    break;
                case "M":
                case "m":
                    value = value / mexican;
                    break;
                case "B":
                case "b":
                    value = value / british;
                    break;
                default:
                    break;

                   
            }

            

            Console.WriteLine("You now have " + value + " US Dollars");
        }

        static void ConvertFrom(string currencyKey, double value)
        {//establish constants
            const double canadian = .9813;
            const double euro = .757;
            const double indian = 52.53;
            const double japanese = 80.92;
            const double mexican = 13.1544;
            const double british = .6178;
            //add others

            switch (currencyKey)
            {
                case "C":
                case "c":
                    value = value * canadian;
                    Console.WriteLine("You now have " + value + " Canadian Dollars");
                    break;
                case "E":
                case "e":
                    value = value * euro;
                    Console.WriteLine("You now have " + value + " Euros");
                    break;
                case "I":
                case "i":
                    value = value * indian;
                    Console.WriteLine("You now have " + value + " Indian Rupees");
                    break;
                case "J":
                case "j":
                    value = value * japanese;
                    Console.WriteLine("You now have " + value + " Japanese Yen");
                    break;
                case "M":
                case "m":
                    value = value * mexican;
                    Console.WriteLine("You now have " + value + " Mexican Pesos");
                    break;
                case "B":
                case "b":
                    value = value * british;
                    Console.WriteLine("You now have " + value + " British Pounds");
                    break; 
                default:
                    break;
            }



               
        }

        static void currencyMenu()
        {
            Console.WriteLine("Please select your current currency:");
            Console.WriteLine("(C): Canadian Dollar");
            Console.WriteLine("(E): Euro");
            Console.WriteLine("(C): Indian Rupee");
            // add other options
        }

        static void RestarauntPOS()
        //insert code
        {
            Console.Clear();
            double foodTotal;
            double alcTotal;
            double foodTip;
            double salesTax;
            double salesTotal;
            double payment;
            double change;
            //Food total
            Console.WriteLine("Enter food total: ");
            foodTotal = double.Parse(Console.ReadLine());
            //Alc total
            Console.WriteLine("Enter alchohol total: ");
            alcTotal = double.Parse(Console.ReadLine());

            //asses non alchohol tip
            foodTip = foodTotal * 0.18;

            //calculate tax
            salesTax = (foodTotal + alcTotal) * .09;

            //Calculate total sale
            salesTotal = foodTotal + alcTotal + foodTip + salesTax;

            // display total
            Console.WriteLine("Your total is $" + salesTotal);
            bool validPayment = false;

            //Read in payment
            while(validPayment == false)
            {
                Console.WriteLine("Please enter your payment amount");
                payment = double.Parse(Console.ReadLine());
                if(payment < salesTotal)
                {
                    Console.WriteLine("ERROR: Payment is less than total. Please pay more");
                }else
                {
                    change = payment - salesTotal;
                    Console.WriteLine("You owe $ " + change + " in change");
                    validPayment = true;

                }
                
            }
            
        }
    }
}
