using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

HINT: two-pointer technique for cycle detection

 */

namespace Katas
{
    public class CodeWarsLoopSizeKata
    {
        public static int getLoopSize(LoopDetector.Node startNode)
        {
            //Enter code here.
            var slow = startNode;
            var fast = startNode;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    break;
                }

            }

            var loopNode = slow;
            int count = 0;
            var current = loopNode;
            do
            {
                current = current.next;
                count++;
            } while (current != loopNode);

            return count;
        }
    }

    public class LoopDetector
    {
        public class Node
        {
            public Node next;
        }

        // Helper method to create a chain with dangling piece and loop
        public static Node createChain(int danglingLength, int loopSize)
        {
            // Create the dangling part
            Node head = new Node();
            Node current = head;

            for (int i = 1; i < danglingLength; i++)
            {
                current.next = new Node();
                current = current.next;
            }

            // Create the loop
            Node loopStart = new Node();
            current.next = loopStart;
            current = loopStart;

            for (int i = 1; i < loopSize; i++)
            {
                current.next = new Node();
                current = current.next;
            }

            // Close the loop
            current.next = loopStart;

            return head;
        }
    }
}
