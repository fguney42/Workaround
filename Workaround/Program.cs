using Business.Concrete;
using Entities.Concrete;
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Id = 1;
        person.FirstName = "FURKAN TALHA";
        person.LastName = "GÜNEY";
        person.DateofBirthYear = 1;
        person.NationalIdentity = 12345678901;
        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person);

    }
    private static void initializationOfVariables()
    {
        string message = "Hello";
        double price = 100000;
        int number = 100;
        bool isAuthenticate = false;
        string firstName = "FURKAN TALHA";
        string lastName = "GÜNEY";
        long nationalIdentity = 12345678901;
        Console.WriteLine(price * 1.18);
        Console.WriteLine(price * 1.18);
    }
}