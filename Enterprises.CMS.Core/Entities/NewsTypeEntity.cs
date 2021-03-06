﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Enterprises.CMS.Entities
{
    /// <summary>
    /// 新闻类型
    /// </summary>
    [Table("NewsType")]
    public class NewsTypeEntity : AuditedEntity<long>
    {
        /// <summary>
        /// 新闻类型
        /// </summary>
        [MaxLength(100)]
        [Required]
        public virtual string TypeName { get; set; }

        /// <summary>
        /// 新闻编号
        /// </summary>
        [MaxLength(100)]
        [Required]
        public virtual string TypeCode { get; set; }

        /// <summary>
        /// 在菜单显示
        /// </summary>
        public virtual bool ShowMenu { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        public virtual int SortOrder { get; set; }


    }
}
