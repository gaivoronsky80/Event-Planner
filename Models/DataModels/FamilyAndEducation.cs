using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class FamilyAndEducation : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Education {get; set;}
        public string Alumni {get; set;}
        public string Parenting {get; set;}
        public string Baby {get; set;}
        public string Childrenandyouth {get; set;}
        public string Parentsassociation {get; set;}
        public string Reunion {get; set;}
        public string Seniorcitizen {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}