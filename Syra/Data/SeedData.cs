using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Syra.Models;

namespace Syra.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SyraContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SyraContext>>()))
            {
                var abercrombie = new User
                {
                    FirstName = "Kim",
                    LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11")
                };

                var fakhouri = new User
                {
                    FirstName = "Fadi",
                    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06")
                };

                var harui = new User
                {
                    FirstName = "Roger",
                    LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01")
                };

                var kapoor = new User
                {
                    FirstName = "Candace",
                    LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15")
                };

                var zheng = new User
                {
                    FirstName = "Roger",
                    LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12")
                };

                var english = new Department
                {
                    Name = "English",
                    Administrator = abercrombie
                };

                var mathematics = new Department
                {
                    Name = "Mathematics",
                    Administrator = fakhouri
                };

                var engineering = new Department
                {
                    Name = "Engineering",
                    Administrator = harui
                };

                var economics = new Department
                {
                    Name = "Economics",
                    Administrator = kapoor
                };

                var chemistry = new Resource
                {
                    Id = 1050,
                    nameResource = "Chemistry",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "eezr",
                    Department = engineering,
                    Users = new List<User> { kapoor, harui }
                };

                var microeconomics = new Resource
                {
                    Id = 4022,
                    nameResource = "Microeconomics",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "éezfzf",
                    Department = economics,
                    Users = new List<User> { zheng }
                };

                var macroeconmics = new Resource
                {
                    Id = 4041,
                    nameResource = "Macroeconomics",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "zeerze",
                    Department = economics,
                    Users = new List<User> { zheng }
                };

                var calculus = new Resource
                {
                    Id = 1045,
                    nameResource = "Calculus",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "erzez",
                    Department = mathematics,
                    Users = new List<User> { fakhouri }
                };

                var trigonometry = new Resource
                {
                    Id = 3141,
                    nameResource = "Trigonometry",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "zef",
                    Department = mathematics,
                    Users = new List<User> { harui }
                };

                var composition = new Resource
                {
                    Id = 2021,
                    nameResource = "Composition",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "zeffez",
                    Department = english,
                    Users = new List<User> { abercrombie }
                };

                var literature = new Resource
                {
                    Id = 2042,
                    nameResource = "Literature",
                    descriptionResource = "Chemzerzerzerze",
                    Links = "sgzg",
                    Department = english,
                    Users = new List<User> { abercrombie }
                };
                context.SaveChanges();
            }
        }
    }
}