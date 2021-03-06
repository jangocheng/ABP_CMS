﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Enterprises.CMS.Roles.Dto
{
    [AutoMapFrom(typeof(Authorization.Roles.Role))]
    public class RoleListDto : EntityDto<long>
    {
        public  string Name { get; set; }

       /// <summary>
       /// 
       /// </summary>
        public  string DisplayName { get; set; }


    }
}
