using Nest;

namespace API30Shine.Models.ESModels 
{
	public class SalonES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="salon_type_uid")]
		public string SalonTypeUid {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="short_name")]
		public string ShortName {get; set;} 

		[Text(Name="phone")]
		public string Phone {get; set;} 

		[Text(Name="manager_uid")]
		public string ManagerUid {get; set;} 

		[Text(Name="manager_name")]
		public string ManagerName {get; set;} 

		[Text(Name="adr_city_uid")]
		public string AdrCityUid {get; set;} 

		[Text(Name="adr_district_uid")]
		public string AdrDistrictUid {get; set;} 

		[Text(Name="address")]
		public string Address {get; set;} 

		[Text(Name="fanpage_id")]
		public string FanpageId {get; set;} 

		[Text(Name="fanpage_url")]
		public string FanpageUrl {get; set;} 

		[Text(Name="images")]
		public string Images {get; set;} 

		[Text(Name="image_map")]
		public string ImageMap {get; set;} 

		[Text(Name="order_number")]
		public int OrderNumber {get; set;} 

		[Text(Name="is_active")]
		public int IsActive {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

	}
}