using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class WorkShift: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="name")]
		[JsonProperty("name")]
		public string Name {get; set;}

		[Text(Name="start_time")]
		[JsonProperty("start_time")]
		public string StartTime {get; set;}

		[Text(Name="end_time")]
		[JsonProperty("end_time")]
		public string EndTime {get; set;}

		[Text(Name="lunch_hour")]
		[JsonProperty("lunch_hour")]
		public string LunchHour {get; set;}

		[Text(Name="lunch_hour2")]
		[JsonProperty("lunch_hour2")]
		public string LunchHour2 {get; set;}

		[Text(Name="color")]
		[JsonProperty("color")]
		public string Color {get; set;}

		[Text(Name="total_hour_frame")]
		[JsonProperty("total_hour_frame")]
		public int? TotalHourFrame {get; set;}

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

		public override string TableName() { return "work_shift"; }
		public static string GetIndexName() { return "db30shine_staff__work_shift"; }
}
}