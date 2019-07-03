using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyFinder.Migrations
{
    public partial class OneMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Subcategory = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    Location = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Events_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Theater = table.Column<string>(nullable: true),
                    Musical = table.Column<string>(nullable: true),
                    Ballet = table.Column<string>(nullable: true),
                    Dance = table.Column<string>(nullable: true),
                    Opera = table.Column<string>(nullable: true),
                    Orchestra = table.Column<string>(nullable: true),
                    Craft = table.Column<string>(nullable: true),
                    Fineart = table.Column<string>(nullable: true),
                    Literaryart = table.Column<string>(nullable: true),
                    Comedy = table.Column<string>(nullable: true),
                    Sculpture = table.Column<string>(nullable: true),
                    Painting = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    Jewelry = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arts_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Arts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutoAndBoatAndAirs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Auto = table.Column<string>(nullable: true),
                    Motorcycle_atv = table.Column<string>(nullable: true),
                    Boat = table.Column<string>(nullable: true),
                    Air = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoAndBoatAndAirs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutoAndBoatAndAirs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoAndBoatAndAirs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Startupandsmallbusiness = table.Column<string>(nullable: true),
                    Finance = table.Column<string>(nullable: true),
                    Environmentandsustainability = table.Column<string>(nullable: true),
                    Educators = table.Column<string>(nullable: true),
                    Realestate = table.Column<string>(nullable: true),
                    Nonprofitandngos = table.Column<string>(nullable: true),
                    Salesandmarketing = table.Column<string>(nullable: true),
                    Media = table.Column<string>(nullable: true),
                    Design = table.Column<string>(nullable: true),
                    Career = table.Column<string>(nullable: true),
                    Investment = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Businesses_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Businesses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharityAndCauseses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Animalwelfare = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    Healthcare = table.Column<string>(nullable: true),
                    Humanright = table.Column<string>(nullable: true),
                    Internationalaid = table.Column<string>(nullable: true),
                    Poverty = table.Column<string>(nullable: true),
                    Dissasterrelief = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharityAndCauseses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CharityAndCauseses_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharityAndCauseses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Province = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    City_town = table.Column<string>(nullable: true),
                    Lgbt = table.Column<string>(nullable: true),
                    Medieval = table.Column<string>(nullable: true),
                    Renaissance = table.Column<string>(nullable: true),
                    Heritage = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Historic = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communities_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Communities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FamilyAndEducations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Education = table.Column<string>(nullable: true),
                    Alumni = table.Column<string>(nullable: true),
                    Parenting = table.Column<string>(nullable: true),
                    Baby = table.Column<string>(nullable: true),
                    Childrenandyouth = table.Column<string>(nullable: true),
                    Parentsassociation = table.Column<string>(nullable: true),
                    Reunion = table.Column<string>(nullable: true),
                    Seniorcitizen = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamilyAndEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FamilyAndEducations_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FamilyAndEducations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fashions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Fashions = table.Column<string>(nullable: true),
                    Accessories = table.Column<string>(nullable: true),
                    Bridal = table.Column<string>(nullable: true),
                    Beauty = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fashions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fashions_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fashions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmAndMedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Tv = table.Column<string>(nullable: true),
                    Film = table.Column<string>(nullable: true),
                    Anime = table.Column<string>(nullable: true),
                    Gaming = table.Column<string>(nullable: true),
                    Comic = table.Column<string>(nullable: true),
                    Adult = table.Column<string>(nullable: true),
                    Comedy = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAndMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilmAndMedias_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmAndMedias_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodAndDrinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Beer = table.Column<string>(nullable: true),
                    Wine = table.Column<string>(nullable: true),
                    Food = table.Column<string>(nullable: true),
                    Spirits = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAndDrinks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodAndDrinks_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAndDrinks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Governments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Republicanparty = table.Column<string>(nullable: true),
                    Democraticparty = table.Column<string>(nullable: true),
                    Otherparty = table.Column<string>(nullable: true),
                    Nonpartisan = table.Column<string>(nullable: true),
                    Federalgovernment = table.Column<string>(nullable: true),
                    Stategovernment = table.Column<string>(nullable: true),
                    County_municipalgovernment = table.Column<string>(nullable: true),
                    Military = table.Column<string>(nullable: true),
                    Internationalaffair = table.Column<string>(nullable: true),
                    Nationalsecurity = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Governments_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Governments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Healths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Personalhealth = table.Column<string>(nullable: true),
                    Mentalhealth = table.Column<string>(nullable: true),
                    Medical = table.Column<string>(nullable: true),
                    Spa = table.Column<string>(nullable: true),
                    Yoga = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Healths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Healths_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Healths_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Anime_Comic = table.Column<string>(nullable: true),
                    Gaming = table.Column<string>(nullable: true),
                    Diy = table.Column<string>(nullable: true),
                    Photography = table.Column<string>(nullable: true),
                    Knitting = table.Column<string>(nullable: true),
                    Books = table.Column<string>(nullable: true),
                    Adult = table.Column<string>(nullable: true),
                    Drawingandpainting = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hobbies_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hobbies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Holidaies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Stpatricksday = table.Column<string>(nullable: true),
                    Easter = table.Column<string>(nullable: true),
                    Independenceday = table.Column<string>(nullable: true),
                    Halloween_haunt = table.Column<string>(nullable: true),
                    Thanksgiving = table.Column<string>(nullable: true),
                    Christmas = table.Column<string>(nullable: true),
                    Channukah = table.Column<string>(nullable: true),
                    Fallevent = table.Column<string>(nullable: true),
                    Newyearseve = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Holidaies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Holidaies_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Holidaies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeAndLifestyles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Dating = table.Column<string>(nullable: true),
                    Petsandanimal = table.Column<string>(nullable: true),
                    Homeandgarden = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeAndLifestyles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeAndLifestyles_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HomeAndLifestyles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Alternative = table.Column<string>(nullable: true),
                    Bluesandjazz = table.Column<string>(nullable: true),
                    Classical = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Cultural = table.Column<string>(nullable: true),
                    Edm_electronic = table.Column<string>(nullable: true),
                    Folk = table.Column<string>(nullable: true),
                    Hiphopp_rap = table.Column<string>(nullable: true),
                    Indie = table.Column<string>(nullable: true),
                    Latin = table.Column<string>(nullable: true),
                    Metal = table.Column<string>(nullable: true),
                    Opera = table.Column<string>(nullable: true),
                    Pop = table.Column<string>(nullable: true),
                    Randb = table.Column<string>(nullable: true),
                    Reggae = table.Column<string>(nullable: true),
                    Religious_spiritual = table.Column<string>(nullable: true),
                    Rock = table.Column<string>(nullable: true),
                    Top40 = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musics_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musics_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    RSVPId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.RSVPId);
                    table.ForeignKey(
                        name: "FK_RSVPs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RSVPs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SchoolActivities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Dinner = table.Column<string>(nullable: true),
                    Fundraiser = table.Column<string>(nullable: true),
                    Raffle = table.Column<string>(nullable: true),
                    Afterschoolcare = table.Column<string>(nullable: true),
                    Parking = table.Column<string>(nullable: true),
                    Pablicspeaker = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolActivities_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SchoolActivities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScienceAndTechs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Medicine = table.Column<string>(nullable: true),
                    Science = table.Column<string>(nullable: true),
                    Biotech = table.Column<string>(nullable: true),
                    Hightech = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Socialmedia = table.Column<string>(nullable: true),
                    Robotic = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScienceAndTechs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScienceAndTechs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScienceAndTechs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spiritualities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Christianity = table.Column<string>(nullable: true),
                    Judaism = table.Column<string>(nullable: true),
                    Islam = table.Column<string>(nullable: true),
                    Mormonism = table.Column<string>(nullable: true),
                    Buddism = table.Column<string>(nullable: true),
                    Sikhism = table.Column<string>(nullable: true),
                    Easternreligion = table.Column<string>(nullable: true),
                    Mysticismandoccult = table.Column<string>(nullable: true),
                    Newage = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spiritualities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Spiritualities_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Spiritualities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SportAndFitnesses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Running = table.Column<string>(nullable: true),
                    Walking = table.Column<string>(nullable: true),
                    Cycling = table.Column<string>(nullable: true),
                    Mountainbiking = table.Column<string>(nullable: true),
                    Obstacle = table.Column<string>(nullable: true),
                    Basketball = table.Column<string>(nullable: true),
                    Football = table.Column<string>(nullable: true),
                    Baseball = table.Column<string>(nullable: true),
                    Soccer = table.Column<string>(nullable: true),
                    Golf = table.Column<string>(nullable: true),
                    Volleyball = table.Column<string>(nullable: true),
                    Tennis = table.Column<string>(nullable: true),
                    Swimmingandwatersport = table.Column<string>(nullable: true),
                    Hockey = table.Column<string>(nullable: true),
                    Motorsport = table.Column<string>(nullable: true),
                    Fightingandmartialart = table.Column<string>(nullable: true),
                    Snowsport = table.Column<string>(nullable: true),
                    Rugby = table.Column<string>(nullable: true),
                    FootYogaball = table.Column<string>(nullable: true),
                    Exercise = table.Column<string>(nullable: true),
                    Softball = table.Column<string>(nullable: true),
                    Wrestling = table.Column<string>(nullable: true),
                    Lacrosse = table.Column<string>(nullable: true),
                    Cheer = table.Column<string>(nullable: true),
                    Camp = table.Column<string>(nullable: true),
                    Weightlifting = table.Column<string>(nullable: true),
                    Trackandfield = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SportAndFitnesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SportAndFitnesses_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SportAndFitnesses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelAndOutdoors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Hiking = table.Column<string>(nullable: true),
                    Rafting = table.Column<string>(nullable: true),
                    Kayaking = table.Column<string>(nullable: true),
                    Conoeing = table.Column<string>(nullable: true),
                    Climbing = table.Column<string>(nullable: true),
                    Travel = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    EventId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelAndOutdoors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelAndOutdoors_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelAndOutdoors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arts_EventId",
                table: "Arts",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Arts_UserId",
                table: "Arts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoAndBoatAndAirs_EventId",
                table: "AutoAndBoatAndAirs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoAndBoatAndAirs_UserId",
                table: "AutoAndBoatAndAirs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_EventId",
                table: "Businesses",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_UserId",
                table: "Businesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityAndCauseses_EventId",
                table: "CharityAndCauseses",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CharityAndCauseses_UserId",
                table: "CharityAndCauseses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_EventId",
                table: "Communities",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Communities_UserId",
                table: "Communities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_UserId",
                table: "Events",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyAndEducations_EventId",
                table: "FamilyAndEducations",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_FamilyAndEducations_UserId",
                table: "FamilyAndEducations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fashions_EventId",
                table: "Fashions",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Fashions_UserId",
                table: "Fashions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndMedias_EventId",
                table: "FilmAndMedias",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndMedias_UserId",
                table: "FilmAndMedias",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAndDrinks_EventId",
                table: "FoodAndDrinks",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAndDrinks_UserId",
                table: "FoodAndDrinks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Governments_EventId",
                table: "Governments",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Governments_UserId",
                table: "Governments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_EventId",
                table: "Healths",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Healths_UserId",
                table: "Healths",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_EventId",
                table: "Hobbies",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserId",
                table: "Hobbies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidaies_EventId",
                table: "Holidaies",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Holidaies_UserId",
                table: "Holidaies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeAndLifestyles_EventId",
                table: "HomeAndLifestyles",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeAndLifestyles_UserId",
                table: "HomeAndLifestyles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_EventId",
                table: "Musics",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Musics_UserId",
                table: "Musics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_EventId",
                table: "RSVPs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_UserId",
                table: "RSVPs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolActivities_EventId",
                table: "SchoolActivities",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolActivities_UserId",
                table: "SchoolActivities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceAndTechs_EventId",
                table: "ScienceAndTechs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_ScienceAndTechs_UserId",
                table: "ScienceAndTechs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Spiritualities_EventId",
                table: "Spiritualities",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_Spiritualities_UserId",
                table: "Spiritualities",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SportAndFitnesses_EventId",
                table: "SportAndFitnesses",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_SportAndFitnesses_UserId",
                table: "SportAndFitnesses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelAndOutdoors_EventId",
                table: "TravelAndOutdoors",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelAndOutdoors_UserId",
                table: "TravelAndOutdoors",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arts");

            migrationBuilder.DropTable(
                name: "AutoAndBoatAndAirs");

            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "CharityAndCauseses");

            migrationBuilder.DropTable(
                name: "Communities");

            migrationBuilder.DropTable(
                name: "FamilyAndEducations");

            migrationBuilder.DropTable(
                name: "Fashions");

            migrationBuilder.DropTable(
                name: "FilmAndMedias");

            migrationBuilder.DropTable(
                name: "FoodAndDrinks");

            migrationBuilder.DropTable(
                name: "Governments");

            migrationBuilder.DropTable(
                name: "Healths");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Holidaies");

            migrationBuilder.DropTable(
                name: "HomeAndLifestyles");

            migrationBuilder.DropTable(
                name: "Musics");

            migrationBuilder.DropTable(
                name: "RSVPs");

            migrationBuilder.DropTable(
                name: "SchoolActivities");

            migrationBuilder.DropTable(
                name: "ScienceAndTechs");

            migrationBuilder.DropTable(
                name: "Spiritualities");

            migrationBuilder.DropTable(
                name: "SportAndFitnesses");

            migrationBuilder.DropTable(
                name: "TravelAndOutdoors");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
