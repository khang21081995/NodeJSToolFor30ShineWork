using Nest;

namespace API30Shine.Models.ESModels 
{
	public class PrdProductES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="brand_uid")]
		public string BrandUid {get; set;} 

		[Text(Name="code")]
		public string Code {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="description")]
		public string Description {get; set;} 

		[Text(Name="cost")]
		public float Cost {get; set;} 

		[Text(Name="price")]
		public float Price {get; set;} 

		[Text(Name="is_combo")]
		public int IsCombo {get; set;} 

		[Text(Name="price_combo")]
		public float PriceCombo {get; set;} 

		[Text(Name="percent_for_salary")]
		public float PercentForSalary {get; set;} 

		[Text(Name="volume")]
		public string Volume {get; set;} 

		[Text(Name="is_hc_inventory")]
		public int IsHcInventory {get; set;} 

		[Text(Name="is_material")]
		public int IsMaterial {get; set;} 

		[Text(Name="order_number")]
		public int OrderNumber {get; set;} 

		[Text(Name="is_active")]
		public int IsActive {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

	}
}