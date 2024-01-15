using EFCoreCodeFirstDemoApp.Entities;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace EFCoreCodeFirstDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using var context = new EFCoreDbContext();
                var student = context.Students.FirstOrDefault(s => s.FirstName == "Yevgeni");
                if (student != null)
                {
                    Console.WriteLine(student.FirstName + student.LastName + student.Height);
                    context.Students.Remove(student);
                    Console.WriteLine("Student will be removed");
                    context.SaveChanges();
                    Console.WriteLine("student removed");
                  
                }
                else
                {
                    Console.WriteLine("Invalid Student ID : 1");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); ;
            }
             Console.ReadKey();
        }
    }
}