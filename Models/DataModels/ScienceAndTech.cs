using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class ScienceAndTech : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Medicine {get; set;}
        public string Science {get; set;}
        public string Biotech {get; set;}
        public string Hightech {get; set;}
        public string Mobile {get; set;}
        public string Socialmedia {get; set;}
        public string Robotic {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}