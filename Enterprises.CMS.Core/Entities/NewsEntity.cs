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
    /// 新闻内容
    /// </summary>
    [Table("News")]
    public class NewsEntity : AuditedEntity<long>
    {
        /// <summary>
        /// 新闻主题
        /// </summary>
        [MaxLength(200)]
        [Required]
        public virtual string Title { get; set; }

        /// <summary>
        /// 图文消息的摘要，仅有单图文消息才有摘要，多图文此处为空
        /// </summary>
        [MaxLength(500)]
        [Required]
        public virtual string Digest { get; set; }  
        
        /// <summary>
        /// 作者
        /// </summary>
        [MaxLength(100)]
        public virtual string Author { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Required]
        public virtual string Content { get; set; }

        /// <summary>
        /// 图文消息的封面图片素材id
        /// </summary>
        [MaxLength(200)]
        public virtual string ThumbMediaId { get; set; }
        /// <summary>
        /// 是否显示封面，0为false，即不显示，1为true，即显示
        /// </summary>
        public virtual bool ShowCoverPic { get; set; }
        /// <summary>
        /// 是否打开评论，0不打开，1打开
        /// </summary>
        public virtual bool NeedOpenComment { get; set; }
        /// <summary>
        /// 是否粉丝才可评论，0所有人可评论，1粉丝才可评论
        /// </summary>
        public virtual bool OnlyFansCanComment { get; set; }

        /// <summary>
        /// 原文连接
        /// </summary>
        [MaxLength(200)]
        public virtual string ContentSourceUrl{ get; set; }

        /// <summary>
        /// 预读次数
        /// </summary>
        public virtual int ReadNum { get; set; }


        /// <summary>
        /// 是否有效
        /// </summary>
        public virtual bool Enabled { get; set; }

        /// <summary>
        /// 排序顺序
        /// </summary>
        public virtual int SortOrder { get; set; }

        /// <summary>
        /// 类型ID
        /// </summary>
        public virtual long NewsTypeId { get; set; }
        
        /// <summary>
        /// 新闻类型
        /// </summary>
        [ForeignKey("NewsTypeId")]
        public virtual NewsTypeEntity NewsType { get; set; }

    }
}
