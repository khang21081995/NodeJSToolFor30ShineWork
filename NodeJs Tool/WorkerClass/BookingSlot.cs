using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class BookingSlot: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="salon_uid")]
		[JsonProperty("salon_uid")]
		public string SalonUid {get; set;}

		[Text(Name="work_date")]
		[JsonProperty("work_date")]
		public int? WorkDate {get; set;}

		[Text(Name="slot")]
		[JsonProperty("slot")]
		public int? Slot {get; set;}

		[Text(Name="total_slot")]
		[JsonProperty("total_slot")]
		public int? TotalSlot {get; set;}

		[Text(Name="percent_slot")]
		[JsonProperty("percent_slot")]
		public float? PercentSlot {get; set;}

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

		public override string TableName() { return "booking_slot"; }
		public static string GetIndexName() { return "db30shine_booking__booking_slot"; }
}
}