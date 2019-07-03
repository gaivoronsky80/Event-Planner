using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class SchoolActivity : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Dinner {get; set;}
        public string Fundraiser {get; set;}
        public string Raffle {get; set;}
        public string Afterschoolcare {get; set;}
        public string Parking {get; set;}
        public string Pablicspeaker {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}