﻿using CrudDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudDDD.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);
        void Update(TEntity obj);
        void Delete(int id);
        IList<TEntity> Select();
        TEntity Select(int id);
    }
}
