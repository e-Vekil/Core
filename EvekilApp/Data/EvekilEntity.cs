using EvekilApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvekilApp.Data
{
    public class EvekilEntity:IdentityDbContext<User>
    {
        public EvekilEntity(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public virtual DbSet<Advocate> Advocates { get; set; }
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<CategoryLanguage> CategoryLanguages { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Connect> Connects { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentLanguage> DocumentLanguages { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PaymentDocument> PaymentDocuments { get; set; }
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyLanguage> PropertyLanguages { get; set; }
        public virtual DbSet<PropertySubcategory> PropertySubcategories { get; set; }
        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
        public virtual DbSet<PurchasedDocument> PurchasedDocuments { get; set; }
        public virtual DbSet<ShoppingCard> ShoppingCards { get; set; }
        public virtual DbSet<Subcategory> Subcategories { get; set; }
        public virtual DbSet<SubcategoryLanguage> SubcategoryLanguages { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
    }
}
