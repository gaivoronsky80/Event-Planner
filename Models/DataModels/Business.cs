using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Business : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Startupandsmallbusiness {get; set;}
        public string Finance {get; set;}
        public string Environmentandsustainability {get; set;}
        public string Educators {get; set;}
        public string Realestate {get; set;}
        public string Nonprofitandngos {get; set;}
        public string Salesandmarketing {get; set;}
        public string Media {get; set;}
        public string Design {get; set;}
        public string Career {get; set;}
        public string Investment {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}