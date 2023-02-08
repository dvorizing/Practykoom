using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Common.DTO
{
    public enum EMedicalClinicD { Macaby=1, Mehuchedet=2, clalit=4, leumit=8 }
    public enum EGenderD { Male=1, Fmale=2 }
    public class UserDTO
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public EGenderD Gender { get; set; }
        public EMedicalClinicD MedicalClinic { get; set; }
    }
}
