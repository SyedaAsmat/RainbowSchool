namespace RainbowSchoolLibrary
{
    public class Subjects
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Subjects(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
        public string SubjectInfo()
        {
            return $"{Name} has {Marks} marks";
        }
        public virtual bool SubjectForMock()
        {
            throw new NotImplementedException();
        }
    }
}
