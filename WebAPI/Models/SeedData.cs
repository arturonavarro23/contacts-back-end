using System;
using WebAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace WebAPI.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContextAPI(
                serviceProvider.GetRequiredService<DbContextOptions<ContextAPI>>()))
            {
                SetPersons(context);
            }
        }

        static void SetPersons(ContextAPI context)
        {
            if (context.Person.Any())
            {
                return;   // DB has been seeded
            }

            context.Person.AddRange(
                 new Person
                 {
                    FirstName = "Arturo",
                    LastName = "Navarro",
                    Birthdate = DateTime.Parse("1990-5-23"),
                    Gender = "M",
                    Phone = "9982334455",
                    Email = "arturo@gmail.com",
                    Address = "Arturo's Address",
                    City = "Arturo's City"
                },
                new Person
                {
                    FirstName = "Mary",
                    LastName = "Camacho",
                    Birthdate = DateTime.Parse("1989-5-31"),
                    Gender = "F",
                    Phone = "9982334456",
                    Email = "mary@gmail.com",
                    Address = "Mary's Address",
                    City = "Mary's City"
                },
                new Person
                {
                    FirstName = "Person 3",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1996-1-11"),
                    Gender = "M",
                    Phone = "9982334457",
                    Email = "person3@gmail.com",
                    Address = "Person3's Address",
                    City = "Person3's City"
                },
                new Person
                {
                    FirstName = "Person 4",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("2013-1-11"),
                    Gender = "M",
                    Phone = "9982334458",
                    Email = "person4@gmail.com",
                    Address = "Person4's Address",
                    City = "Person4's City"
                },
                new Person
                {
                    FirstName = "Person 5",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("2000-1-11"),
                    Gender = "M",
                    Phone = "9982334459",
                    Email = "person5@gmail.com",
                    Address = "Person5's Address",
                    City = "Person5's City"
                },
                new Person
                {
                    FirstName = "Person 6",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1950-1-11"),
                    Gender = "M",
                    Phone = "9982334451",
                    Email = "person6@gmail.com",
                    Address = "Person6's Address",
                    City = "Person6's City"
                },
                new Person
                {
                    FirstName = "Person 7",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1970-1-22"),
                    Gender = "M",
                    Phone = "9982334452",
                    Email = "person7@gmail.com",
                    Address = "Person7's Address",
                    City = "Person7's City"
                },
                new Person
                {
                    FirstName = "Person 8",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1960-10-11"),
                    Gender = "M",
                    Phone = "9982334453",
                    Email = "person8@gmail.com",
                    Address = "Person8's Address",
                    City = "Person8's City"
                },
                new Person
                {
                    FirstName = "Person 9",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1989-12-11"),
                    Gender = "M",
                    Phone = "9982334454",
                    Email = "person9@gmail.com",
                    Address = "Person9's Address",
                    City = "Person9's City"
                },
                new Person
                {
                    FirstName = "Person 10",
                    LastName = "Last Name",
                    Birthdate = DateTime.Parse("1989-1-11"),
                    Gender = "M",
                    Phone = "9982334466",
                    Email = "person10@gmail.com",
                    Address = "Person10's Address",
                    City = "Person10's City"
                }
            );

            context.SaveChanges();
        }
    }
}
