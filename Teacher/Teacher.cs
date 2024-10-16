namespace DependencyInjectionPractice.Teacher
{
    public class Teacher : ITeacher
    {
        public Teacher(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Öğretmen = {FirstName} {LastName}";
        }
    }
}
