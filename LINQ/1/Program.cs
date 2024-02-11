using System;
using System.Collections.Generic;
using System.Linq;

public class Person
{
    public int PersonId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int RoleId { get; set; }
}

public class Role
{
    public int RoleId { get; set; }
    public string RoleDescription { get; set; }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public string Category { get; set; }
}

public class Customer
{
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public int CustomerId { get; set; }
}

public class OrderDetails
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        
        List<Person> people = new List<Person>
        {
            new Person { PersonId = 1, FirstName = "FirstName1", LastName = "LastName1", Age = 22, RoleId = 1 },
            new Person { PersonId = 2, FirstName = "FirstName2", LastName = "LastName2", Age = 19, RoleId = 2 },
            new Person { PersonId = 3, FirstName = "FirstName3", LastName = "LastName3", Age = 17, RoleId = 1 },
            new Person { PersonId = 4, FirstName = "FirstName4", LastName = "LastName4", Age = 24, RoleId = 2 },
            new Person { PersonId = 5, FirstName = "FirstName5", LastName = "LastName5", Age = 30, RoleId = 1 }
        };

        List<Role> roles = new List<Role>
        {
            new Role { RoleId = 1, RoleDescription = "Leader" },
            new Role { RoleId = 2, RoleDescription = "Manager" },
            new Role { RoleId = 3, RoleDescription = "Employee" },
            new Role { RoleId = 4, RoleDescription = "Intern" },
            new Role { RoleId = 5, RoleDescription = "Part-time" }
        };

        // LINQ operations on Person and Role
        var adults = people.Where(p => p.Age > 18).ToList();
        var names = people.Select(p => p.FirstName + " " + p.LastName).ToList();
        var role1People = people.Where(p => p.RoleId == 1).ToList();
        var twoYoungest = people.OrderBy(p => p.Age).Take(2).ToList();
        var allButTwoYoungest = people.OrderBy(p => p.Age).Skip(2).ToList();
        
        foreach (var person in adults)
            Console.WriteLine($"{person.FirstName} {person.LastName} is an adult.");

    }
}
