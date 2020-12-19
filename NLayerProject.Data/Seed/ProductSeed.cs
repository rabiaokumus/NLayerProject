using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seed
{
    class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product()
            {
                Id = 1,
                Name = "Cep Telefonu",
                Price = 12.6m,
                Stock = 10,
                CategoryId = _ids[0]
            }, new Product()
            {
                Id = 2,
                Name = "Laptop",
                Price = 15.6m,
                Stock = 12,
                CategoryId = _ids[1]
            },
             new Product()
             {
                 Id = 3,
                 Name = "Akıllı Saat",
                 Price = 7.6m,
                 Stock = 10,
                 CategoryId = _ids[2]
             });
        }
    }
}
