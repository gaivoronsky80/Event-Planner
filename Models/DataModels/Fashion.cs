using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Fashion : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Fashions {get; set;}
        public string Accessories {get; set;}
        public string Bridal {get; set;}
        public string Beauty {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}