using Codewars;

/*
 * https://www.codewars.com/kata/57d1f36705c186d018000813/train/csharp 
 * 
 * Gordon Ramsay shouts. He shouts and swears. There may be something wrong with him.
 *
 * Anyway, you will be given a string of four words. Your job is to turn them in to Gordon language.
 *
 * Rules:
 *
 * Obviously the words should be Caps, Every word should end with '!!!!', Any letter 'a' or 'A' should become '@', Any other vowel should become '*'.
 */

namespace Codewars_csharp
{
    public class CodeWarsHellsKitchenTest
    {
        [SetUp]
        public void Setup()
        {
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