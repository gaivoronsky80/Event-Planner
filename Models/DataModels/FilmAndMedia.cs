using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class FilmAndMedia : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Tv {get; set;}
        public string Film {get; set;}
        public string Anime {get; set;}
        public string Gaming {get; set;}
        public string Comic {get; set;}
        public string Adult {get; set;}
        public string Comedy {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}