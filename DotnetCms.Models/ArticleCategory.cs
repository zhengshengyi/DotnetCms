/**
*┌──────────────────────────────────────────────────────────────┐
*│　描    述：文章分类                                                    
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
	/// 文章分类
	/// </summary>
	public partial class ArticleCategory
	{
		/// <summary>
		/// 主键
		/// </summary>
		[Key]
		public Int32 Id {get;set;}

		/// <summary>
		/// 分类标题
		/// </summary>
		[Required]
		[MaxLength(128)]
		public String Title {get;set;}

		/// <summary>
		/// 父分类ID
		/// </summary>
		[Required]
		[MaxLength(10)]
		public Int32 ParentId {get;set;}

		/// <summary>
		/// 类别ID列表(逗号分隔开)
		/// </summary>
		[MaxLength(128)]
		public String ClassList {get;set;}

		/// <summary>
		/// 类别深度
		/// </summary>
		[MaxLength(10)]
		public Int32? ClassLayer {get;set;}

		/// <summary>
		/// 排序
		/// </summary>
		[Required]
		[MaxLength(10)]
		public Int32 Sort {get;set;}

		/// <summary>
		/// 分类图标
		/// </summary>
		[MaxLength(128)]
		public String ImageUrl {get;set;}

		/// <summary>
		/// 分类SEO标题
		/// </summary>
		[MaxLength(128)]
		public String SeoTitle {get;set;}

		/// <summary>
		/// 分类SEO关键字
		/// </summary>
		[MaxLength(256)]
		public String SeoKeywords {get;set;}

		/// <summary>
		/// 分类SEO描述
		/// </summary>
		[MaxLength(512)]
		public String SeoDescription {get;set;}

		/// <summary>
		/// 是否删除
		/// </summary>
		[Required]
		[MaxLength(1)]
		public Boolean IsDeleted {get;set;}


	}
}
