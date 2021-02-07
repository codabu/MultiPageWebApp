using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiPageWebApp.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext (DbContextOptions<ContactContext> options)
            :base(options)
        { }
        
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                    new Contact
                    {
                        ContactId = 1,
                        Name = "Bob Dylan",
                        Number = "5154462487",
                        Address = "65 Lake St, Urbandale IA, 50256",
                        Note = "Concert"
                    },
                    new Contact
                    {
                        ContactId = 2,
                        Name = "Jon Rogers",
                        Number = "5154569577",
                        Address =  "523 Fake St, Johnston IA, 50263",
                        Note = "Plumber"
                    },
                    new Contact
                    {
                        ContactId = 3,
                        Name = "Jake Bransgrove",
                        Number = "5157784255",
                        Address = "102 Jutland Ave, Clive IA, 50325",
                        Note = "WBHS"
                    },
                    new Contact
                    {
                        ContactId = 4,
                        Name = "Grant Buchanan",
                        Number = "6634552258",
                        Address = "99 Island Road, Adel IA, 50893",
                        Note = "Best bud"
                    },
                    new Contact
                    {
                        ContactId = 5,
                        Name = "Dad",
                        Number = "5622458855",
                        Address = "72 Lakeside Road, Ankeny IA, 50882",
                        Note = ""
                    },
                    new Contact
                    {
                        ContactId = 6,
                        Name = "Mum",
                        Number = "5625682253",
                        Address = "122 NW 80th, Urbandale IA, 50332",
                        Note = ""
                    },
                    new Contact
                    {
                        ContactId = 7,
                        Name = "Abby",
                        Number = "5159793742",
                        Address = "1660 NW 75th St, Clive IA 50325",
                        Note = "Fiancee"
                    }
                ); ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:mpwa.database.windows.net,1433;Initial Catalog=CIS174;Persist Security Info=False;User ID=codabu;Password=Self@ware7&;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
