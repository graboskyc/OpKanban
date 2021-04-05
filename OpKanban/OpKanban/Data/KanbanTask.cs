using System;
using MongoDB.Bson;
using Realms;

namespace OpKanban.Data
{
    public class KanbanTask : RealmObject
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
        [Required]
        public string Link { get; set; }

        [MapTo("pop")]
        public string POP { get; set; }

        [MapTo("stage")]
        [Required]
        public string Stage { get; set; } = "Discovery";

        [MapTo("team")]
        public string Team { get; set; }

        [MapTo("ntse")]
        public string NTSE { get; set; }

        [MapTo("color")]
        public string Color { get; set; }

        [MapTo("note")]
        public string Note { get; set; }

        [MapTo("slides")]
        public string Slides { get; set; }
    }
}
