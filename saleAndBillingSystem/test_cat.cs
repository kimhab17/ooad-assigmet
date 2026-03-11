using System;
using System.Data;

namespace saleAndBillingSystem
{
    class Program2
    {
        static void Main(string[] args)
        {
            try {
                var repo = new CategoryRepository();
                var dt = repo.GetAllCategories();
                Console.WriteLine($"Found {dt.Rows.Count} categories");
            } catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
