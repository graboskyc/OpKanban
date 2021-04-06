using System;
using MongoDB.Bson;
using Realms;

namespace OpKanban.Data
{
    public class Contact : RealmObject
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

        [MapTo("email")]
        public string Email { get; set; }

        [MapTo("note")]
        public string Note { get; set; }

        [MapTo("championStatus")]
        public string ChampionStatus { get; set; }

        [MapTo("family")]
        public string Family { get; set; }

        [MapTo("interests")]
        public string Interests { get; set; }

        [MapTo("color")]
        public string Color { get; set; }

        [MapTo("company")]
        public string Company { get; set; }

        [MapTo("division")]
        public string Division { get; set; }

        [MapTo("location")]
        public string Location { get; set; }

        [MapTo("phone")]
        public string Phone { get; set; }

        [MapTo("linkedin")]
        public string LinkedIn { get; set; }

        [MapTo("tenure")]
        public string Tenure { get; set; }

        [MapTo("tcbActions")]
        public string TCBActions { get; set; }
    }
}
