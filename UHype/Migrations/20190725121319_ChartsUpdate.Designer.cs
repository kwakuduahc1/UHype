﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UHype.Model;

namespace UHype.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190725121319_ChartsUpdate")]
    partial class ChartsUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UHype.Model.Anthropometries", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<double>("AbdCirc");

                    b.Property<double>("Bmi");

                    b.Property<double>("Diastole");

                    b.Property<double>("Fat");

                    b.Property<double>("Height");

                    b.Property<double>("MUAC");

                    b.Property<double>("Systole");

                    b.Property<double>("Weight");

                    b.HasKey("DemographyID");

                    b.ToTable("Anthropometries");
                });

            modelBuilder.Entity("UHype.Model.BpHistory", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<DateTime>("DateChecked");

                    b.Property<double>("Diastole");

                    b.Property<double>("Systole");

                    b.HasKey("DemographyID");

                    b.ToTable("BpHistory");
                });

            modelBuilder.Entity("UHype.Model.Charts", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<bool>("AtrialFib");

                    b.Property<double>("BUN");

                    b.Property<bool>("BpControl");

                    b.Property<bool>("CAD");

                    b.Property<bool>("CKD");

                    b.Property<bool>("Cholesterol");

                    b.Property<double>("Creatinine");

                    b.Property<bool>("Dementia");

                    b.Property<bool>("Diabetes");

                    b.Property<bool>("Diabetics");

                    b.Property<bool>("FollowUp");

                    b.Property<double>("HDL");

                    b.Property<bool>("HeartFail");

                    b.Property<bool>("HyperLip");

                    b.Property<bool>("Hypertensives");

                    b.Property<double>("LDL");

                    b.Property<double>("LabCholesterol");

                    b.Property<DateTime>("LabDate");

                    b.Property<string>("OtherMeds");

                    b.Property<bool>("Pain");

                    b.Property<bool>("Platelets");

                    b.Property<bool>("Prostate");

                    b.Property<bool>("RecordedPulseBp");

                    b.Property<bool>("Stroke");

                    b.Property<double>("Trigs");

                    b.HasKey("DemographyID");

                    b.ToTable("Charts");
                });

            modelBuilder.Entity("UHype.Model.Demography", b =>
                {
                    b.Property<int>("DemographyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Ethnicity")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Facility")
                        .HasMaxLength(50);

                    b.Property<byte>("Gender");

                    b.Property<byte>("IsSelf");

                    b.Property<string>("Marital")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("DemographyID");

                    b.ToTable("Demography");
                });

            modelBuilder.Entity("UHype.Model.Labs", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<double>("Bun");

                    b.Property<double>("Cholesterol");

                    b.Property<double>("Creat");

                    b.Property<bool>("FollowUp");

                    b.Property<double>("Hdl");

                    b.Property<double>("Ldl");

                    b.Property<byte>("PhysicianDocs");

                    b.Property<double>("Trigly");

                    b.HasKey("DemographyID");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("UHype.Model.QualityAssessments", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<byte>("AccomplishEm");

                    b.Property<byte>("AccomplishLess");

                    b.Property<byte>("BathingSelf");

                    b.Property<byte>("BeenHappy");

                    b.Property<byte>("Bending");

                    b.Property<byte>("BodyPainIn4");

                    b.Property<byte>("BodyPainInHouse");

                    b.Property<byte>("Climbing");

                    b.Property<byte>("Compared");

                    b.Property<byte>("CutDown");

                    b.Property<byte>("CutDownEm");

                    b.Property<byte>("EmotionInterfere");

                    b.Property<byte>("FeelTired");

                    b.Property<byte>("HadDiff");

                    b.Property<byte>("HasEnergy");

                    b.Property<byte>("HasPep");

                    b.Property<byte>("HealthScale");

                    b.Property<byte>("IsDump");

                    b.Property<byte>("IsExcellent");

                    b.Property<byte>("IsNervous");

                    b.Property<byte>("Moderate");

                    b.Property<byte>("SickEasier");

                    b.Property<byte>("SocialInterfere");

                    b.Property<byte>("ToGetWorse");

                    b.Property<byte>("VeryHealthy");

                    b.Property<byte>("Vigorous");

                    b.Property<byte>("WalkingBlocks");

                    b.Property<byte>("WalkingMile");

                    b.Property<byte>("WalkingOne");

                    b.Property<byte>("WasCareful");

                    b.Property<byte>("WasDownhearted");

                    b.Property<byte>("WasPeaceful");

                    b.Property<byte>("WasWornOut");

                    b.Property<byte>("WereLimited");

                    b.HasKey("DemographyID");

                    b.ToTable("QualityAssessments");
                });

            modelBuilder.Entity("UHype.Model.SecondSections", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<bool>("Admission");

                    b.Property<bool>("Amlodipine");

                    b.Property<bool>("Atenolol");

                    b.Property<bool>("AtrialFib");

                    b.Property<bool>("Bendro");

                    b.Property<bool>("Bisoprolol");

                    b.Property<bool>("CAD");

                    b.Property<bool>("CKD");

                    b.Property<byte>("CareFacilities");

                    b.Property<byte>("ChronicDisease");

                    b.Property<bool>("ClosePharmNHIS");

                    b.Property<bool>("Degree1");

                    b.Property<bool>("Dementia");

                    b.Property<bool>("Diabetes");

                    b.Property<byte>("DoGetMedsFromAll");

                    b.Property<byte>("DrTellState");

                    b.Property<bool>("Forgotten");

                    b.Property<bool>("Frusemide");

                    b.Property<bool>("HCTZ");

                    b.Property<byte>("HPTMeds");

                    b.Property<bool>("HasAdmitedIn12");

                    b.Property<byte>("HasNHIS");

                    b.Property<byte>("HasPressure");

                    b.Property<byte>("HasSpecialClinic");

                    b.Property<bool>("HeartFail");

                    b.Property<bool>("HospClosePharmLater");

                    b.Property<bool>("HospClosePharmNHIS");

                    b.Property<byte>("HospTime");

                    b.Property<bool>("HospitalFee");

                    b.Property<bool>("HospitalNHIS");

                    b.Property<bool>("Hydralazine");

                    b.Property<bool>("HyperLip");

                    b.Property<bool>("IsControlled");

                    b.Property<byte>("LabWork");

                    b.Property<bool>("Lisinopril");

                    b.Property<bool>("Losarta");

                    b.Property<bool>("MeasureAtHome");

                    b.Property<bool>("Methlydopa");

                    b.Property<byte>("MissAppointment");

                    b.Property<string>("OtherMeds")
                        .HasMaxLength(50);

                    b.Property<string>("Others")
                        .HasMaxLength(50);

                    b.Property<string>("OthersCND")
                        .HasMaxLength(50);

                    b.Property<bool>("Pain");

                    b.Property<bool>("Pharmacy");

                    b.Property<bool>("Prostate");

                    b.Property<byte>("RelativesHBP");

                    b.Property<byte>("RunOutMeds");

                    b.Property<byte>("SameDoctor");

                    b.Property<bool>("Screening");

                    b.Property<byte>("StaffAdvise");

                    b.Property<bool>("Stroke");

                    b.Property<byte>("TakeDrugsBeforeVisit");

                    b.Property<bool>("Visit");

                    b.HasKey("DemographyID");

                    b.ToTable("SecondSections");
                });

            modelBuilder.Entity("UHype.Model.SocioFactors", b =>
                {
                    b.Property<int>("DemographyID");

                    b.Property<byte>("BelieveDiet");

                    b.Property<bool>("Cigarette");

                    b.Property<string>("Concerns")
                        .HasMaxLength(50);

                    b.Property<bool>("CurrentDrink");

                    b.Property<bool>("DieEarly");

                    b.Property<string>("DoctorWish")
                        .HasMaxLength(100);

                    b.Property<bool>("EverDrunk");

                    b.Property<bool>("FeelSad");

                    b.Property<bool>("FinanceDiffs");

                    b.Property<bool>("HasAssitance");

                    b.Property<bool>("HasConcerns");

                    b.Property<string>("HerbReason")
                        .HasMaxLength(100);

                    b.Property<byte>("HowLongAlc");

                    b.Property<byte>("HowLongCig");

                    b.Property<bool>("IsRiskBlind");

                    b.Property<bool>("IsRiskDiabetes");

                    b.Property<bool>("IsRiskHeartAttack");

                    b.Property<bool>("IsRiskKidney");

                    b.Property<bool>("IsRiskStroke");

                    b.Property<byte>("NumberPerDay");

                    b.Property<byte>("OftenPhysical");

                    b.Property<string>("Others");

                    b.Property<bool>("PhysicalActivity");

                    b.Property<bool>("Running");

                    b.Property<byte>("SeenDietician");

                    b.Property<byte>("SpecialDiet");

                    b.Property<bool>("StillHerbal");

                    b.Property<byte>("TakesHerbal");

                    b.Property<byte>("TimePhysical");

                    b.Property<byte>("UnitsPerWeek");

                    b.Property<bool>("Walking");

                    b.HasKey("DemographyID");

                    b.ToTable("SocioFactors");
                });

            modelBuilder.Entity("UHype.Model.AppUsers", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Facility")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Team")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasDiscriminator().HasValue("AppUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.Anthropometries", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("Anthropometries")
                        .HasForeignKey("UHype.Model.Anthropometries", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.BpHistory", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("BpHistory")
                        .HasForeignKey("UHype.Model.BpHistory", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.Charts", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("Charts")
                        .HasForeignKey("UHype.Model.Charts", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.Labs", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("Labs")
                        .HasForeignKey("UHype.Model.Labs", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.QualityAssessments", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("QualityAssessments")
                        .HasForeignKey("UHype.Model.QualityAssessments", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.SecondSections", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("SecondSections")
                        .HasForeignKey("UHype.Model.SecondSections", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UHype.Model.SocioFactors", b =>
                {
                    b.HasOne("UHype.Model.Demography", "Demography")
                        .WithOne("SocioFactors")
                        .HasForeignKey("UHype.Model.SocioFactors", "DemographyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
