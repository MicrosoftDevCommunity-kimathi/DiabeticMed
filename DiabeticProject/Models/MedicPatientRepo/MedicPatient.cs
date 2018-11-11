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
        [Required(ErrorMessage = "please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "please enter the number you were pregnant")]
        public int Pregnanicies { get; set; }
        [Required(ErrorMessage = "PlasmaGlucose cannot be null")]
        public float PlasmaGlucose { get; set; }
        [Required(ErrorMessage = "DiasotolicBloodPressure cannot be null")]
        public float DiasotolicBloodPressure  { get; set; }
        [Required(ErrorMessage = "DiasotolicBloodPressure cannot be null")]
        public float TricepThickness { get; set; }
        [Required(ErrorMessage = "DiasotolicBloodPressure cannot be null")]
        public float Seruminium { get; set; }
        [Required(ErrorMessage = "BMi cannot be null")]
        public float BMi { get; set; }
        [Required(ErrorMessage = "DiabeticPadiac cannot be null")]
        public float DiabeticPadiac  { get; set; }
        [Required(ErrorMessage = "Age cannot be null")]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Diabetic cannot be null")]
        public float Diabetic { get; set; }

        public bool Isdiabetic { get; set; } = false;

    }
}
