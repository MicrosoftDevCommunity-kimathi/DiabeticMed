using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiabeticmedApi.Model
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pregnanicies { get; set; }
        public float PlasmaGlucose { get; set; }
        public float DiasotolicBloodPressure { get; set; }
        public float TricepThickness { get; set; }
        public float Seruminium { get; set; }
        public float BMi { get; set; }
        public float DiabeticPadiac { get; set; }
        public int Age { get; set; }

        public float Diabetic { get; set; }

        public bool Isdiabetic { get; set; } = false;
    }
}
