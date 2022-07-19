using Microsoft.EntityFrameworkCore;
using OrderApp.DAL;
using OrderApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Data
{
    class DbInitializer
    {
        //private readonly OrderAppContext _db;

        //public DbInitializer(OrderAppContext db)
        //{
        //    _db = db;
        //}

        //public async Task InitializeAsync()
        //{
        //    await _db.Database.MigrateAsync();

        //    Computer computer1 = new Computer { Id = 1, Model = $"Z4", RAM = 8, ROM = 500, Graphics = $"RTX3060", Processor = $"R7 3700X", Price = 200000, Count = 20 };
        //    Computer computer2 = new Computer { Id = 2, Model = $"FX67", RAM = 16, ROM = 1000, Graphics = $"RTX2080", Processor = $"i9 9990k", Price = 250000, Count = 10 };
        //    Computer computer3 = new Computer { Id = 3, Model = $"L76", RAM = 32, ROM = 2000, Processor = $"i9 9990k", Price = 150000, Count = 5 };
        //    await _db.Computers.AddRangeAsync(new List<Computer> { computer1, computer2, computer3 });

        //    Notebook notebook1 = new Notebook { Id = 1, Model = $"MacBook", RAM = 8, ROM = 250, Processor = $"M1", Camera = 1, Price = 80000, Count = 50 };
        //    Notebook notebook2 = new Notebook { Id = 2, Model = $"VivoBook", RAM = 4, ROM = 250, Processor = $"i9 9990k", Camera = 0.3, Price = 100000, Count = 20 };
        //    Notebook notebook3 = new Notebook { Id = 3, Model = $"Leopard", RAM = 8, ROM = 500, Graphics = $"GTX 1660Ti", Processor = $"i5 10300H", Camera = 0.9, Price = 150000, Count = 5 };
        //    await _db.Notebooks.AddRangeAsync(new List<Notebook> { notebook1, notebook2, notebook3 });

        //    Phone phone1 = new Phone { Id = 1, Model = $"iPhone 11", RAM = 4, ROM = 64, Camera = 12, Screen = 6.1, Battery = 3100, Price = 45000, Count = 60 };
        //    Phone phone2 = new Phone { Id = 2, Model = $"POCO M3", RAM = 4, ROM = 128, Camera = 48, Screen = 6.5, Battery = 6000, Price = 15000, Count = 70 };
        //    Phone phone3 = new Phone { Id = 3, Model = $"Galaxy A12", RAM = 4, ROM = 64, Camera = 48, Screen = 6.5, Battery = 5000, Price = 130000, Count = 50 };
        //    await _db.Phones.AddRangeAsync(new List<Phone> { phone1, phone2, phone3 });

        //    Order order1 = new Order { Id = 1, Surname = $"Иванов", Date = DateTime.Now, Sum = computer1.Price + notebook1.Price + phone1.Price };
        //    Order order2 = new Order { Id = 2, Surname = $"Петров", Date = DateTime.Now, Sum = computer2.Price + notebook2.Price + phone2.Price };
        //    Order order3 = new Order { Id = 3, Surname = $"Тимохин", Date = DateTime.Now, Sum = computer3.Price + notebook3.Price + phone3.Price };
        //    List<Order> orders = new List<Order> { order1, order2, order3 };
        //    order1.Computers.Add(computer1);
        //    order1.Notebooks.Add(notebook1);
        //    order1.Phones.Add(phone1);
        //    order2.Computers.Add(computer2);
        //    order2.Notebooks.Add(notebook2);
        //    order2.Phones.Add(phone2);
        //    order3.Computers.Add(computer3);
        //    order3.Notebooks.Add(notebook3);
        //    order3.Phones.Add(phone3);
        //    await _db.Orders.AddRangeAsync(orders);

        //    await _db.SaveChangesAsync();
        //}
    }
}
