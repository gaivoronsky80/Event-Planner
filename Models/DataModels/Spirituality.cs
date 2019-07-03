using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Spirituality : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Christianity {get; set;}
        public string Judaism {get; set;}
        public string Islam {get; set;}
        public string Mormonism {get; set;}
        public string Buddism {get; set;}
        public string Sikhism {get; set;}
        public string Easternreligion {get; set;}
        public string Mysticismandoccult {get; set;}
        public string Newage {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}