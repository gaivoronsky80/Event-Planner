using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class FoodAndDrink : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Beer {get; set;}
        public string Wine {get; set;}
        public string Food {get; set;}
        public string Spirits {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}