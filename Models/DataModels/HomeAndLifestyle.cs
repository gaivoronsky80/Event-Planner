using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class HomeAndLifestyle : DataModel
    {
        [Key]
        public int Id {get;set;}
        public string Dating {get; set;}
        public string Petsandanimal {get; set;}
        public string Homeandgarden {get; set;}
        public string Other {get; set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}