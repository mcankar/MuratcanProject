using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Map;
using ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel.Maps
{
    public class CategoryMap : CoreMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).HasMaxLength(50).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(100).IsRequired(true);

            base.Configure(builder);
        }

    }
}
