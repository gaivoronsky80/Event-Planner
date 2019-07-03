using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class SportAndFitness : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Running {get; set;}
        public string Walking {get; set;}
        public string Cycling {get; set;}
        public string Mountainbiking {get; set;}
        public string Obstacle {get; set;}
        public string Basketball {get; set;}
        public string Football {get; set;}
        public string Baseball {get; set;}
        public string Soccer {get; set;}
        public string Golf {get; set;}
        public string Volleyball {get; set;}
        public string Tennis {get; set;}
        public string Swimmingandwatersport {get; set;}
        public string Hockey {get; set;}
        public string Motorsport {get; set;}
        public string Fightingandmartialart {get; set;}
        public string Snowsport {get; set;}
        public string Rugby {get; set;}
        public string Yoga {get; set;}
        public string Exercise {get; set;}
        public string Softball {get; set;}
        public string Wrestling {get; set;}
        public string Lacrosse {get; set;}
        public string Cheer {get; set;}
        public string Camp {get; set;}
        public string Weightlifting {get; set;}
        public string Trackandfield {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}