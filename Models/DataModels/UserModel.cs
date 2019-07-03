using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PartyFinder.Models
{
    public class User : DataModel
    {
        [Key]
        public int UserId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [EmailAddress]
        [Required]
        public string Email {get;set;}
        [DataType(DataType.Password)]
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression("^((?=.{8,})(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[!@#$%^&+=])).*$", ErrorMessage = "Passwords must be at least 8 characters and contain at  least 1 number, 1 letter, and a special character.")]
        public string Password {get; set;}
        public List<Event> Events {get;set;}
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

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get; set;}
    }
}