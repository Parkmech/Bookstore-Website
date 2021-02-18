//Parker Mecham, Section 1
//This page contains all the seed data to display on the web page

using System;
using System.Linq;
using System.Threading.Tasks;

using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


//All the books are created here
namespace BookStore.Models
{
    public class SeedData
    {
        //makes sure that the database is populated
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookStoreDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookStoreDBContext>();

            //If there are any pending migrations, makes them
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //If there isn't anything in the database, add these to it
            if(!context.Books.Any())
            {
                context.Books.AddRange(

                    new Book
                    {

                        Title = "Les Miserables",

                        AuthFirstName = "Victor",

                        AuthMiddleName = "",

                        AuthLastName = "Hugo",

                        Publisher = "Signet",

                        ISBN = "978-0451419439",

                        Classification = "Fiction",

                        Category = "Classic",

                        Price = 9.95F
                    },

                   new Book
                   {

                       Title = "Team of Rivals",

                       AuthFirstName = "Doris",

                       AuthMiddleName = "Kearns",

                       AuthLastName = "Goodwin",

                       Publisher = "Simon & Schuster",

                       ISBN = "978-0743270755",

                       Classification = "Non-Fiction",

                       Category = "Biography",

                       Price = 14.58F
                   },

                     new Book
                     {

                         Title = "The Snowball",

                         AuthFirstName = "Alice",

                         AuthMiddleName = "",

                         AuthLastName = "Schroeder",

                         Publisher = "Bantam",

                         ISBN = "978-0553384611",

                         Classification = "Non-Fiction",

                         Category = "Biography",

                         Price = 21.54F
                     },

                       new Book
                       {

                           Title = "American Ulysses",

                           AuthFirstName = "Ronald",

                           AuthMiddleName = "C.",

                           AuthLastName = "White",

                           Publisher = "Random House",

                           ISBN = "978-0812981254 ",

                           Classification = "Non-Fiction",

                           Category = "Biography",

                           Price = 11.61F
                       },

                         new Book
                         {

                             Title = "Unbroken",

                             AuthFirstName = "Laura",

                             AuthMiddleName = "",

                             AuthLastName = "Hillenbrand",

                             Publisher = "Random House",

                             ISBN = "978-0812974492",

                             Classification = "Non-Fiction",

                             Category = "Historical",

                             Price = 13.33F
                         },

                           new Book
                           {

                               Title = "The Great Train Robbery",

                               AuthFirstName = "Michael",

                               AuthMiddleName = "",

                               AuthLastName = "Crichton",

                               Publisher = "Vintage",

                               ISBN = "978-0804171281",

                               Classification = "Fiction",

                               Category = "Historical Fiction",

                               Price = 15.95F
                           },

                             new Book
                             {

                                 Title = "Deep Work",

                                 AuthFirstName = "Cal",

                                 AuthMiddleName = "",

                                 AuthLastName = "Newport",

                                 Publisher = "Grand Central Publishing",

                                 ISBN = "978-1455586691",

                                 Classification = "Non-Fiction",

                                 Category = "Self-Help",

                                 Price = 14.99F
                             },

                               new Book
                               {

                                   Title = "It's Your Ship",

                                   AuthFirstName = "Michael",

                                   AuthMiddleName = "",

                                   AuthLastName = "Abrashoff",

                                   Publisher = "Grand Central Publishing",

                                   ISBN = "978-1455523023",

                                   Classification = "Non-Fiction",

                                   Category = "Self-Help",

                                   Price = 21.66F
                               },

                                 new Book
                                 {

                                     Title = "The Virgin Way",

                                     AuthFirstName = "Richard",

                                     AuthMiddleName = "",

                                     AuthLastName = "Branson",

                                     Publisher = "Portfolio",

                                     ISBN = "978-1591847984",

                                     Classification = "Non-Fiction",

                                     Category = "Business",

                                     Price = 29.16F
                                 },

                                 new Book
                                 {

                                     Title = "Sycamore Row",

                                     AuthFirstName = "Josh",

                                     AuthMiddleName = "",

                                     AuthLastName = "Grisham",

                                     Publisher = "Bantam",

                                     ISBN = "978-0553393613",

                                     Classification = "Fiction",

                                     Category = "Thrillers",

                                     Price = 15.03F
                                 }

                ); 

                //Saves changes to the database
                context.SaveChanges();
            }
        }
    }
}

