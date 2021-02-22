﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RoyaleTrackerAPI.Models;

namespace RoyaleTrackerAPI.Migrations
{
    [DbContext(typeof(TRContext))]
    partial class TRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RoyaleTrackerClasses.Battle", b =>
                {
                    b.Property<int>("BattleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BattleTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeckSelection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GameModeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLadderTournament")
                        .HasColumnType("bit");

                    b.Property<int>("Team1Crowns")
                        .HasColumnType("int");

                    b.Property<int>("Team1DeckAId")
                        .HasColumnType("int");

                    b.Property<int>("Team1DeckBId")
                        .HasColumnType("int");

                    b.Property<int>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team1KingTowerHp")
                        .HasColumnType("int");

                    b.Property<string>("Team1Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team1PrincessTowerHpA")
                        .HasColumnType("int");

                    b.Property<int>("Team1PrincessTowerHpB")
                        .HasColumnType("int");

                    b.Property<int>("Team1StartingTrophies")
                        .HasColumnType("int");

                    b.Property<int>("Team1TrophyChange")
                        .HasColumnType("int");

                    b.Property<bool>("Team1Win")
                        .HasColumnType("bit");

                    b.Property<int>("Team2Crowns")
                        .HasColumnType("int");

                    b.Property<int>("Team2DeckAId")
                        .HasColumnType("int");

                    b.Property<int>("Team2DeckBId")
                        .HasColumnType("int");

                    b.Property<int>("Team2Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2KingTowerHp")
                        .HasColumnType("int");

                    b.Property<string>("Team2Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Team2PrincessTowerHpA")
                        .HasColumnType("int");

                    b.Property<int>("Team2PrincessTowerHpB")
                        .HasColumnType("int");

                    b.Property<int>("Team2StartingTrophies")
                        .HasColumnType("int");

                    b.Property<int>("Team2TrophyChange")
                        .HasColumnType("int");

                    b.Property<bool>("Team2Win")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BattleId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.Card", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BadgeId")
                        .HasColumnType("int");

                    b.Property<int>("ClanChestLevel")
                        .HasColumnType("int");

                    b.Property<string>("ClanChestStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClanScore")
                        .HasColumnType("int");

                    b.Property<int>("ClanWarTrophies")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DonationsPerWeek")
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Members")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredTrophies")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Card1Id")
                        .HasColumnType("int");

                    b.Property<int>("Card2Id")
                        .HasColumnType("int");

                    b.Property<int>("Card3Id")
                        .HasColumnType("int");

                    b.Property<int>("Card4Id")
                        .HasColumnType("int");

                    b.Property<int>("Card5Id")
                        .HasColumnType("int");

                    b.Property<int>("Card6Id")
                        .HasColumnType("int");

                    b.Property<int>("Card7Id")
                        .HasColumnType("int");

                    b.Property<int>("Card8Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Decks");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.GameMode", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameModes");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BestTrophies")
                        .HasColumnType("int");

                    b.Property<int>("CardsDiscovered")
                        .HasColumnType("int");

                    b.Property<int>("ClanCardsCollected")
                        .HasColumnType("int");

                    b.Property<string>("ClanTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentDeckId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentFavouriteCardId")
                        .HasColumnType("int");

                    b.Property<int>("Donations")
                        .HasColumnType("int");

                    b.Property<int>("DonationsReceived")
                        .HasColumnType("int");

                    b.Property<int>("ExpLevel")
                        .HasColumnType("int");

                    b.Property<string>("LastSeen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Losses")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarPoints")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<int>("TotalDonations")
                        .HasColumnType("int");

                    b.Property<int>("Trophies")
                        .HasColumnType("int");

                    b.Property<string>("UpdateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wins")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.Team", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tag2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoVTwo")
                        .HasColumnType("bit");

                    b.HasKey("TeamId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("RoyaleTrackerClasses.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
