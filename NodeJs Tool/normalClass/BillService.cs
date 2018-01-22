namespace Models.ES 
{
	public class BillService
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string CustomerUid {get; set;} 
		public string BookingUid {get; set;} 
		public string CheckinUid {get; set;} 
		public string SkinnerUid {get; set;} 
		public string StylistUid {get; set;} 
		public string 30shineCareTypeUid {get; set;} 
		public int RatingValue {get; set;} 
		public int SkinnerStartTime {get; set;} 
		public int StylistStartTime {get; set;} 
		public int StylistEstimateDuration {get; set;} 
		public int StylistServiceDuration {get; set;} 
		public string Images {get; set;} 
		public int UploadImagesTime {get; set;} 
		public float TotalDiscountMoney {get; set;} 
		public float TotalIncomeMoney {get; set;} 
		public int InProcedureTime {get; set;} 
		public string SkinnerNote {get; set;} 
		public string StylistNote {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public string HcItem {get; set;} 

}
}