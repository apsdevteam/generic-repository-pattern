﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_repository_pattern.Models.DAL
{
   public interface _IAllRepository<T> where T : class
    {
        IEnumerable<T> GetModel();
        T GetModelByID(int modelId);
        void InsertModel(T model);
        void DeleteModel(int modelID);
        void UpdateModel(T model);
        void Save();
    }
}
