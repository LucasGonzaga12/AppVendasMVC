using SalesWebMVC.Models;
using System.Linq;
using System;
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
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return; //DB já existe
            }
            Department d1 = new Department(1, "Computadores");
            Department d2 = new Department(2, "Eletronicos");
            Department d3 = new Department(3, "Roupas");
            Department d4 = new Department(4, "Livros");

            Seller s1 = new Seller(1, "Paulo", "paulo@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", new DateTime(2000, 5, 15), 850.0, d2);
            Seller s3 = new Seller(3, "Eduardo", "eduardo@gmail.com", new DateTime(1995, 8, 16), 1300.0, d1);
            Seller s4 = new Seller(4, "Ricardo", "ricardo@gmail.com", new DateTime(1993, 4, 13), 1150.0, d4);
            Seller s5 = new Seller(5, "Rosana", "rosana@gmail.com", new DateTime(1996, 6, 28), 950.0, d3);
            Seller s6 = new Seller(6, "Alana", "alana@gmail.com", new DateTime(1994, 10, 22), 1200.0, d2);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 25), 1100.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 01, 26), 100.0, SalesStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 06, 27), 1200.0, SalesStatus.Billed, s3);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 03, 28), 1300.0, SalesStatus.Billed, s4);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 04, 29), 1400.0, SalesStatus.Billed, s5);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 05, 10), 1500.0, SalesStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 11), 1600.0, SalesStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2018, 09, 12), 1800.0, SalesStatus.Billed, s2);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2018, 06, 05), 1700.0, SalesStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2019, 07, 06), 100.0, SalesStatus.Billed, s4);
            SalesRecord r11 = new SalesRecord(11, new DateTime(2019, 08, 17), 1500.0, SalesStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, new DateTime(2019, 09, 15), 2100.0, SalesStatus.Billed, s6);
            SalesRecord r13 = new SalesRecord(13, new DateTime(2019, 10, 16), 3100.0, SalesStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, new DateTime(2019, 11, 11), 4100.0, SalesStatus.Billed, s2);
            SalesRecord r15 = new SalesRecord(15, new DateTime(2019, 12, 12), 5100.0, SalesStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, new DateTime(2019, 12, 25), 6100.0, SalesStatus.Billed, s4);
            SalesRecord r17 = new SalesRecord(17, new DateTime(2019, 12, 25), 8100.0, SalesStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, new DateTime(2019, 11, 04), 9100.0, SalesStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, new DateTime(2019, 05, 05), 1100.0, SalesStatus.Billed, s1);
            SalesRecord r20 = new SalesRecord(20, new DateTime(2020, 06, 08), 1000.0, SalesStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, new DateTime(2020, 07, 09), 1000.0, SalesStatus.Billed, s3);
            SalesRecord r22 = new SalesRecord(22, new DateTime(2020, 08, 10), 1600.0, SalesStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, new DateTime(2020, 09, 11), 1500.0, SalesStatus.Billed, s5);
            SalesRecord r24 = new SalesRecord(24, new DateTime(2020, 09, 12), 1800.0, SalesStatus.Billed, s6);
            SalesRecord r25 = new SalesRecord(25, new DateTime(2020, 10, 13), 1700.0, SalesStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, new DateTime(2020, 11, 15), 1400.0, SalesStatus.Billed, s2);
            SalesRecord r27 = new SalesRecord(27, new DateTime(2020, 07, 16), 1600.0, SalesStatus.Billed, s3);
            SalesRecord r28 = new SalesRecord(28, new DateTime(2020, 08, 19), 1500.0, SalesStatus.Billed, s4);
            SalesRecord r29 = new SalesRecord(29, new DateTime(2020, 08, 21), 1800.0, SalesStatus.Billed, s5);
            SalesRecord r30 = new SalesRecord(30, new DateTime(2020, 07, 20), 1900.0, SalesStatus.Billed, s6);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, 
                r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            
            _context.SaveChanges();
        }
    }
}
