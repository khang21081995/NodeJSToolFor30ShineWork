using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class PrdGroup: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="parent_uid")]
		[JsonProperty("parent_uid")]
		public string ParentUid {get; set;}

		[Text(Name="group_type_uid")]
		[JsonProperty("group_type_uid")]
		public string GroupTypeUid {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="description")]
		[JsonProperty("description")]
		public string Description {get; set;}

		[Text(Name="thumb_images")]
		[JsonProperty("thumb_images")]
		public string ThumbImages {get; set;}

		[Text(Name="order_number")]
		[JsonProperty("order_number")]
		public int? OrderNumber {get; set;}

		[Text(Name="is_active")]
		[JsonProperty("is_active")]
		public int? IsActive {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		[Text(Name="tmp_product_uid")]
		[JsonProperty("tmp_product_uid")]
		public string TmpProductUid {get; set;}

		public override string TableName() { return "prd_group"; }
		public static string GetIndexName() { return "db30shine_product__prd_group"; }
}
}