using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Community : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Province {get; set;}
        public string County {get; set;}
        public string City_town {get; set;}
        public string Lgbt {get; set;}
        public string Medieval {get; set;}
        public string Renaissance {get; set;}
        public string Heritage {get; set;}
        public string Nationality {get; set;}
        public string Language {get; set;}
        public string Historic {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}