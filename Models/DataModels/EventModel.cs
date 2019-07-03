using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class Event : DataModel
    {
        [Key]
        public int EventId {get;set;}
        [Required]
        public string Title {get; set;}
        [Required]
        public string Genre {get; set;}
        [Required]
        public string Category {get;set;}
        [Required]
        public string Subcategory {get;set;}
        [Required]
        [FutureDate]
        [DataType(DataType.DateTime)]
        public DateTime StartDate {get;set;}
        [Required]
        [FutureDate]
        [DataType(DataType.DateTime)]
        public DateTime EndDate {get;set;}
        [Required]
        [MaxLength(500, ErrorMessage="Can not be longer than 500 characters!")]
        public string Description {get;set;}
        [Required]
        public string Location {get;set;}
        public int UserId {get;set;}
        public User User {get;set;}
        public List<RSVP> RSVPs {get;set;}
        public List<Art> Arts {get;set;}
        public List<AutoAndBoatAndAir> AutoAndBoatAndAirs {get;set;}
        public List<Business> Businesses {get;set;}
        public List<CharityAndCauses> CharityAndCauseses {get;set;}
        public List<Community> Communities {get;set;}
        public List<FamilyAndEducation> FamilyAndEducations {get;set;}
        public List<Fashion> Fashions {get;set;}
        public List<FilmAndMedia> FilmAndMedias {get;set;}
        public List<FoodAndDrink> FoodAndDrinks {get;set;}
        public List<Government> Governments {get;set;}
        public List<Health> Healths {get;set;}
        public List<Hobby> Hobbies {get;set;}
        public List<Holiday> Holidaies {get;set;}
        public List<HomeAndLifestyle> HomeAndLifestyles {get;set;}
        public List<Music> Musics {get;set;}
        public List<SchoolActivity> SchoolActivities {get;set;}
        public List<ScienceAndTech> ScienceAndTechs {get;set;}
        public List<Spirituality> Spiritualities {get;set;}
        public List<SportAndFitness> SportAndFitnesses {get;set;}
        public List<TravelAndOutdoor> TravelAndOutdoors {get;set;}
    }
}