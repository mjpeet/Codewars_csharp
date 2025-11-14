using Codewars;

namespace Codewars_csharp
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void KataGordonTest()
        {
            Assert.That(Kata.Gordon("What feck damn cake"), Is.EqualTo("WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!"));
            Assert.That(Kata.Gordon("are you stu pid"), Is.EqualTo("@R*!!!! Y**!!!! ST*!!!! P*D!!!!"));
            Assert.That(Kata.Gordon("i am a chef"), Is.EqualTo("*!!!! @M!!!! @!!!! CH*F!!!!"));
        }
    }
}