using Nest;

namespace API30Shine.Models.ESModels 
{
	public class RateObjectES : ThirtyShine.Conductor.Common.ElasticSearch.EsBaseModel
	{

		[Text(Name="id")]
		public int Id {get; set;} 

		[Text(Name="uid")]
		public string Uid {get; set;} 

		[Text(Name="name")]
		public string Name {get; set;} 

		[Text(Name="default_score")]
		public int DefaultScore {get; set;} 

	}
}