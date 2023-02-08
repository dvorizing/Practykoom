using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Entities
{
    public enum EMedicalClinic { Macaby=1, Mehuchedet=2, clalit=4, leumit=8}

    public enum EGender { Male=1, Fmale=2 }
    public class User
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public EGender Gender { get; set; }
        public EMedicalClinic MedicalClinic { get; set; }
    }
}
