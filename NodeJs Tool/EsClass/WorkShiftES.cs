using Nest;

namespace API30Shine.Models.ESModels 
{
	public class WorkShiftES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="start_time")]
		public string StartTime {get; set;} 

		[Text(Name="end_time")]
		public string EndTime {get; set;} 

		[Text(Name="lunch_hour")]
		public string LunchHour {get; set;} 

		[Text(Name="lunch_hour2")]
		public string LunchHour2 {get; set;} 

		[Text(Name="color")]
		public string Color {get; set;} 

		[Text(Name="total_hour_frame")]
		public int TotalHourFrame {get; set;} 

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