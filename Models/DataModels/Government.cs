using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Government : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Republicanparty {get; set;}
        public string Democraticparty {get; set;}
        public string Otherparty {get; set;}
        public string Nonpartisan {get; set;}
        public string Federalgovernment {get; set;}
        public string Stategovernment {get; set;}
        public string County_municipalgovernment {get; set;}
        public string Military {get; set;}
        public string Internationalaffair {get; set;}
        public string Nationalsecurity {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}