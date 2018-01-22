using Nest;

namespace API30Shine.Models.ESModels 
{
	public class TimeKeepingES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="staff_uid")]
		public string StaffUid {get; set;} 

		[Text(Name="time_keeper_uid")]
		public string TimeKeeperUid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="working_shift_uid")]
		public string WorkingShiftUid {get; set;} 

		[Text(Name="work_date")]
		public int WorkDate {get; set;} 

		[Text(Name="work_hour")]
		public float WorkHour {get; set;} 

		[Text(Name="is_enroll")]
		public int IsEnroll {get; set;} 

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

		[Text(Name="note")]
		public string Note {get; set;} 

	}
}