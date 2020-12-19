﻿using NLayerProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NLayerProject.Core.Service
{
    public interface ICategoryService : IService<Category>
    {
        Task<IEnumerable<Category>> GetWithProductsByIdAsync(int categoryId);
    }
}
