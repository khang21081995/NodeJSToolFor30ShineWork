using Nest;

namespace API30Shine.Models.ESModels 
{
	public class RateConfigES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="score")]
		public int Score {get; set;} 

		[Text(Name="object_uid")]
		public string ObjectUid {get; set;} 

	}
}