using Domains.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {


            builder.HasOne<Blog>();
            builder.HasOne<BlogHeader>();

            modelBuilder.Entity<Blog>()
    .HasOne(e => e.Header)
    .WithOne(e => e.Blog)
    .HasForeignKey<BlogHeader>(e => e.BlogId)
    .IsRequired();
        }
    }
}
