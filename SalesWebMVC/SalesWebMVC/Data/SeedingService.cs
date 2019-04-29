using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalerRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "John Lennon", "lennon@gmail", new DateTime(1990, 4, 03), 1200.0, d1);
            Seller s2 = new Seller(2, "Bob Blue", "blue@gmail", new DateTime(1979, 1, 22), 1600.0, d2);
            Seller s3 = new Seller(3, "Anna Pink", "pink@gmail", new DateTime(1984, 8, 13), 2500.0, d2);
            Seller s4 = new Seller(4, "Donald Yellow", "yellow@gmail", new DateTime(1989, 6, 15), 1600.0, d4);
            Seller s5 = new Seller(5, "Walter White", "white@gmail", new DateTime(1985, 12, 18), 3000.0, d1);
            Seller s6 = new Seller(6, "Jessy Pinkman", "pinkman@gmail", new DateTime(1983, 1, 08), 1800.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2019, 04, 15), 10000.0, SaleStatus.Billed, s5);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2019, 04, 4), 9000.0, SaleStatus.Billed, s4);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2019, 04, 13), 8500.0, SaleStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2019, 04, 1), 8000.0, SaleStatus.Billed, s3);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2019, 04, 21), 7500.0, SaleStatus.Billed, s4);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2019, 04, 15), 7000.0, SaleStatus.Billed, s2);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2019, 04, 28), 6500.0, SaleStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2019, 04, 11), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2019, 04, 7), 5500.0, SaleStatus.Billed, s1);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 04, 13), 5000.0, SaleStatus.Billed, s5);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 04, 12), 4500.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 04, 29), 4000.0, SaleStatus.Billed, s4);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 04, 4), 3500.0, SaleStatus.Billed, s3);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 04, 1), 3000.0, SaleStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 04, 8), 10000.0, SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _context.SalerRecord.AddRange(
                r1,r2,r3,r4,r5,r6,r7,
                r8,r9,r10,r11,r12,r13,r14,r15             
            );

            _context.SaveChanges();
        }
    }
}

