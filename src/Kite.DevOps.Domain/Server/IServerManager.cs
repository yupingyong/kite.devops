﻿using Kite.DevOps.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kite.DevOps.Domain.Server
{
    public interface IServerManager
    {
        /// <summary>
        /// 获取查询对象
        /// </summary>
        /// <returns></returns>
        Task<IQueryable<dynamic>> GetQueryAsync();
    }
}
