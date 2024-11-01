using Demo.Contexts;

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

            using (AppDbContext context = new AppDbContext()) ;
            //using this method makes sure db connection is closed after the block
            

            #endregion
        }
    }
}
