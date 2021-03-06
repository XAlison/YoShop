﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YoShop.Models.Requests
{
    /// <summary>
    /// 分页操作
    /// </summary>
    public class FilePageRequest
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public int CurPage { get; set; } = 1;
        /// <summary>
        /// 总页数
        /// </summary>
        public int LastPage { get; set; }
        /// <summary>
        /// 每页条数
        /// </summary>
        public int PerPage { get; set; } = 32;
        /// <summary>
        /// 总记录数
        /// </summary>
        public int Total = 0;
        /// <summary>
        /// 数据
        /// </summary>
        public object Data { get; set; }
    }
}
