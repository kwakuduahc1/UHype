using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class SocioFactors
    {
        [Key]
        [ForeignKey(nameof(Demography))]
        public Guid DemographyID { get; set; }

        public bool FinanceDiffs { get; set; }

        public bool HasConcerns { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Concerns { get; set; }

        public bool HasAssitance { get; set; }

        [Required]
        [Range(0, 2)]
        public byte TakesHerbal { get; set; }

        [Required]
        [Range(0, 2)]
        public byte SeenDietician { get; set; }

        [Required]
        [Range(0, 2)]
        public byte BelieveDiet { get; set; }

        [Required]
        [Range(0, 2)]
        public byte SpecialDiet { get; set; }

        public bool PhysicalActivity { get; set; }

        public bool Walking { get; set; }

        public bool Running { get; set; }

        public string Others { get; set; }

        [Range(0, 5)]
        [Required]
        public byte OftenPhysical { get; set; }

        public bool Cigarette { get; set; }

        [Range(1, 70)]
        public byte HowLongCig { get; set; }

        public byte NumberPerDay { get; set; }

        public bool CurrentDrink { get; set; }

        public bool EverDrunk { get; set; }

        public byte HowLongAlc { get; set; }

        public byte UnitsPerWeek { get; set; }

        [Required]
        public bool IsRiskStroke { get; set; }

        public bool IsRiskHeartAttack { get; set; }

        public bool IsRiskDiabetes { get; set; }

        public bool IsRiskBlind { get; set; }

        public bool IsRiskKidney { get; set; }

        public bool DieEarly { get; set; }

        public bool FeelSad { get; set; }

        [StringLength(100)]
        public string DoctorWish { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
