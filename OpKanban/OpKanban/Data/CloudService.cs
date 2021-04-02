using System;
using MongoDB.Bson;
using Realms;

namespace OpKanban.Data
{
    public class CloudService : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("_pk")]
        [Required]
        public string Partition { get; set; }

        [MapTo("name")]
        [Required]
        public string Name { get; set; }

        [MapTo("link")]
        public string Link { get; set; }

        [MapTo("note")]
        public string Note { get; set; }


        [MapTo("color")]
        public string Color { get; set; }

        [MapTo("company")]
        public string Company { get; set; }

        [MapTo("ntse")]
        public string NTSE { get; set; }

    }
}
