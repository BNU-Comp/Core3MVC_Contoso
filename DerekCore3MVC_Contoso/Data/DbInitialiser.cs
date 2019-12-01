﻿using DerekCore3MVC_Contoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerekCore3MVC_Contoso.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            InitialiseAddresses(context);
            InitialiseCustomers(context);
        }

        private static void InitialiseAddresses(ApplicationDbContext context)
        {
            if(context.Addresses.Any())
            {
                return;
            }
            var addresses = new Address[]
            {
                new Address
                {
                    HouseNumber = "38",
                    Street = "High Street",
                    Town = "Kings Langley",
                    County = "Herts",
                    PostCode = "WD4 7ET"
                },
                new Address
                {
                    HouseNumber = "23",
                    Street = "Bushy Street",
                    Town = "Watford",
                    County = "Herts",
                    PostCode = "WD1 3PO"
                },
                new Address
                {
                    HouseNumber = "3",
                    Street = "Travis Road",
                    Town = "St Albans",
                    County = "Herts",
                    PostCode = "AL4 6GF"
                }
            };

            foreach(Address a in addresses)
            {
                context.Addresses.Add(a);
            }

            context.SaveChanges();
        }

        private static void InitialiseCustomers(ApplicationDbContext context)
        {
            if (context.Customers.Any())
            {
                return;
            }
            var customers = new Customer[]
            {
                new Customer
                {
                    AddressID = 1,
                    FirstName = "Alex",
                    LastName = "Carson",
                    EmailAddress = "Alex@gmail.com",
                    TelephoneNo = "07123 456 789",
                },
                new Customer
                {
                    AddressID = 2,
                    FirstName = "Meridith",
                    LastName = "Alonso",
                    EmailAddress = "meridith@gmail.com",
                    TelephoneNo = "07123 456 789",
                },
                                new Customer
                {
                    AddressID = 3,
                    FirstName = "Arturo",
                    LastName = "Anand",
                    EmailAddress = "Arturo@gmail.com",
                    TelephoneNo = "07123 456 789",
                }


            };

            foreach (Customer c in customers)
            {
                context.Customers.Add(c);
            }

            context.SaveChanges();

        }
    }
}
