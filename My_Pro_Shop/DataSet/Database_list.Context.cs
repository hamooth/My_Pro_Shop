﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace My_Pro_Shop.DataSet
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class shop_firstEntities : DbContext
    {
        public shop_firstEntities()
            : base("name=shop_firstEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category_create_Table> Category_create_Table { get; set; }
        public virtual DbSet<Login_Table> Login_Table { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table_Worker_Register> Table_Worker_Register { get; set; }

        internal class DataSet
        {
            internal class Category_create_Table
            {
                public Category_create_Table()
                {
                }

                public string Category_Name { get; set; }
               
            }

            internal class Table_Worker_Register
            {
                public Table_Worker_Register()
                {
                }

                public string Woker_ID { get; set; }
                public string First_Name { get; set; }
                public string Last_Name { get; set; }
                public DateTime DOB { get; set; }
                public string Gender { get; set; }
                public int Phone_Number { get; set; }
                public string NIC { get; set; }
                public string Address { get; set; }
                public string State { get; set; }
                public string City { get; set; }
                public string Email { get; set; }
                public string Qualification { get; set; }
                public string Extra_Skills { get; set; }
                public byte[] Picture { get; set; }
            }

            internal class Login_Table
            {
                public Login_Table()
                {
                }

                public string loginrole { get; set; }
                public string Username { get; set; }
                public string Password { get; set; }
            }
        }
    }
}
