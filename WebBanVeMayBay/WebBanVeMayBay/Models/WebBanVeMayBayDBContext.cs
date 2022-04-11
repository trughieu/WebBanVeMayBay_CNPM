using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebBanVeMayBay.Models
{
    public class WebBanVeMayBayDBContext:DbContext
    {
        public WebBanVeMayBayDBContext():base("name=ChuoiKN"){}
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Contact> Contacts { get; set; }
        //public DbSet<Menu> Menus { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<Post> Posts { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Slider> Sliders { get; set; }
        //public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WeekReport> WeekReport { get; set; }
        //public DbSet<MonthReport> MonthReport { get; set; }
        //public DbSet<PreReport> RevenueReport { get; set; }
        //public DbSet<YearReport> YearReport { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Complain> Complain { get; set; }
        public DbSet<Bill> Bill { get; set; }
    }
}