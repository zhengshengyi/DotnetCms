/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：后台管理员                                                    
*│　作    者：zhengshengyi                                              
*│　版    本：1.0   模板代码自动生成                                              
*│　创建时间：2020-08-16 23:40:47                            
*└──────────────────────────────────────────────────────────────┘
*/
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotnetCms.Models
{
	/// <summary>
	/// zhengshengyi
	/// 2020-08-16 23:40:47
	/// 后台管理员
	/// </summary>
	public partial class Manager
	{
		/// <summary>
		/// 主键
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		/// 角色ID
		/// </summary>
		[Required]
		[MaxLength(10)]
		public Int32 RoleId {get;set;}

		/// <summary>
		/// 用户名
		/// </summary>
		[Required]
		[MaxLength(32)]
		public String UserName {get;set;}

		/// <summary>
		/// 密码
		/// </summary>
		[Required]
		[MaxLength(128)]
		public String Password {get;set;}

		/// <summary>
		/// 头像
		/// </summary>
		[MaxLength(256)]
		public String Avatar {get;set;}

		/// <summary>
		/// 用户昵称
		/// </summary>
		[MaxLength(32)]
		public String NickName {get;set;}

		/// <summary>
		/// 手机号码
		/// </summary>
		[MaxLength(16)]
		public String Mobile {get;set;}

		/// <summary>
		/// 邮箱地址
		/// </summary>
		[MaxLength(128)]
		public String Email {get;set;}

		/// <summary>
		/// 登录次数
		/// </summary>
		[MaxLength(10)]
		public Int32? LoginCount {get;set;}

		/// <summary>
		/// 最后一次登录IP
		/// </summary>
		[MaxLength(64)]
		public String LoginLastIp {get;set;}

		/// <summary>
		/// 最后一次登录时间
		/// </summary>
		[MaxLength(23)]
		public DateTime? LoginLastTime {get;set;}

		/// <summary>
		/// 添加人
		/// </summary>
		[Required]
		[MaxLength(10)]
		public Int32 AddManagerId {get;set;}

		/// <summary>
		/// 添加时间
		/// </summary>
		[Required]
		[MaxLength(23)]
		public DateTime AddTime {get;set;}

		/// <summary>
		/// 修改人
		/// </summary>
		[MaxLength(10)]
		public Int32? ModifyManagerId {get;set;}

		/// <summary>
		/// 修改时间
		/// </summary>
		[MaxLength(23)]
		public DateTime? ModifyTime {get;set;}

		/// <summary>
		/// 是否锁定
		/// </summary>
		[Required]
		[MaxLength(1)]
		public Boolean IsLock {get;set;}

		/// <summary>
		/// 是否删除
		/// </summary>
		[Required]
		[MaxLength(1)]
		public Boolean IsDelete {get;set;}

		/// <summary>
		/// 备注
		/// </summary>
		[MaxLength(128)]
		public String Remark {get;set;}


	}
}
