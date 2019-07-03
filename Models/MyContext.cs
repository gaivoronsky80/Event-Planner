using Microsoft.EntityFrameworkCore; 

namespace PartyFinder.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        
        // "users" table is represented by this DbSet "Users"
        public DbSet<User> Users {get;set;}
        public DbSet<Event> Events {get;set;}
        public DbSet<RSVP> RSVPs {get;set;}
        public DbSet<Art> Arts {get;set;}
        public DbSet<AutoAndBoatAndAir> AutoAndBoatAndAirs {get;set;}
        public DbSet<Business> Businesses {get;set;}
        public DbSet<CharityAndCauses> CharityAndCauseses {get;set;}
        public DbSet<Community> Communities {get;set;}
        public DbSet<FamilyAndEducation> FamilyAndEducations {get;set;}
        public DbSet<Fashion> Fashions {get;set;}
        public DbSet<FilmAndMedia> FilmAndMedias {get;set;}
        public DbSet<FoodAndDrink> FoodAndDrinks {get;set;}
        public DbSet<Government> Governments {get;set;}
        public DbSet<Health> Healths {get;set;}
        public DbSet<Hobby> Hobbies {get;set;}
        public DbSet<Holiday> Holidaies {get;set;}
        public DbSet<HomeAndLifestyle> HomeAndLifestyles {get;set;}
        public DbSet<Music> Musics {get;set;}
        public DbSet<SchoolActivity> SchoolActivities {get;set;}

        public DbSet<ScienceAndTech> ScienceAndTechs {get;set;}
        public DbSet<Spirituality> Spiritualities {get;set;}
        public DbSet<SportAndFitness> SportAndFitnesses {get;set;}
        public DbSet<TravelAndOutdoor> TravelAndOutdoors {get;set;}
    }
}