/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：操作日志                                                    
*│　作    者：zhengshengyi                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2020-08-16 23:40:47                           
*└──────────────────────────────────────────────────────────────┘
*/
using DotnetCms.Core.Repository;
using DotnetCms.Models;
using System;
using System.Threading.Tasks;

namespace DotnetCms.IRepository
{
    public interface IManagerLogRepository : IBaseRepository<ManagerLog, Int32>
    {
	     /// <summary>
        /// 逻辑删除返回影响的行数
        /// </summary>
        /// <param name="ids">需要删除的主键数组</param>
        /// <returns>影响的行数</returns>
        Int32 DeleteLogical(Int32[] ids);
        /// <summary>
        /// 逻辑删除返回影响的行数（异步操作）
        /// </summary>
        /// <param name="ids">需要删除的主键数组</param>
        /// <returns>影响的行数</returns>
        Task<Int32> DeleteLogicalAsync(Int32[] ids);
    }
}