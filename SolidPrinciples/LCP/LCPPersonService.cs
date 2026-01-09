using System;

public class LSPPersonService
{


    public class Person
    {

        public virtual void SendEmail()
        {
            Console.WriteLine("Sending email to a person...");
        }

    }


    public class Employee : Person
    {
        public virtual void PaySalary()
        {
            Console.WriteLine("Paying salary to an employee...");
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending email to an employee...");
        }
    }

    public class Manager : Employee
    {
        public override void PaySalary()
        {
            Console.WriteLine("Paying salary to a manager...");
        }

        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a manager...");
        }
    }

    public class Student : Person
    {


        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a student...");
        }
    }

    public class User : Person
    {
        public override void SendEmail()
        {
            Console.WriteLine("Sending email to a User...");
        }
    }



    public static void ExecuteClass()
    {
        Employee person1 = new Employee();
        person1.PaySalary();   
        person1.SendEmail();   

        Manager person2 = new Manager();
        person2.PaySalary();  
        person2.SendEmail();   

        Person person3 = new Student();
        person3.SendEmail();   

        Person person4 = new User();
        person4.SendEmail();   




        Console.ReadKey();
    }
}