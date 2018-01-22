using Nest;

namespace API30Shine.Models.ESModels 
{
	public class BookingES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="salon_uid")]
		public string SalonUid {get; set;} 

		[Text(Name="stylist_uid")]
		public string StylistUid {get; set;} 

		[Text(Name="thread_uid")]
		public string ThreadUid {get; set;} 

		[Text(Name="hour_uid")]
		public string HourUid {get; set;} 

		[Text(Name="book_date")]
		public int BookDate {get; set;} 

		[Text(Name="customer_uid")]
		public string CustomerUid {get; set;} 

		[Text(Name="create_time")]
		public int CreateTime {get; set;} 

		[Text(Name="customer_booking_note")]
		public string CustomerBookingNote {get; set;} 

		[Text(Name="customer_note")]
		public string CustomerNote {get; set;} 

		[Text(Name="salon_note")]
		public string SalonNote {get; set;} 

		[Text(Name="is_arrived")]
		public int IsArrived {get; set;} 

		[Text(Name="is_make_bill")]
		public int IsMakeBill {get; set;} 

		[Text(Name="is_new_customer")]
		public int IsNewCustomer {get; set;} 

		[Text(Name="is_auto_stylist")]
		public int IsAutoStylist {get; set;} 

		[Text(Name="is_send_sms")]
		public int IsSendSms {get; set;} 

		[Text(Name="is_delete")]
		public int IsDelete {get; set;} 

		[Text(Name="sms_sent_time")]
		public int SmsSentTime {get; set;} 

		[Text(Name="customer_phone")]
		public string CustomerPhone {get; set;} 

		[Text(Name="staff_note")]
		public string StaffNote {get; set;} 

		[Text(Name="create_at")]
		public TimeSpan CreateAt {get; set;} 

		[Text(Name="modify_time")]
		public int ModifyTime {get; set;} 

		[Text(Name="customer_name")]
		public string CustomerName {get; set;} 

		[Text(Name="modify_at")]
		public TimeSpan ModifyAt {get; set;} 

		[Text(Name="arrived_time")]
		public int ArrivedTime {get; set;} 

		[Text(Name="note_delete")]
		public string NoteDelete {get; set;} 

	}
}