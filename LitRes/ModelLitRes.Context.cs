﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LitRes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LitResEntities : DbContext
    {
        public LitResEntities()
            : base("name=LitResEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BookSet> BookSet { get; set; }
        public virtual DbSet<ClientSet> ClientSet { get; set; }
        public virtual DbSet<OrderSet> OrderSet { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
