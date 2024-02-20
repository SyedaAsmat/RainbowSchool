namespace RainbowSchoolLibrary
{
    public class Students
    {
        public string Name { get; set; }
        public int Class { get; set; }

        public Students(string name, int clss)
        {
            Name = name;
            Class = clss;
        }
        public string StudentInfo()
        {
            return $"{Name} is in {Class}th class";
        }
        public virtual bool StudentForMock()
        {
            throw new NotImplementedException();
        }
    }
}
