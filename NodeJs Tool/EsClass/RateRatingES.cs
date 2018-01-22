using Nest;

namespace API30Shine.Models.ESModels 
{
	public class RateRatingES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="object_uid")]
		public string ObjectUid {get; set;} 

		[Text(Name="instance_uid")]
		public string InstanceUid {get; set;} 

		[Text(Name="score")]
		public int Score {get; set;} 

	}
}