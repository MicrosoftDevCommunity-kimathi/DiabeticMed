using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiabeticProject.Models.MedicPatientRepo
{
    public class MedicPatient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int Pregnanicies { get; set; }
        [Required]
        public float PlasmaGlucose { get; set; }
        [Required]
        public float DiasotolicBloodPressure  { get; set; }
        [Required]
        public float TricepThickness { get; set; }
        [Required]
        public float Seruminium { get; set; }
        [Required]
        public float BMi { get; set; }
        [Required]
        public float DiabeticPadiac  { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public float Diabetic { get; set; }

        public bool Isdiabetic { get; set; } = false;

    }
}
