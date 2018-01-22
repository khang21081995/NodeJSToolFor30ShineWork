namespace Models.ES 
{
	public class Salon
{
			public int Id {get; set;} 
		public string Uid {get; set;} 
		public string SalonTypeUid {get; set;} 
		public string Name {get; set;} 
		public string ShortName {get; set;} 
		public string Phone {get; set;} 
		public string ManagerUid {get; set;} 
		public string ManagerName {get; set;} 
		public string AdrCityUid {get; set;} 
		public string AdrDistrictUid {get; set;} 
		public string Address {get; set;} 
		public string FanpageId {get; set;} 
		public string FanpageUrl {get; set;} 
		public string Images {get; set;} 
		public string ImageMap {get; set;} 
		public int OrderNumber {get; set;} 
		public int IsActive {get; set;} 
		public int IsDelete {get; set;} 
		public int CreateTime {get; set;} 
		public int ModifyTime {get; set;} 
		public TimeSpan CreateAt {get; set;} 
		public TimeSpan ModifyAt {get; set;} 

}
}