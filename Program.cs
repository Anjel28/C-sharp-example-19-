using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography;
using System.Text.Json.Nodes;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

class Program
{
    static void Main()
    {
        int[] studentsMarks = new int[50];
        studentsMarks[0] = 55;
        studentsMarks[1] = 90;

        Console.WriteLine("studentsMarks0:  " +studentsMarks[0] );
        Console.WriteLine("studentsMarks1: " +studentsMarks[1]);

        int total = studentsMarks[0] + studentsMarks[1];
         double Average = total / 2.0;

         Console.WriteLine("Average marks of  first 2 students: " +Average);
    }
}

/*
1111
2222
3333
4444*/

/*class Program
{
    static void Main()
    {
         
    int row = 3;
    int cols = 4;

    for(int i = 1; i<= row; i++)
        {
            for(int j = 1; j<= cols; j++)
            {
                Console.Write(i);
                
            
            }
            
            Console.WriteLine();
        }
    }
}*/
/*
1234
123
12
1*/

/*class Program
{
    static void Main()
    {
        int row = 4;
        while(row >= 1)
        {
            int i = 1;
             while(i <= row)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
            row--;
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        for(int i = 4; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}*/
/*
1
12
123
1234*/

/*class Program
{
    static void Main()
    {
        int row = 1;
        while(row <= 4)
        {
            int i = 1;
            while(i <= row)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
               row++;
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 1; i<= 4; i++)
        {
           for(int j = 1; j<=i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}*/
/*
1234
1234
1234
1234 */

/*class Program
{
    static void Main()
    {
        int row = 1;

        while(row <= 4)
        {
            int i = 1;
            while(i <= 4)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();
            row++;
        }
            }
}*/

/*class Program
{
    static void Main()
    {
        for(int i = 1; i <= 4; i++)
        {for(int j = 1; j<=4; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
          
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        int n = 3;
       for(int i = 1; i <= n; i++)
        {
           for(int j = 1; j <= n- i; j++)
            {
                Console.Write(" ");
            }
            for(int k = 1; k <= 2*i - 1; k++)
            {
                Console.Write("*");
            } 
            Console.WriteLine();
        }
}
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 5; i >= 1; i--)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/
/*class Program
{
    static void Main()
    {
       

        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        int rows = 4;

        for(int i = 1; i <= 4; i++)
        {
            for(int j = 1; j <= 4; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        int n = 5;
        for(int i = n; i >= 1; i--)
        {
            for(int j = n; j > i; j--)
            Console.Write(" ");
            for(int k = 1; k <= 2*i-1; k++)
            Console.Write("*");
            Console.WriteLine();
        }
        for(int i = 1; i <= n; i++)
        {
            for(int j = n; j > i; j--)
            Console.Write(" ");
            for(int k = 1; k <= 2*i-1; k++)
            Console.Write("*");
            Console.WriteLine();
        }
        
    }
}*/

/*class Program
{
    static void Main()
    {
        int n = 7;
        int mid = (n + 1) / 2;

        for(int  i = 1; i <= n; i++)
        {
            for(int j = 1; j <= n ; j++)
            {
                if(i == mid || j == mid)
                Console.Write("*");
                else
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}*/


/*class Program
{
    static void Main()
    {
        int size = 5;

        for(int i =1; i<= size; i++)
        {
            for(int j = 1; j <= size; j++)
            {
                if(i == 1 || i == size || j == 1 || j == size)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        int size = 8;
        for(int i=1; i <= size; i++)
        {
            for(int j =1;  j <= size; j++)
            {
                if((i+j) % 2 == 0)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write("0");
                }
            }
            Console.WriteLine();
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        int n =5;
        for(int i= 1; i<=n; i++)
        {
           6 for(int j =n; j > i; j--)
            Console.Write(" ");
            for(int k = 1; k <= 2*i-1; k++)
            Console.Write("*");
            Console.WriteLine();
        }
        for(int i = n-1; i>= 1; i--)
        {
            for(int j=n; j >i; j--)
            Console.Write(" ");
            for(int k =1; k<= 2*i-1; k++)
            Console.Write("*");
            Console.WriteLine();
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        for(int i = 5; i>=1; i--)
        {
            for(int j = 1; j<=i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        for(int i = 1; i<=5; i++)
        {
            for(int j = 5; j>i; j--)
            Console.Write(" ");
            for(int k = 1; k<=i; k++)
            Console.Write("*");
            Console.WriteLine();
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        for(int i=1; i <= 5; i++)
        {
            for(int j=1; j <= i; j++)
            {
                Console.Write(j + " ");
         }
         Console.WriteLine();
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        for(int i= 1; i<=5; i++)
        {
            for(int j = 1; j<=i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        string[] names = {"Amit", "Ravi", "Sita", "Geeta"};

        for(int i = 0; i<names.Length; i++)
        {
            Console.WriteLine("Present: " + names[i]);
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        int sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            sum += i;
            
        }
        Console.WriteLine("Sum = " + sum);
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 1; i<=15; i+=2)
        {
            Console.WriteLine(i);
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 1; i <= 20; i+=2)
        {
            Console.WriteLine(i);
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 10; i>=1; i--)
        {
            Console.WriteLine("Countdown: " + i);
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 1; i<= 10; i++)
        {
            Console.WriteLine("Student "+ i);
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i = 1; i<=10; i++)
        {
            Console.WriteLine("5 x " + i + " = " +(5*i));
        }
    }
}*/
/*class Program
{
    static void Main()
    {
        for(int i=1; i<=5; i++) { 
            for(int j=1; j<=i; j++) { 
            Console.Write("* ");
         } 
        Console.WriteLine(); 
        }
    }
}*/

/*class Library
{
    static void Main()
    {
          int pricePerApple = 10;
        int totalApples = 5;
        int totalCost = 0;

        for(int i = 1; i <= totalApples; i++)
        {
            totalCost += pricePerApple;
            Console.WriteLine("Apple" + i + "added. Current total = " + totalCost );
        }

        Console.WriteLine("Final Total Cost = " + totalCost);
    }
}*/
/*class Person
{
    static void Main()
    {
        int dailyCalories = 200;
        int totalCalories = 0;

        for(int day = 1; day <= 30; day++)
        {
            totalCalories += dailyCalories;
        }
        Console.WriteLine("Total calories burned in 30 days = " +totalCalories);
    }
}*/
/*class MovieHallSeats  {
    
    static void Main()
    {
        for(int seat = 1; seat <= 20; seat++)
        {
            Console.WriteLine("Seat Number: "+seat);
        }
    }
}*/
/*class BankTransactions{

static void Main(){

    string[] transactions =
        {
            "Deposit $500",
            "Withdraw $200",
            "Deposit $1000",
            "Withdraw $300",
            "Deposit $5000",
            "Withdraw $600",
            };

            int startIndex = transactions.Length - 7;

            for(int i = startIndex; i < transactions.Length; i++)
        {
            Console.WriteLine("Transactions" +(i+1)+ ": " +transactions[i]);
        }

/*string[] students = {"Amit", "Priya", "Rahul", "Sneha", "Vikas", "Neha", "Rohan",};

for(int i = 0; i <= students.Length; i++)
{
    Console.WriteLine("Student" +(i+1)+ ": " +students[i]+ "is Present");
}
}
}*/

/*class ShoppingCart
{
    static void Main()
    {
        double totalPrice = 0;

        for (int i = 1; i <= 5; i++) {
      Console.Write("Enter price of item " + i + ": "); 
        double price = Convert.ToDouble(Console.ReadLine()); 
        totalPrice += price; 
        }
        
        Console.WriteLine("Total price of 5 items = " + totalPrice);
    }
    }*/

/*class Program
{
    static void Main()
    {
    

   char studentGrade = 'A';

   Console.WriteLine("Student Grade: " +studentGrade);
       /* bool isLightOn = true;

        Console.WriteLine("Light Status: " +isLightOn);*/


/*int temperature = 25 ;

Console.WriteLine("Temperature:  " +temperature +"degree celsius");*/
/*double bankBalance = 1500.75;

Console.WriteLine("Bank Balance: " +bankBalance);*/


/* string studentName = "Rahul";
 int studentAge = 20;

 Console.WriteLine("studentName: " +studentName);
 Console.WriteLine("studentAge: " +studentAge);        
  }
}*/
//explicit example
    
        /*int temperature = 34;

        if(temperature > 35)
        {
            Console.WriteLine("Hot Day");
        }
        else if(temperature > 15)
        {
            Console.WriteLine("Cold Day");
        }
        else
        {
            Console.WriteLine("Normal Day");
        }*/
       /*int enteredPin = 1234;
       int correctPin = 1234;
        int balance = 2000;

        if(enteredPin == correctPin && balance > 1000)
        {
            Console.WriteLine("Cash withdrawn");
        }
        else
        {
            Console.WriteLine("Transaction Failed");
        }*/

      /*int age = 15;

      if(age < 13)
        {
            Console.WriteLine("child");
        }
        else if(age < 20)
        {
            Console.WriteLine("Teenager");
        }
        else
        {
            Console.WriteLine("Adult");
        }*/
        /*string trafficLight = "Yellow";

        if(trafficLight == "Red")
        {
            Console.WriteLine("Stop");
        }
        else if(trafficLight == "Yellow")
        {
            Console.WriteLine("yellow");
        }
        else
        {
            Console.WriteLine("Go");
        }*/

       /*int atmBalance = 5000;
       int withdrawalAmount = 3000;

       if(atmBalance >= withdrawalAmount)
        {
            Console.WriteLine("Transaction Successful");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }*/

      /*string today = "Sunday";

      if(today == "Sunday")
        {
            Console.WriteLine("Holiday");
        }
        else
        {
            Console.WriteLine("Working Day");
        }*/

        /*int marks = 78;

        if(marks >= 90)
        {
            Console.WriteLine("Grade A");
        }
        if (marks >= 75)
        {
            Console.WriteLine("Grade B");
        }
        else
        {
            Console.WriteLine("Fail");
        }*/

     /*int age = 18;
     string country = "India";

     if(age > 18 && country == "India")
        {
            Console.WriteLine("You can vote in india");
        }
        else
        {
            Console.WriteLine("You cannot vote in india");
        }*/

       /* int num = 4;

        if(num % 2 == 0)
        {
            Console.WriteLine("It is even number");
        }
        else
        {
            Console.WriteLine("It is odd number");
        }*/

/*string password = "1234";

if(password == "1234")
        {
            Console.WriteLine("Login Successfull");
        }
        else
        {
            Console.WriteLine("Wrong password");
        }*/
     /*int Salary = 60000;

     if (Salary > 50000)
        {
            Console.WriteLine("High Salary");
        }
        else
        {
            Console.WriteLine("Normal Salary");
        }*/
    /*int Salary = 60000;

    if(Salary > 50000)
        {
            Console.WriteLine("The Salary is greater than is 50000");
        }
        else
        {
        Console.WriteLine("The Salary is 50000 or less.");
        }*/

    /* string correctPassword = "12345";
     string enteredPassword = "12345";

     if (enteredPassword == correctPassword)
        {
            Console.WriteLine("password is correct. Access granted");
        }
        else
        {
            Console.WriteLine("Incorrect Password. Access denied");
        }*/

     /* bool isRaining = false;

      if(isRaining)
        {
            Console.WriteLine("Take an umbrella , it is raining outside");
        }
        else
        {
            Console.WriteLine("No rain, you can go without umbrella");
        }*/
        /*int battery =  15;

        if(battery > 20)
        {
            Console.WriteLine("Battery is low! Please Charge your Phone");
        }
        else
        {
            Console.WriteLine("Battery level is sufficient");
        }*/

      /*string trafficLight = "Green";

      if(trafficLight == "Green")
        {
            Console.WriteLine("You can go now");
        }
        else
        {
            Console.WriteLine("Stop! Wait for the green Light");
        }*/

     /* int score = 40;

      if(score > 33)
        {
            Console.WriteLine("The Student has passes the exam");
        }
        else
        {
            Console.WriteLine("The student has failed the exam");
        }*/
     /*bool isShopOpen = true;

        if (isShopOpen)
        {
            Console.WriteLine("The shop is open, you can buy things.");
        }
        else
        {
            Console.WriteLine("The shop is closed now");
        }*/
        /*int temp = 42;

        if(temp > 40)
        {
            Console.WriteLine("It is very hot outside");
        }
        else
        {
            Console.WriteLine("The temperature is normal");
        }*/

     /*int age = 20;

     if(age >= 18)
        {
            Console.WriteLine("Elligible is vote");
        }
        else
        {
            Console.WriteLine("Ellogible is not vote");
        }*/

     /*double payment = 1234.75;
     int wholeRupees = (int)payment;

     Console.WriteLine("Payment in double : " +payment);
     Console.WriteLine("Payment in int (whole rupees ): " + wholeRupees);*/


       /* string birthdateString = "15-08-2007";

        DateTime birthDate = Convert.ToDateTime(birthdateString);

        DateTime today = DateTime.Now;

        int age = today.Year - birthDate.Year;

        if(today < birthDate.AddYears(age))
        {
            age--;
        }

        Console.WriteLine("BirthDate entered: " +birthDate.ToShortDateString());
        Console.WriteLine("Current Date: " + today.ToShortDateString());
        Console.WriteLine("Calculated Age: " + age + "Years");*/


    
    /* float marks = 85.5f;

     string marksString = marks.ToString();

     Console.WriteLine("Report Card");
     Console.WriteLine("---------");
     Console.WriteLine("Student Name: Rahul Sharma");
     Console.WriteLine("Marks Obtained: "+marksString);*/

    /*double tempreatureData = 32.7;

    int roundedTempreature = Convert.ToInt32(tempreatureData);

    Console.WriteLine("Original Temperature (double): " +tempreatureData);
    Console.WriteLine("Rounded Tempreature (int): " +roundedTempreature);*/

     /* decimal pricePerItem = 250.50m;

    string quantityString = "4";

    int quantity = Convert.ToInt32(quantityString);

    decimal totalPrice = pricePerItem * quantity;

    Console.WriteLine("Price per item: " +pricePerItem);
    Console.WriteLine("Quantity entered: " +quantity);
    Console.WriteLine("Total price: " +totalPrice);*/



     /* string balanceString = "10500.75";

      decimal accountBalance = Convert.ToDecimal(balanceString);

      decimal interestRate = 0.05m;
      decimal interestAmount = accountBalance * interestRate;
      decimal newBalance = accountBalance *interestAmount;

      Console.WriteLine("Original Balance: "+accountBalance);
      Console.WriteLine("Interest Amount: " +interestAmount);
      Console.WriteLine("New Balance after interest: "+ newBalance);*/

     /* string userInput = "4500";

      int number = Convert.ToInt32(userInput);

      int result = number + 500;
      Console.WriteLine("Final Result: " + result);*/


     /*double price = 450.99;
     int castePrice = (int)price;

     int convertedPrice = Convert.ToInt32(price);

     Console.WriteLine("Using (int) casting: " + castePrice);
     Console.WriteLine("Using Convert.ToInt32: " + convertedPrice);*/

     /* char grade = 'A';
      int asciiValue = (int)grade;

      Console.WriteLine(asciiValue);*/
       /* decimal amount = 1234.56m;
        int paise = (int)amount;

        Console.WriteLine(paise);*/

       /* float temp = 36.7f;
        int displayTemp = (int)temp;

        Console.WriteLine(displayTemp);*/

        /*double marks = 89.67;
        int finalMarks = (int)marks;

        Console.WriteLine(finalMarks);*/

        /*double balance = 10500.75;
        int wholeRupees = (int)balance;

        Console.WriteLine("Balance stored  in database (whole rupees): "  +wholeRupees);*/

        /*double productPrice = 1999.99;
        int roundedPrice = (int)productPrice;

        Console.WriteLine("Rounded Price: " +roundedPrice);*/
    

//implicit example
/*class Program
{
    static void Main(string[]args)
    {

        float averageMarks = 85.5f;
        double finalResult = averageMarks;

        Console.WriteLine("Final Result: " +finalResult);

      /*  double monthlySalary = 50000;
        double yearlySalary = monthlySalary * 12;
        Console.WriteLine("Yearly Salary: " +yearlySalary);*/

       /* double bigValue = 9.78;
        int smallValue = (int)bigValue;
        Console.WriteLine(smallValue);*/

       /* int smallNumber = 10;
        double bigNumber = smallNumber;
        Console.WriteLine(bigNumber);*/

      /*  int smallCup =  100;
        double bigJug = smallCup;
        Console.WriteLine(bigJug);*/
       /*string orderID;

       orderID = "ORD12345";

       Console.WriteLine("Order ID: " +orderID);*/

       /*int library;

       library = 3500;

       Console.WriteLine("total books in library: " +library);*/

        /*int score;

        score = 120;

        Console.WriteLine("run scored by a batsman: " +score);*/


       /*double temperature;

       temperature = 32.5;

       Console.WriteLine("Today's temperature: " +temperature);*/

       /*int price;
        
        price = 250;

        Console.WriteLine("Ticket Price : " +price);*/

  /*int Math;
 
  Math = 92;

  Console.WriteLine("marks in Math subject: " +Math);*/


    /*double accountBalance;

    accountBalance = 10000;

    Console.WriteLine("customer's account balance: " +accountBalance);*/
    /*int items;

    items = 5;

    Console.WriteLine("number of itmes: "+items);*/


/*double monthSalary;

monthSalary = 45000;

Console.WriteLine("Employee Month's Salary: " +monthSalary);*/

       /* int age;

        age = 18;

        Console.WriteLine("Student Age: " +age);
    }
}*/

        
        /*for(int roll = 1; roll <= 50; roll++)
        {
            Console.WriteLine("Roll Number: "+ roll);
        }*/
        /*double totalBill = 0;

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Enter price of items {i}:");
            double price = Convert.ToDouble(Console.ReadLine());
            totalBill += price;
        }
        Console.WriteLine($"Total Bill = {totalBill}");*/
        /*int sum = 0;
        for(int i = 1; i <= 50; i+=2)
        {
            sum = sum + i;

        }
        Console.WriteLine("Sum of even numbers from 1 to 50 is: " +sum);*/
        /*for(char c = 'A'; c <= 'Z'; c++)
        {
            Console.WriteLine(c);
        }*/
       /* for(int i = 1; i <= 10; i ++)
        {
           Console.WriteLine("Square of " + i + " is: " +(i *i));
        }*/
       /* for(int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }*/
        /*int number = 5;
        int factorial = 1;

        for(int i = 1; i <= number; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial of " + number + "is: " + factorial);*/
        /*for(int i = 5; i <= 100; i += 5)
        {
            Console.WriteLine(i);
        }*/
      /*int sum = 0;
      for(int i = 1; i <= 100; i++)
        {
            sum = sum + i;
           
        }
        Console.WriteLine("Sum of numbers from 1 to 100:" + sum);*/
       /* for(int i = 1; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }*/
        /*for(int i = 2; i <= 20; i += 2)
        {
            Console.WriteLine(i);
        }*/
        /*for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }*/
      /*  for(int i = 1; i<= 5; i++)
        {
            Console.WriteLine(i);
        }*/
    