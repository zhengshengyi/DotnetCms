/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理员角色                                                    
*│　作    者：zhengshengyi                                            
*│　版    本：1.0    模板代码自动生成                                                
*│　创建时间：2020-08-16 23:40:47                             
*└──────────────────────────────────────────────────────────────┘
*/
using DotnetCms.IRepository;
using DotnetCms.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotnetCms.Services
{
    public class ManagerRoleService: IManagerRoleService
    {
        private readonly IManagerRoleRepository _repository;

        public ManagerRoleService(IManagerRoleRepository repository)
        {
            _repository = repository;
        }
    }
}