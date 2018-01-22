using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class Booking: TableInfo
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

		[Text(Name="stylist_uid")]
		[JsonProperty("stylist_uid")]
		public string StylistUid {get; set;}

		[Text(Name="thread_uid")]
		[JsonProperty("thread_uid")]
		public string ThreadUid {get; set;}

		[Text(Name="hour_uid")]
		[JsonProperty("hour_uid")]
		public string HourUid {get; set;}

		[Text(Name="book_date")]
		[JsonProperty("book_date")]
		public int? BookDate {get; set;}

		[Text(Name="customer_uid")]
		[JsonProperty("customer_uid")]
		public string CustomerUid {get; set;}

		[Text(Name="create_time")]
		[JsonProperty("create_time")]
		public int? CreateTime {get; set;}

		[Text(Name="customer_booking_note")]
		[JsonProperty("customer_booking_note")]
		public string CustomerBookingNote {get; set;}

		[Text(Name="customer_note")]
		[JsonProperty("customer_note")]
		public string CustomerNote {get; set;}

		[Text(Name="salon_note")]
		[JsonProperty("salon_note")]
		public string SalonNote {get; set;}

		[Text(Name="is_arrived")]
		[JsonProperty("is_arrived")]
		public int? IsArrived {get; set;}

		[Text(Name="is_make_bill")]
		[JsonProperty("is_make_bill")]
		public int? IsMakeBill {get; set;}

		[Text(Name="is_new_customer")]
		[JsonProperty("is_new_customer")]
		public int? IsNewCustomer {get; set;}

		[Text(Name="is_auto_stylist")]
		[JsonProperty("is_auto_stylist")]
		public int? IsAutoStylist {get; set;}

		[Text(Name="is_send_sms")]
		[JsonProperty("is_send_sms")]
		public int? IsSendSms {get; set;}

		[Text(Name="is_delete")]
		[JsonProperty("is_delete")]
		public int? IsDelete {get; set;}

		[Text(Name="sms_sent_time")]
		[JsonProperty("sms_sent_time")]
		public int? SmsSentTime {get; set;}

		[Text(Name="customer_phone")]
		[JsonProperty("customer_phone")]
		public string CustomerPhone {get; set;}

		[Text(Name="staff_note")]
		[JsonProperty("staff_note")]
		public string StaffNote {get; set;}

		[Text(Name="create_at")]
		[JsonProperty("create_at")]
		public TimeSpan? CreateAt {get; set;}

		[Text(Name="modify_time")]
		[JsonProperty("modify_time")]
		public int? ModifyTime {get; set;}

		[Text(Name="customer_name")]
		[JsonProperty("customer_name")]
		public string CustomerName {get; set;}

		[Text(Name="modify_at")]
		[JsonProperty("modify_at")]
		public TimeSpan? ModifyAt {get; set;}

		[Text(Name="arrived_time")]
		[JsonProperty("arrived_time")]
		public int? ArrivedTime {get; set;}

		[Text(Name="note_delete")]
		[JsonProperty("note_delete")]
		public string NoteDelete {get; set;}

		public override string TableName() { return "booking"; }
		public static string GetIndexName() { return "db30shine_booking__booking"; }
}
}