using Codewars;
using Katas;

/*
 * https://www.codewars.com/kata/52a89c2ea8ddc5547a000863/train/csharp
 * 
 * You are given a node that is the beginning of a linked list. This list contains a dangling piece and a loop. Your objective is to determine the length of the loop.
 *
 * For example in the following picture the size of the dangling piece is 3 and the loop size is 12:
 * 
 * # Use the `next' method to get the following node.
 * node.next
 * 
 * Notes:

    do NOT mutate the nodes!
    in some cases there can be just a loop, with no dangling piece.

 */

namespace Codewars_csharp
{
    [TestFixture]
    public class CodeWarsLoopSizeKataTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Order(1)]
        public void FourNodesWithLoopSize3()
        {
            var n1 = new LoopDetector.Node();
            var n2 = new LoopDetector.Node();
            var n3 = new LoopDetector.Node();
            var n4 = new LoopDetector.Node();
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n2;
            Assert.That(CodeWarsLoopSizeKata.getLoopSize(n1), Is.EqualTo(3));
        }

        [Test, Order(2)]
        public void RandomChainNodesWithLoopSize30()
        {
            var n1 = LoopDetector.createChain(3, 30);
            Assert.That(CodeWarsLoopSizeKata.getLoopSize(n1), Is.EqualTo(30));
        }

        [Test, Order(3)]
        public void RandomLongChainNodesWithLoopSize1087()
        {
            var n1 = LoopDetector.createChain(3904, 1087);
            Assert.That(CodeWarsLoopSizeKata.getLoopSize(n1), Is.EqualTo(1087));
        }
    }
}