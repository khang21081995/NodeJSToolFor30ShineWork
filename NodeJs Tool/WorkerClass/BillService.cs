using Nest;
using MobileTech.SQLGenerateLibrary;
using Newtonsoft.Json;
using System;
namespace ThirtyShine.Conductor.Model 
{
	public class BillService: TableInfo
{
	
		[Text(Name="id")]
		[JsonProperty("id")]
		public int? Id {get; set;}

		[Text(Name="uid")]
		[JsonProperty("uid")]
		public string Uid {get; set;}

		[Text(Name="customer_uid")]
		[JsonProperty("customer_uid")]
		public string CustomerUid {get; set;}

		[Text(Name="booking_uid")]
		[JsonProperty("booking_uid")]
		public string BookingUid {get; set;}

		[Text(Name="checkin_uid")]
		[JsonProperty("checkin_uid")]
		public string CheckinUid {get; set;}

		[Text(Name="skinner_uid")]
		[JsonProperty("skinner_uid")]
		public string SkinnerUid {get; set;}

		[Text(Name="stylist_uid")]
		[JsonProperty("stylist_uid")]
		public string StylistUid {get; set;}

		[Text(Name="30shine_care_type_uid")]
		[JsonProperty("30shine_care_type_uid")]
		public string 30shineCareTypeUid {get; set;}

		[Text(Name="rating_value")]
		[JsonProperty("rating_value")]
		public int? RatingValue {get; set;}

		[Text(Name="skinner_start_time")]
		[JsonProperty("skinner_start_time")]
		public int? SkinnerStartTime {get; set;}

		[Text(Name="stylist_start_time")]
		[JsonProperty("stylist_start_time")]
		public int? StylistStartTime {get; set;}

		[Text(Name="stylist_estimate_duration")]
		[JsonProperty("stylist_estimate_duration")]
		public int? StylistEstimateDuration {get; set;}

		[Text(Name="stylist_service_duration")]
		[JsonProperty("stylist_service_duration")]
		public int? StylistServiceDuration {get; set;}

		[Text(Name="images")]
		[JsonProperty("images")]
		public string Images {get; set;}

		[Text(Name="upload_images_time")]
		[JsonProperty("upload_images_time")]
		public int? UploadImagesTime {get; set;}

		[Text(Name="total_discount_money")]
		[JsonProperty("total_discount_money")]
		public float? TotalDiscountMoney {get; set;}

		[Text(Name="total_income_money")]
		[JsonProperty("total_income_money")]
		public float? TotalIncomeMoney {get; set;}

		[Text(Name="in_procedure_time")]
		[JsonProperty("in_procedure_time")]
		public int? InProcedureTime {get; set;}

		[Text(Name="skinner_note")]
		[JsonProperty("skinner_note")]
		public string SkinnerNote {get; set;}

		[Text(Name="stylist_note")]
		[JsonProperty("stylist_note")]
		public string StylistNote {get; set;}

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

		[Text(Name="hc_item")]
		[JsonProperty("hc_item")]
		public string HcItem {get; set;}

		public override string TableName() { return "bill_service"; }
		public static string GetIndexName() { return "db30shine_bill__bill_service"; }
}
}