using Nest;

namespace API30Shine.Models.ESModels 
{
	public class CustomerES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="user_uid")]
		public string UserUid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="thread_uid")]
		public string ThreadUid {get; set;} 

		[Text(Name="total_point")]
		public int TotalPoint {get; set;} 

		[Text(Name="total_bill")]
		public int TotalBill {get; set;} 

		[Text(Name="total_money")]
		public float TotalMoney {get; set;} 

		[Text(Name="is_old")]
		public int IsOld {get; set;} 

		[Text(Name="is_verify")]
		public int IsVerify {get; set;} 

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