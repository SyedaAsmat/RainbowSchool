using Moq;
using RainbowSchoolLibrary;

namespace RainbowSchool
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestTeacherInfo()
        {
            var teacher = new Teachers("Neema Mathews", "English");
            var result = teacher.TeacherInfo();
            Assert.That(result, Is.EqualTo("Mr/Mrs/Ms. Neema Mathews teaches English"));
        }
        [Test]
        public void TestStudentInfo()
        {
            var student = new Students("Ariana", 12);
            var result = student.StudentInfo();
            Assert.That(result, Is.EqualTo("Ariana is in 12th class"));
        }
        [Test]
        public void TestSubjectInfo()
        {
            var subject = new Subjects("English",85);
            var result = subject.SubjectInfo();
            Assert.That(result, Is.EqualTo("English has 85 marks"));
        }
        [Test]
        public void MockTest()
        {
            Mock<Teachers> Tchr = new Mock<Teachers>();
            Tchr.Setup(x => x.TeacherForMock()).Returns(true);

            Mock<Subjects> Sub = new Mock<Subjects>();
            Sub.Setup(x => x.SubjectForMock()).Returns(true);

            Mock<Students> Stu = new Mock<Students>();
            Stu.Setup(x => x.StudentForMock()).Returns(true);
        }
        [Test]
        [TestCase("Sania", 10)]
        [TestCase("Zara", 9)]
        public void TestWithData(string studentName, int clss)
        {
            var student = new Students(studentName, clss);
            var result = student.StudentInfo();
            Assert.That(result, Is.EqualTo($"{studentName} is in {clss}th class"));
        }
    }
}
