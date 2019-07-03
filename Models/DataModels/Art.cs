using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Art : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Theater {get; set;}
        public string Musical {get; set;}
        public string Ballet {get; set;}
        public string Dance {get; set;}
        public string Opera {get; set;}
        public string Orchestra {get; set;}
        public string Craft {get; set;}
        public string Fineart {get; set;}
        public string Literaryart {get; set;}
        public string Comedy {get; set;}
        public string Sculpture {get; set;}
        public string Painting {get; set;}
        public string Design {get; set;}
        public string Jewelry {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}