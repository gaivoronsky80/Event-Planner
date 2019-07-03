using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class TravelAndOutdoor : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Hiking {get; set;}
        public string Rafting {get; set;}
        public string Kayaking {get; set;}
        public string Conoeing {get; set;}
        public string Climbing {get; set;}
        public string Travel {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}