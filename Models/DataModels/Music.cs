using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Music : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Alternative {get; set;}
        public string Bluesandjazz {get; set;}
        public string Classical {get; set;}
        public string Country {get; set;}
        public string Cultural {get; set;}
        public string Edm_electronic {get; set;}
        public string Folk {get; set;}
        public string Hiphopp_rap {get; set;}
        public string Indie {get; set;}
        public string Latin {get; set;}
        public string Metal {get; set;}
        public string Opera {get; set;}
        public string Pop {get; set;}
        public string Randb {get; set;}
        public string Reggae {get; set;}
        public string Religious_spiritual {get; set;}
        public string Rock {get; set;}
        public string Top40 {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}