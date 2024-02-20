namespace RainbowSchoolLibrary
{
    public class Teachers
    {
        public string Name { get; set; }
        public string TeachSubject { get; set; }

        public Teachers(string name, string sub)
        {
            Name = name;
            TeachSubject = sub;
        }
        public string TeacherInfo()
        {
            return $"Mr/Mrs/Ms. {Name} teaches {TeachSubject}";
        }
        public virtual bool TeacherForMock()
        {
            throw new NotImplementedException();
        }
    }
}
