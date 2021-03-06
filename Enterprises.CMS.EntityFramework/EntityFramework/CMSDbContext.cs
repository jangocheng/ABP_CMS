﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Enterprises.CMS.Authorization.Roles;
using Enterprises.CMS.MultiTenancy;
using Enterprises.CMS.Entities;
using Enterprises.CMS.Users;

namespace Enterprises.CMS.EntityFramework
{
    
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))] // Mysql 数据库
    public class CMSDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for each Entity...

        //Example:
        //public virtual IDbSet<User> Users { get; set; }
        public virtual IDbSet<NewsTypeEntity> NewsType { get; set; }
        public virtual IDbSet<NewsEntity> News { get; set; }
        public virtual IDbSet<FilesEntity> Files { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public CMSDbContext()
            : base("CmsConnection")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in CMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of CMSDbContext since ABP automatically handles it.
         */
        public CMSDbContext(string nameOrConnectionString)
            : base("CmsConnection")
        {

        }

        //This constructor is used in tests
        public CMSDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
