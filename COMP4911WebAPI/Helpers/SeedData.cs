using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COMP4911WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP4911WebAPI.Helpers
{
    public static class SeedData 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] salt1 = PasswordHasher.GenerateSalt();
            string hashedPass1 = PasswordHasher.HashPassword("password", salt1);
            byte[] salt2 = PasswordHasher.GenerateSalt();
            string hashedPass2 = PasswordHasher.HashPassword("defaultpassword", salt2);

            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, 1, "AdminFirstName", "AdminLastName", 1, 1, 
                    true, true, true, true),
                new Employee(2, 2, "Perry", "Li", 1, 1,
                true, true, false, false));
            modelBuilder.Entity<JobTitle>().HasData(
                new JobTitle(1, "Software Developer"),
                new JobTitle(2, "Q/A Analyst"),
                new JobTitle(3, "Business Analyst"));
            modelBuilder.Entity<Credential>().HasData(
                new Credential("A100001", hashedPass1, 1, salt1),
                new Credential("A100002", hashedPass2, 2, salt2));
        }
    }
}
