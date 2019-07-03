using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Hobby : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Anime_Comic {get; set;}
        public string Gaming {get; set;}
        public string Diy {get; set;}
        public string Photography {get; set;}
        public string Knitting {get; set;}
        public string Books {get; set;}
        public string Adult {get; set;}
        public string Drawingandpainting {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}