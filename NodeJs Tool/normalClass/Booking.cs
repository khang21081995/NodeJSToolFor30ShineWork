namespace Models.ES 
{
	public class Booking
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string SalonUid {get; set;} 
		public string StylistUid {get; set;} 
		public string ThreadUid {get; set;} 
		public string HourUid {get; set;} 
		public int BookDate {get; set;} 
		public string CustomerUid {get; set;} 
		public int CreateTime {get; set;} 
		public string CustomerBookingNote {get; set;} 
		public string CustomerNote {get; set;} 
		public string SalonNote {get; set;} 
		public int IsArrived {get; set;} 
		public int IsMakeBill {get; set;} 
		public int IsNewCustomer {get; set;} 
		public int IsAutoStylist {get; set;} 
		public int IsSendSms {get; set;} 
		public int IsDelete {get; set;} 
		public int SmsSentTime {get; set;} 
		public string CustomerPhone {get; set;} 
		public string StaffNote {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public int ModifyTime {get; set;} 
		public string CustomerName {get; set;} 
		public TimeSpan ModifyAt {get; set;} 
		public int ArrivedTime {get; set;} 
		public string NoteDelete {get; set;} 

}
}