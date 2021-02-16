using EFCoreTutoriaslFirstApp.DAL;
using EFCoreTutoriaslFirstApp.Models;
using System;

namespace EFCoreTutoriaslFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill Sampson"
                };

                context.Student.Add(std);
                context.SaveChanges();
            }
            
        }
    }
}
