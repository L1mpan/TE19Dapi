namespace TE19Dapi.models
{
    public class Student
    {
        public int Id { get; set; } = 1;
        public string Name { get; set; } = "namePlaceholder";
        public int Age { get; set; } = 20;


        public StudentClass classStudent {get; set;} = StudentClass.TE19D;
    }
}