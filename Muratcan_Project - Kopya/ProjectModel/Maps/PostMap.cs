﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Map;
using ProjectModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectModel.Maps
{
    public class PostMap : CoreMap<Post>
    {
        public override void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(200).IsRequired(true);
            builder.Property(x => x.PostDetail).IsRequired(true);
            builder.Property(x => x.Tags).IsRequired(true);
            builder.Property(x => x.ImagePath).IsRequired(false);

            base.Configure(builder);
        }

    }
}
