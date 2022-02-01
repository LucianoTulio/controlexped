using MongoDB.Bson; 
using MongoDB.Bson.Serialization.Attributes; 



namespace ControlExped.Models
{
    public class Produto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId )]
        public string? Id {get;set;} 

        [BsonElement("CodigoRastreio")]
        public string? codigo {get; set; }   

        [BsonElement("DataCadastro")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime? DataCadastro{get; set; }


        

    }
}