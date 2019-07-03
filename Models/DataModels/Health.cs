using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Health : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Personalhealth {get; set;}
        public string Mentalhealth {get; set;}
        public string Medical {get; set;}
        public string Spa {get; set;}
        public string Yoga {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}