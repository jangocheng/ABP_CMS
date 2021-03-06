using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Enterprises.CMS.UserList.Dto;
using Webdiyer.WebControls.Mvc;

namespace Enterprises.CMS.UserList
{
    public interface IUserAppService : IApplicationService
    {
        Task ProhibitPermission(ProhibitPermissionInput input);

        Task<ListResultDto<UserListDto>> GetUsers();
        void Create(CreateUserInput model);
        void Delete(long id);
        CreateUserInput GetSingle(long id);

        void Edit(CreateUserInput model);


        PagedList<UserListDto> List(UsersSearchInput searchModel, int id);
    }
}