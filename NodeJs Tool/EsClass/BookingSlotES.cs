using Nest;

namespace API30Shine.Models.ESModels 
{
	public class BookingSlotES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="work_date")]
		public int WorkDate {get; set;} 

		[Text(Name="slot")]
		public int Slot {get; set;} 

		[Text(Name="total_slot")]
		public int TotalSlot {get; set;} 

		[Text(Name="percent_slot")]
		public float PercentSlot {get; set;} 

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