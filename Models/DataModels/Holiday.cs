using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Holiday : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Stpatricksday {get; set;}
        public string Easter {get; set;}
        public string Independenceday {get; set;}
        public string Halloween_haunt {get; set;}
        public string Thanksgiving {get; set;}
        public string Christmas {get; set;}
        public string Channukah {get; set;}
        public string Fallevent {get; set;}
        public string Newyearseve {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}