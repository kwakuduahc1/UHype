using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UHype.Model
{
    public class Labs
    {
        [Key]
        [Required]
        [ForeignKey(nameof(Demography))]
        public Guid DemographyID { get; set; }

        public double Cholesterol { get; set; }

        public double Hdl { get; set; }

        public double Ldl { get; set; }

        public double Trigly { get; set; }

        public double Bun { get; set; }

        public double Creat { get; set; }

        [Required]
        [Range(0, 2)]
        public byte PhysicianDocs { get; set; }

        public bool FollowUp { get; set; }

        public virtual Demography Demography { get; set; }
    }
}
