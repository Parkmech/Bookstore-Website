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

                        NumPages = 1488,

                        Publisher = "Signet",

                        ISBN = "978-0451419439",

                        Classification = "Fiction",

                        Category = "Classic",

                        Price = 9.95F,

                        Image = "~/img/LesMiserables.jpg",

                        PurchaseUrl = "https://www.amazon.com/Miserables-Signet-Classics-Victor-Hugo/dp/045141943X/ref=sr_1_3?crid=3I7D5R3HCKV6G&dchild=1&keywords=les+miserables+book&qid=1614202395&sprefix=les+miserables%2Caps%2C251&sr=8-3"
                    },

                   new Book
                   {

                       Title = "Team of Rivals",

                       AuthFirstName = "Doris",

                       AuthMiddleName = "Kearns",

                       AuthLastName = "Goodwin",

                       NumPages = 944,

                       Publisher = "Simon & Schuster",

                       ISBN = "978-0743270755",

                       Classification = "Non-Fiction",

                       Category = "Biography",

                       Price = 14.58F,

                       Image = "~/img/TeamOfRivals.jpg",

                       PurchaseUrl = "https://www.amazon.com/Team-Rivals-Political-Abraham-Lincoln/dp/0743270754/ref=sr_1_1?dchild=1&keywords=team+of+rivals&qid=1614202440&sr=8-1"
                   },

                     new Book
                     {

                         Title = "The Snowball",

                         AuthFirstName = "Alice",

                         AuthMiddleName = "",

                         AuthLastName = "Schroeder",

                         NumPages = 832,

                         Publisher = "Bantam",

                         ISBN = "978-0553384611",

                         Classification = "Non-Fiction",

                         Category = "Biography",

                         Price = 21.54F,

                         Image = "~/img/TheSnowball.jpg",

                         PurchaseUrl = "https://www.amazon.com/Snowball-Warren-Buffett-Business-Life/dp/0553384619/ref=sr_1_1?dchild=1&keywords=The+snowball+book&qid=1614202473&sr=8-1"

                     },

                       new Book
                       {

                           Title = "American Ulysses",

                           AuthFirstName = "Ronald",

                           AuthMiddleName = "C.",

                           AuthLastName = "White",

                           NumPages = 864,

                           Publisher = "Random House",

                           ISBN = "978-0812981254 ",

                           Classification = "Non-Fiction",

                           Category = "Biography",

                           Price = 11.61F,

                           Image = "~/img/AmericanUlysses.jpg",

                           PurchaseUrl = "https://www.amazon.com/American-Ulysses-Life-S-Grant/dp/1400069025/ref=sr_1_1?dchild=1&keywords=American+Ulysses&qid=1614202498&sr=8-1"

                       },

                         new Book
                         {

                             Title = "Unbroken",

                             AuthFirstName = "Laura",

                             AuthMiddleName = "",

                             AuthLastName = "Hillenbrand",

                             NumPages = 528,

                             Publisher = "Random House",

                             ISBN = "978-0812974492",

                             Classification = "Non-Fiction",

                             Category = "Historical",

                             Price = 13.33F,

                             Image = "~/img/Unbroken.jpg",

                             PurchaseUrl = "https://www.amazon.com/Unbroken-World-Survival-Resilience-Redemption/dp/0812974492/ref=sr_1_2?dchild=1&keywords=unbroken+book&qid=1614202553&sr=8-2"
                         },

                           new Book
                           {

                               Title = "The Great Train Robbery",

                               AuthFirstName = "Michael",

                               AuthMiddleName = "",

                               AuthLastName = "Crichton",

                               NumPages = 288,

                               Publisher = "Vintage",

                               ISBN = "978-0804171281",

                               Classification = "Fiction",

                               Category = "Historical Fiction",

                               Price = 15.95F,

                               Image = "~/img/TheGreatTrainRobbery.jpg",

                               PurchaseUrl = "https://www.amazon.com/Great-Train-Robbery-Michael-Crichton/dp/0804171289/ref=sr_1_1?dchild=1&keywords=the+great+train+robbery+book&qid=1614202581&sr=8-1"
                           },

                             new Book
                             {

                                 Title = "Deep Work",

                                 AuthFirstName = "Cal",

                                 AuthMiddleName = "",

                                 AuthLastName = "Newport",

                                 NumPages = 304,

                                 Publisher = "Grand Central Publishing",

                                 ISBN = "978-1455586691",

                                 Classification = "Non-Fiction",

                                 Category = "Self-Help",

                                 Price = 14.99F,

                                 Image = "~/img/DeepWork.jpg",

                                 PurchaseUrl = "https://www.amazon.com/Deep-Work-Focused-Success-Distracted/dp/1455586692/ref=sr_1_1?dchild=1&keywords=deep+work&qid=1614202622&sr=8-1"
                             },

                               new Book
                               {

                                   Title = "It's Your Ship",

                                   AuthFirstName = "Michael",

                                   AuthMiddleName = "",

                                   AuthLastName = "Abrashoff",

                                   NumPages = 240,

                                   Publisher = "Grand Central Publishing",

                                   ISBN = "978-1455523023",

                                   Classification = "Non-Fiction",

                                   Category = "Self-Help",

                                   Price = 21.66F,

                                   Image = "~/img/ItsYourShip.jpg",

                                   PurchaseUrl = "https://www.amazon.com/Its-Your-Ship-Management-Anniversary/dp/145552302X/ref=sr_1_1?dchild=1&keywords=It%27s+your+ship&qid=1614202681&sr=8-1"
                               },

                                 new Book
                                 {

                                     Title = "The Virgin Way",

                                     AuthFirstName = "Richard",

                                     AuthMiddleName = "",

                                     AuthLastName = "Branson",

                                     NumPages = 400,

                                     Publisher = "Portfolio",

                                     ISBN = "978-1591847984",

                                     Classification = "Non-Fiction",

                                     Category = "Business",

                                     Price = 29.16F,

                                     Image = "~/img/TheVirginWay.jpg",

                                     PurchaseUrl = "https://www.amazon.com/Virgin-Way-Its-Worth-Doing/dp/1591847982/ref=sr_1_1?dchild=1&keywords=The+virgin+way&qid=1614202712&sr=8-1"
                                 },

                                 new Book
                                 {

                                     Title = "Sycamore Row",

                                     AuthFirstName = "Josh",

                                     AuthMiddleName = "",

                                     AuthLastName = "Grisham",

                                     NumPages = 642,

                                     Publisher = "Bantam",

                                     ISBN = "978-0553393613",

                                     Classification = "Fiction",

                                     Category = "Thrillers",

                                     Price = 15.03F,

                                     Image = "~/img/SycamoreRow.jpg",

                                     PurchaseUrl = "https://www.amazon.com/Sycamore-Jake-Brigance-John-Grisham/dp/0345543246/ref=sr_1_1?dchild=1&keywords=Sycamore+row&qid=1614202738&sr=8-1"
                                 },
                                 new Book
                                 {

                                     Title = "The Great Gatsby",

                                     AuthFirstName = "Scott",

                                     AuthMiddleName = "F.",

                                     AuthLastName = "Fitzgerald",

                                     NumPages = 180,

                                     Publisher = "Scribner Book Company",

                                     ISBN = "978-0333791035",

                                     Classification = "Fiction",

                                     Category = "Classic",

                                     Price = 6.99F,

                                     Image = "~/img/GreatGatsby.jpg",

                                     PurchaseUrl = "https://www.amazon.com/Great-Gatsby-F-Scott-Fitzgerald/dp/1982149485/ref=sr_1_9?dchild=1&gclid=Cj0KCQiAj9iBBhCJARIsAE9qRtB6ZqB8EEXSCF2k4I2T7S-6p9_YmVabmWfJCfY_9gFnhckq0GkgkCAaAgL9EALw_wcB&hvadid=417360796267&hvdev=c&hvlocphy=1026980&hvnetw=g&hvqmt=e&hvrand=9295991224635249330&hvtargid=kwd-532479639294&hydadcr=7495_9612500&keywords=great+gatsby+amazon&qid=1614203514&sr=8-9&tag=googhydr-20"
                                 },

                                 new Book
                                 {

                                     Title = "The Book of Mormon",

                                     AuthFirstName = "Joseph",

                                     AuthMiddleName = "",

                                     AuthLastName = "Smith Jr",

                                     NumPages = 238,

                                     Publisher = "The Church of Jesus Christ of Latter Day Saints",

                                     ISBN = "978-1537696775",

                                     Classification = "Historical",

                                     Category = "Religion",

                                     Price = 3.11F,

                                     Image = "~/img/BookOfMormon.png",

                                     PurchaseUrl = "https://ldsbookstore.com/book-of-mormon-softcover"

                                 },

                                 new Book
                                 {

                                     Title = "Harry Potter and the Deathly Hallows",

                                     AuthFirstName = "J.K.",

                                     AuthMiddleName = "",

                                     AuthLastName = "Rowling",

                                     NumPages = 607,

                                     Publisher = "Bloomsbury Publishing",

                                     ISBN = "978-9654826358",

                                     Classification = "Fiction",

                                     Category = "Fantasy",

                                     Price = 10.49F,

                                     Image = "~/img/HarryPotter.jpg",

                                     PurchaseUrl = "https://www.amazon.com/Harry-Potter-Deathly-Hallows-Book/dp/0545139708/ref=sr_1_1?crid=2E4EH4W7G5SN9&dchild=1&keywords=harry+potter+and+the+deathly+hallows&qid=1614202221&sprefix=harry+potter+and+the+deathly%2Caps%2C234&sr=8-1"
                                 }
                ) ; 

                //Saves changes to the database
                context.SaveChanges();
            }
        }
    }
}

