﻿using NFine.Data;
using NFine.Domain.Entity.SystemManage;
using NFine.Domain.IRepository.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Repository.SystemManage
{
    public partial class NewsTypeRepository : RepositoryBase<NewsTypeEntity>, INewsTypeRepository
    {
        public List<NewsTypeEntity> GetList(string keyword = "", string fname = "")
        {
            return this.GetList(keyword, fname);
        }
    }
}
