using static System.Console;
using System.Linq;
using System;
using System.Globalization;

namespace csharpbook{

    class dateFunctions{

        static void Main(string[] args){

            WriteLine("------------ Date Functions ---------------");
            int day = 15;
            int month = 2;
            int year = 1999;
            DateTime date = new DateTime(year, month, day);
            WriteLine($"Date is: {date}");
            WriteLine($"Formatted date: {date:dddd/MM/yy}");
            WriteLine($"Formatted date: {date:dd/MM/yyyy}");
            WriteLine($"Formatted date: {date:dddd dd/MMMM/yy}");

            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
            WriteLine($"Today's date: {today}");
            WriteLine($"Current time: {now}");

            WriteLine($"Formatted Today's date: {today:dddd/MMMM/yyyy}");
            WriteLine($"Formatted Current time: {now:dddd/MMMM/yy hh:mm:ss}");

            WriteLine($"Day of the month: {now.Day}");
            WriteLine($"Day of the week: {now.DayOfWeek}");
            WriteLine($"Day of the year: {now.DayOfYear}");
            WriteLine($"Month: {now.Month}");
            WriteLine($"Year: {now.Year}");

            DateTime orderDate = today;
            DateTime expireDate = orderDate.AddDays(35);
            DateTime paymentDate  = expireDate.AddMonths(2);
            WriteLine($"Order done requested in {orderDate:dd/MMM/yyyy} expires in {expireDate:dd/MM/yyyy}");
            WriteLine($"Long formatting: {orderDate.ToLongDateString()}, short formatting: {orderDate.ToShortDateString()}");
            WriteLine($"PT-BR culture formatting: {expireDate.ToString("dddd", new CultureInfo("pt-BR"))}");
            WriteLine($"En culture formatting: {expireDate.ToString("dddd", new CultureInfo("en"))}");
            WriteLine($"Days between expire-payment dates: {paymentDate.Subtract(expireDate).ToString("dd")}");

            WriteLine("------------ Date Convertion ---------------");
            string stringDate = "15/07/2022";
            string wrongString = "dasdas";
            DateTime dateFormat;
            DateTime.TryParse(stringDate, out dateFormat);
            WriteLine(dateFormat);
        
            if(DateTime.TryParse(wrongString, out dateFormat))
                WriteLine("Done");
            else WriteLine("Fail");

            WriteLine("------------ Object Display ---------------");
            Order order = new Order(1, new DateTime(2022, 7, 8), new DateTime(2022, 10, 9), 20);
            WriteLine($"Order: {order.orderID}" 
            + System.Environment.NewLine
            + $"Price: R${order.price:.00}"
            + System.Environment.NewLine
            + $"Penalty: R${order.penalty:.00}"
            + System.Environment.NewLine
            + $"Order Date: {order.orderDate:dd/MM/yyyy}"
            + System.Environment.NewLine
            + $"Expire Date: {order.expireDate:dd/MM/yyyy}"
            + System.Environment.NewLine
            + $"Payment Date: {order.paymentDate:dd/MM/yyyy}"
            + System.Environment.NewLine
            + $"Delay days: {order.delay:dd}"
            + System.Environment.NewLine
            );
        }
    }

    public class Order{
        public int orderID {get; private set;}
        public DateTime orderDate {get; private set;}
        public DateTime expireDate {get; private set;}
        public DateTime paymentDate {get; private set;}
        public TimeSpan delay {get; private set;}
        public int price {get; private set;}
        public decimal penalty {get; private set;}

        public Order(int id, DateTime orderDate, DateTime payment, int price){
            orderID = id;
            this.orderDate = orderDate;
            expireDate = orderDate.AddDays(30);
            paymentDate = payment;
            delay = paymentDate.Subtract(expireDate);
            this.price = price;
            penalty = price*1.1m;
        }
    }
}