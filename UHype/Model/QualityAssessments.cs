using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class QualityAssessments
    {
        [Required]
        [ForeignKey(nameof(Demography))]
        public Guid DemographyID { get; set; }

        [Required]
        [Range(0, 4)]
        public byte HealthScale { get; set; }

        [Required]
        [Range(0, 4)]
        public byte Compared { get; set; }

        [Required]
        [Range(0, 2)]
        public byte Vigorous { get; set; }

        [Required]
        [Range(0, 2)]
        public byte Moderate { get; set; }

        [Required]
        [Range(0, 2)]
        public byte Climbing { get; set; }

        [Required]
        [Range(0, 2)]
        public byte Bending { get; set; }

        [Required]
        [Range(0, 2)]
        public byte WalkingMile { get; set; }

        [Required]
        [Range(0, 2)]
        public byte WalkingBlocks { get; set; }

        [Required]
        [Range(0, 2)]
        public byte WalkingOne { get; set; }

        [Required]
        [Range(0, 2)]
        public byte BathingSelf { get; set; }

        [Required]
        public byte CutDown { get; set; }

        [Required]
        public byte AccomplishLess { get; set; }

        [Required]
        public byte WereLimited { get; set; }

        [Required]
        public byte HadDiff { get; set; }

        [Required]
        public byte CutDownEm { get; set; }

        [Required]
        public byte AccomplishEm { get; set; }

        [Required]
        public byte WasCareful { get; set; }

        [Required]
        [Range(0, 4)]
        public byte EmotionInterfere { get; set; }

        [Required]
        [Range(0, 5)]
        public byte BodyPainIn4 { get; set; }

        [Required]
        [Range(0, 4)]
        public byte BodyPainInHouse { get; set; }

        [Required]
        [Range(0, 4)]
        public byte HasPep { get; set; }

        [Required]
        [Range(0, 4)]
        public byte IsNervous { get; set; }

        [Required]
        [Range(0, 4)]
        public byte IsDump { get; set; }

        [Required]
        [Range(0, 4)]
        public byte WasPeaceful { get; set; }

        [Required]
        [Range(0, 4)]
        public byte HasEnergy { get; set; }

        [Required]
        [Range(0, 4)]
        public byte WasDownhearted { get; set; }

        [Required]
        [Range(0, 4)]
        public byte WasWornOut { get; set; }

        [Required]
        [Range(0, 4)]
        public byte BeenHappy { get; set; }

        [Required]
        [Range(0, 4)]
        public byte FeelTired { get; set; }

        [Required]
        [Range(0, 4)]
        public byte SocialInterfere { get; set; }

        [Required]
        [Range(0, 4)]
        public byte SickEasier { get; set; }

        [Required]
        [Range(0, 4)]
        public byte VeryHealthy { get; set; }

        [Required]
        [Range(0, 4)]
        public byte ToGetWorse { get; set; }

        [Required]
        [Range(0, 4)]
        public byte IsExcellent { get; set; }

        public virtual Demography Demography { get; set; }

    }
}
