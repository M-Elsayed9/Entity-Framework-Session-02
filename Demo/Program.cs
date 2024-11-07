﻿using Demo.Contexts;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Revision
            // EF Core: ORM (Object Relational Mapping) in .NET Core

            // 1. Mapping:
            //      Code First
            //      Database First

            // 2. L2E (LINQ to EntityFramework) C# LINQ -> EF Core --> SQL

            // 3 ways to generate 
            //  1. TPC (Table Per Class) - 1 table for each class
            //  2. TPH (Table Per Hierarchy) - 1 table for all classes
            //  3. TPCC (Table Per Concrete Class) - 1 table for each concerete class

            #endregion

            #region CRUD Operations

            // CRUD Operations
            // 1. Create
            // 2. Read
            // 3. Update
            // 4. Delete

            //AppDbContext context = new AppDbContext();

            //try
            //{
            //}
            //finally
            //{
            //    context.Dispose(); // Close the connection with the database
            //}

            using AppDbContext context = new AppDbContext();
            //using this method makes sure db connection is closed after the block

            // Create
            var employee = new Employee()
            {
                Name = "Mohamed",
                Age = 30,
                Salary = 10000,
                Address = "Cairo"
            };



            //Console.WriteLine(context.Entry(employee).State); // Detached
            //// detached means the object is not tracked by the context

            //context.Employees.Add(employee);

            //Console.WriteLine(context.Entry(employee).State); // added
            //// added means the object is tracked by the context and will be added to the database

            //Console.WriteLine(context.SaveChanges());

            //Console.WriteLine(context.Entry(employee).State); // Unchanged
            //// unchanged means the object is tracked by the context and no changes have been made

            //employee.Name = "Omar";

            //Console.WriteLine(context.Entry(employee).State); // Modified
            //// modified means the object is tracked by the context and changes have been made
            
            //Console.WriteLine(context.Entry(employee).State); // Detached
            
            //context.Entry(employee).State = EntityState.Added; 

            //Console.WriteLine(context.Entry(employee).State); // added

            //context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State); // Unchanged

            #endregion


        }
    }
}
