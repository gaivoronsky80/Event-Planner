using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class RSVP : DataModel
    {
        [Key]
        public int RSVPId {get;set;}

        public int UserId {get;set;}

        public User Users {get;set;}
        public int EventId {get;set;}
        public Event Events {get;set;}
    }
}