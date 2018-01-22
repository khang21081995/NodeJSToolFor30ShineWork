using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class Customer: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="user_uid")]
		[JsonProperty("user_uid")]
		public string UserUid {get; set;}

		[Text(Name="salon_uid")]
		[JsonProperty("salon_uid")]
		public string SalonUid {get; set;}

		[Text(Name="thread_uid")]
		[JsonProperty("thread_uid")]
		public string ThreadUid {get; set;}

		[Text(Name="total_point")]
		[JsonProperty("total_point")]
		public int? TotalPoint {get; set;}

		[Text(Name="total_bill")]
		[JsonProperty("total_bill")]
		public int? TotalBill {get; set;}

		[Text(Name="total_money")]
		[JsonProperty("total_money")]
		public float? TotalMoney {get; set;}

		[Text(Name="is_old")]
		[JsonProperty("is_old")]
		public int? IsOld {get; set;}

		[Text(Name="is_verify")]
		[JsonProperty("is_verify")]
		public int? IsVerify {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		public override string TableName() { return "customer"; }
		public static string GetIndexName() { return "db30shine_customer__customer"; }
}
}