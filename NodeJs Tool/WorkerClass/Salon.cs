using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class Salon: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="salon_type_uid")]
		[JsonProperty("salon_type_uid")]
		public string SalonTypeUid {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="short_name")]
		[JsonProperty("short_name")]
		public string ShortName {get; set;}

		[Text(Name="phone")]
		[JsonProperty("phone")]
		public string Phone {get; set;}

		[Text(Name="manager_uid")]
		[JsonProperty("manager_uid")]
		public string ManagerUid {get; set;}

		[Text(Name="manager_name")]
		[JsonProperty("manager_name")]
		public string ManagerName {get; set;}

		[Text(Name="adr_city_uid")]
		[JsonProperty("adr_city_uid")]
		public string AdrCityUid {get; set;}

		[Text(Name="adr_district_uid")]
		[JsonProperty("adr_district_uid")]
		public string AdrDistrictUid {get; set;}

		[Text(Name="address")]
		[JsonProperty("address")]
		public string Address {get; set;}

		[Text(Name="fanpage_id")]
		[JsonProperty("fanpage_id")]
		public string FanpageId {get; set;}

		[Text(Name="fanpage_url")]
		[JsonProperty("fanpage_url")]
		public string FanpageUrl {get; set;}

		[Text(Name="images")]
		[JsonProperty("images")]
		public string Images {get; set;}

		[Text(Name="image_map")]
		[JsonProperty("image_map")]
		public string ImageMap {get; set;}

		[Text(Name="order_number")]
		[JsonProperty("order_number")]
		public int? OrderNumber {get; set;}

		[Text(Name="is_active")]
		[JsonProperty("is_active")]
		public int? IsActive {get; set;}

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

		public override string TableName() { return "salon"; }
		public static string GetIndexName() { return "db30shine_salon__salon"; }
}
}