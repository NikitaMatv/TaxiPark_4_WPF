﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaxiClientWpf.Components
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaxiDBEntities1 : DbContext
    {
        public TaxiDBEntities1()
            : base("name=TaxiDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Emplooy> Emplooy { get; set; }
        public virtual DbSet<OchenkaZaOrder> OchenkaZaOrder { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderForDriver> OrderForDriver { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Type> Type { get; set; }
    }
}
