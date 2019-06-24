using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UHype.Migrations
{
    public partial class GuidToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Team = table.Column<string>(maxLength: 10, nullable: true),
                    Facility = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Demography",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsSelf = table.Column<byte>(nullable: false),
                    Facility = table.Column<string>(maxLength: 50, nullable: true),
                    Age = table.Column<string>(maxLength: 6, nullable: false),
                    Marital = table.Column<string>(maxLength: 20, nullable: false),
                    Religion = table.Column<string>(maxLength: 20, nullable: false),
                    Ethnicity = table.Column<string>(maxLength: 20, nullable: false),
                    Occupation = table.Column<string>(maxLength: 30, nullable: false),
                    Education = table.Column<string>(maxLength: 20, nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demography", x => x.DemographyID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Anthropometries",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    Height = table.Column<double>(nullable: false),
                    Weight = table.Column<double>(nullable: false),
                    Bmi = table.Column<double>(nullable: false),
                    MUAC = table.Column<double>(nullable: false),
                    AbdCirc = table.Column<double>(nullable: false),
                    Systole = table.Column<double>(nullable: false),
                    Diastole = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anthropometries", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_Anthropometries_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BpHistory",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    Systole = table.Column<double>(nullable: false),
                    Diastole = table.Column<double>(nullable: false),
                    DateChecked = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BpHistory", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_BpHistory_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Charts",
                columns: table => new
                {
                    ChartsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DemographyID = table.Column<int>(nullable: false),
                    Comorbidity = table.Column<string>(maxLength: 200, nullable: true),
                    Medication = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Charts", x => x.ChartsID);
                    table.ForeignKey(
                        name: "FK_Charts_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Labs",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    Cholesterol = table.Column<double>(nullable: false),
                    Hdl = table.Column<double>(nullable: false),
                    Ldl = table.Column<double>(nullable: false),
                    Trigly = table.Column<double>(nullable: false),
                    Bun = table.Column<double>(nullable: false),
                    Creat = table.Column<double>(nullable: false),
                    PhysicianDocs = table.Column<byte>(nullable: false),
                    FollowUp = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labs", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_Labs_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QualityAssessments",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    HealthScale = table.Column<byte>(nullable: false),
                    Compared = table.Column<byte>(nullable: false),
                    Vigorous = table.Column<byte>(nullable: false),
                    Moderate = table.Column<byte>(nullable: false),
                    Climbing = table.Column<byte>(nullable: false),
                    Bending = table.Column<byte>(nullable: false),
                    WalkingMile = table.Column<byte>(nullable: false),
                    WalkingBlocks = table.Column<byte>(nullable: false),
                    WalkingOne = table.Column<byte>(nullable: false),
                    BathingSelf = table.Column<byte>(nullable: false),
                    CutDown = table.Column<byte>(nullable: false),
                    AccomplishLess = table.Column<byte>(nullable: false),
                    WereLimited = table.Column<byte>(nullable: false),
                    HadDiff = table.Column<byte>(nullable: false),
                    CutDownEm = table.Column<byte>(nullable: false),
                    AccomplishEm = table.Column<byte>(nullable: false),
                    WasCareful = table.Column<byte>(nullable: false),
                    EmotionInterfere = table.Column<byte>(nullable: false),
                    BodyPainIn4 = table.Column<byte>(nullable: false),
                    BodyPainInHouse = table.Column<byte>(nullable: false),
                    HasPep = table.Column<byte>(nullable: false),
                    IsNervous = table.Column<byte>(nullable: false),
                    IsDump = table.Column<byte>(nullable: false),
                    WasPeaceful = table.Column<byte>(nullable: false),
                    HasEnergy = table.Column<byte>(nullable: false),
                    WasDownhearted = table.Column<byte>(nullable: false),
                    WasWornOut = table.Column<byte>(nullable: false),
                    BeenHappy = table.Column<byte>(nullable: false),
                    FeelTired = table.Column<byte>(nullable: false),
                    SocialInterfere = table.Column<byte>(nullable: false),
                    SickEasier = table.Column<byte>(nullable: false),
                    VeryHealthy = table.Column<byte>(nullable: false),
                    ToGetWorse = table.Column<byte>(nullable: false),
                    IsExcellent = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QualityAssessments", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_QualityAssessments_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SecondSections",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    HasPressure = table.Column<byte>(nullable: false),
                    Screening = table.Column<bool>(nullable: false),
                    Visit = table.Column<bool>(nullable: false),
                    Pharmacy = table.Column<bool>(nullable: false),
                    Admission = table.Column<bool>(nullable: false),
                    Forgotten = table.Column<bool>(nullable: false),
                    Others = table.Column<string>(maxLength: 50, nullable: true),
                    IsControlled = table.Column<bool>(nullable: false),
                    HasAdmiitedIn12 = table.Column<bool>(nullable: false),
                    MeasureAtHome = table.Column<bool>(nullable: false),
                    RelativesHBP = table.Column<byte>(nullable: false),
                    Degree1 = table.Column<bool>(nullable: false),
                    ChronicDisease = table.Column<byte>(nullable: false),
                    Diabetes = table.Column<bool>(nullable: false),
                    CKD = table.Column<bool>(nullable: false),
                    HeartFail = table.Column<bool>(nullable: false),
                    Stroke = table.Column<bool>(nullable: false),
                    Dementia = table.Column<bool>(nullable: false),
                    AtrialFib = table.Column<bool>(nullable: false),
                    Prostate = table.Column<bool>(nullable: false),
                    CAD = table.Column<bool>(nullable: false),
                    HyperLip = table.Column<bool>(nullable: false),
                    Pain = table.Column<bool>(nullable: false),
                    OthersCND = table.Column<string>(maxLength: 50, nullable: true),
                    HPTMeds = table.Column<byte>(nullable: false),
                    Amlodipine = table.Column<bool>(nullable: false),
                    Lisinopril = table.Column<bool>(nullable: false),
                    Losarta = table.Column<bool>(nullable: false),
                    Bendro = table.Column<bool>(nullable: false),
                    HCTZ = table.Column<bool>(nullable: false),
                    Atenolol = table.Column<bool>(nullable: false),
                    Bisoprolol = table.Column<bool>(nullable: false),
                    Methlydopa = table.Column<bool>(nullable: false),
                    Frusemide = table.Column<bool>(nullable: false),
                    Hydralazine = table.Column<bool>(nullable: false),
                    OtherMeds = table.Column<string>(maxLength: 50, nullable: true),
                    HospitalNHIS = table.Column<bool>(nullable: false),
                    HospClosePharmNHIS = table.Column<bool>(nullable: false),
                    HospClosePharmLater = table.Column<bool>(nullable: false),
                    ClosePharmNHIS = table.Column<bool>(nullable: false),
                    HospitalFee = table.Column<bool>(nullable: false),
                    LabWork = table.Column<byte>(nullable: false),
                    HasNHIS = table.Column<byte>(nullable: false),
                    CareFacilities = table.Column<byte>(nullable: false),
                    DoGetMedsFromAll = table.Column<byte>(nullable: false),
                    HasSpecialClinic = table.Column<byte>(nullable: false),
                    SameDoctor = table.Column<byte>(nullable: false),
                    DrTellState = table.Column<byte>(nullable: false),
                    StaffAdvise = table.Column<byte>(nullable: false),
                    RunOutMeds = table.Column<byte>(nullable: false),
                    MissAppointment = table.Column<byte>(nullable: false),
                    TakeDrugsBeforeVisit = table.Column<byte>(nullable: false),
                    HospTime = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondSections", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_SecondSections_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocioFactors",
                columns: table => new
                {
                    DemographyID = table.Column<int>(nullable: false),
                    FinanceDiffs = table.Column<bool>(nullable: false),
                    HasConcerns = table.Column<bool>(nullable: false),
                    Concerns = table.Column<string>(maxLength: 50, nullable: true),
                    HasAssitance = table.Column<bool>(nullable: false),
                    TakesHerbal = table.Column<byte>(nullable: false),
                    SeenDietician = table.Column<byte>(nullable: false),
                    BelieveDiet = table.Column<byte>(nullable: false),
                    SpecialDiet = table.Column<byte>(nullable: false),
                    PhysicalActivity = table.Column<bool>(nullable: false),
                    Walking = table.Column<bool>(nullable: false),
                    Running = table.Column<bool>(nullable: false),
                    Others = table.Column<string>(nullable: true),
                    OftenPhysical = table.Column<byte>(nullable: false),
                    Cigarette = table.Column<bool>(nullable: false),
                    HowLongCig = table.Column<byte>(nullable: false),
                    NumberPerDay = table.Column<byte>(nullable: false),
                    CurrentDrink = table.Column<bool>(nullable: false),
                    EverDrunk = table.Column<bool>(nullable: false),
                    HowLongAlc = table.Column<byte>(nullable: false),
                    UnitsPerWeek = table.Column<byte>(nullable: false),
                    IsRiskStroke = table.Column<bool>(nullable: false),
                    IsRiskHeartAttack = table.Column<bool>(nullable: false),
                    IsRiskDiabetes = table.Column<bool>(nullable: false),
                    IsRiskBlind = table.Column<bool>(nullable: false),
                    IsRiskKidney = table.Column<bool>(nullable: false),
                    DieEarly = table.Column<bool>(nullable: false),
                    FeelSad = table.Column<bool>(nullable: false),
                    DoctorWish = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocioFactors", x => x.DemographyID);
                    table.ForeignKey(
                        name: "FK_SocioFactors_Demography_DemographyID",
                        column: x => x.DemographyID,
                        principalTable: "Demography",
                        principalColumn: "DemographyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Charts_DemographyID",
                table: "Charts",
                column: "DemographyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anthropometries");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BpHistory");

            migrationBuilder.DropTable(
                name: "Charts");

            migrationBuilder.DropTable(
                name: "Labs");

            migrationBuilder.DropTable(
                name: "QualityAssessments");

            migrationBuilder.DropTable(
                name: "SecondSections");

            migrationBuilder.DropTable(
                name: "SocioFactors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Demography");
        }
    }
}
