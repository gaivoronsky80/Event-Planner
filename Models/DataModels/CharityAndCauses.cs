using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class CharityAndCauses : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Animalwelfare {get; set;}
        public string Environment {get; set;}
        public string Healthcare {get; set;}
        public string Humanright {get; set;}
        public string Internationalaid {get; set;}
        public string Poverty {get; set;}
        public string Dissasterrelief {get; set;}
        public string Education {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}