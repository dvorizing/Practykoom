namespace MyProject.WebAPI.models
{
    public enum EMedicalClinicC { Macaby = 1, Mehuchedet = 2, clalit=4, leumit=8 }
    public enum EGenderC { Male=1, Fmale=2 }
    public class UserModel
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? FamilyName { get; set; }
        public DateTime DateBorn { get; set; }
        public EGenderC Gender { get; set; }
        public EMedicalClinicC MedicalClinic { get; set; }
    }
}
