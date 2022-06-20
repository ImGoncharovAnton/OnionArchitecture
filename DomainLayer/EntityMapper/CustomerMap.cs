using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DomainLayer.EntityMapper;

public class CustomerMap: IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(x => x.Id).HasName("pk_customerid");
        builder.Property(x => x.Id).ValueGeneratedOnAdd()
            .HasColumnName("id")
            .HasColumnType("INT");
        builder.Property(x => x.PurchasesProduct).ValueGeneratedOnAdd()
            .HasColumnName("purchased_product")
            .HasColumnType("NVARCHAR(100)")
            .IsRequired();
        builder.Property(x => x.PaymentType).ValueGeneratedOnAdd()
            .HasColumnName("payment_type")
            .HasColumnType("NVARCHAR(50)")
            .IsRequired();
        builder.Property(x => x.CreatedDate).ValueGeneratedOnAdd()
            .HasColumnName("created_date")
            .HasColumnType("datetime");
        builder.Property(x => x.ModifiedDate).ValueGeneratedOnAdd()
            .HasColumnName("modified_date")
            .HasColumnType("datetime");
        builder.Property(x => x.IsActive).ValueGeneratedOnAdd()
            .HasColumnName("is_active")
            .HasColumnType("bit");
        
    }
}