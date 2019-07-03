using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class AutoAndBoatAndAir : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Auto {get; set;}
        public string Motorcycle_atv {get; set;}
        public string Boat {get; set;}
        public string Air {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}