﻿using Elight.Entity;
using Elight.Reposity; 
using System;
using System.Collections.Generic; 
using System.Linq.Expressions; 

namespace Elight.Service
{
    public interface IBaseService<T, TRepository> where T : BaseModelEntity, new()
    {
        IRepository<T> _repository { get; set; }
        bool Delete(List<string> primaryKey);
        T Get(string primaryKey);
        List<T> GetList(int pageIndex, int pageSize, Expression<Func<T, bool>> expression, ref int totalCount);
    }
}
