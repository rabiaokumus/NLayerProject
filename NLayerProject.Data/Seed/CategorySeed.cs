﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seed
{
    class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = _ids[0],
                    Name = "Elektronik Eşya"
                },
                new Category
                {
                    Id = _ids[1],
                    Name = "Beyaz Eşya"
                });
        }
    }
}
