/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：定时任务                                                    
*│　作    者：zhengshengyi                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2020-08-16 23:40:47                           
*└──────────────────────────────────────────────────────────────┘
*/
using DotnetCms.ViewModels.ResultModel;
using DotnetCms.ViewModels.TaskInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCms.IServices
{
    public interface ITaskInfoService
    {
        /// <summary>
        /// 根据查询条件获取数据
        /// </summary>
        /// <param name="model">查询实体</param>
        /// <returns>table数据</returns>
        Task<TableDataModel> LoadDataAsync(TaskInfoRequestModel model);

        /// <summary>
        /// 应用程序停止时暂停所有任务
        /// </summary>
        /// <returns></returns>
        Task<bool> SystemStoppedAsync();
        /// <summary>
        /// 应用程序启动时启动所有任务
        /// </summary>
        /// <returns></returns>
        Task<bool> ResumeSystemStoppedAsync();
        /// <summary>
        /// 根据ids更新状态
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        Task<BooleanResult> UpdateStatusByIdsAsync(Int32[] ids, int Status);

        /// <summary>
        /// 根据状态获取任务列表
        /// </summary>
        /// <param name="Status">定时任务状态</param>
        /// <returns></returns>
        Task<List<TaskInfoDto>> GetListByJobStatuAsync(int Status);

        /// <summary>
        /// 判断是否存在名为Name的菜单
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        Task<BooleanResult> IsExistsNameAsync(TaskInfoAddOrModifyModel item);

        /// <summary>
        /// 新增或者修改服务
        /// </summary>
        /// <param name="item">新增或者修改实体</param>
        /// <returns>结果实体</returns>
        Task<BaseResult> AddOrModifyAsync(TaskInfoAddOrModifyModel model);

        Task<BooleanResult> DeleteAsync(int Id);

        Task<List<TaskInfoDto>> GetListByIdsAsync(int[] ids);

        Task<TaskInfoDto> GetByIdAsync(int id);
    }
}