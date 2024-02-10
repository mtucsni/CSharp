using System;
using System.Collections.Generic;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeFirstName { get; set; }
    public string EmployeeLastName { get; set; }
    public int EmployeeAge { get; set; }

    public Employee(int id, string firstName, string lastName, int age)
    {
        EmployeeId = id;
        EmployeeFirstName = firstName;
        EmployeeLastName = lastName;
        EmployeeAge = age;
    }

    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {EmployeeFirstName} {EmployeeLastName}, Age: {EmployeeAge}";
    }
}

class Program
{
    static void Main()
    {
        // Demonstration of Swap Utility
        int a = 2, b = 3;
        Console.WriteLine($"Before swap: a={a}, b={b}");
        SwapUtility.Swap(ref a, ref b);
        Console.WriteLine($"After swap: a={a}, b={b}");

        // Employee List Operations
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee(1, "John", "Doe", 30));
        employees.Add(new Employee(2, "Jane", "Smith", 25));

        // Display Employees
        Console.WriteLine("\nEmployees:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }

        // Remove an Employee
        employees.RemoveAt(0);  // Removes the first employee

        // Display Employees After Removal
        Console.WriteLine("\nEmployees after removal:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}
public static class SwapUtility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
