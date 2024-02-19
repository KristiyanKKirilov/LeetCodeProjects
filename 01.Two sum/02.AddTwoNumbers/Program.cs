namespace _02.AddTwoNumberss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode node = new ListNode(1);
            for (int i = 1; i <= 3; i++)
            {
                node.next = new ListNode(i);
                node.val = i;
            }

            ListNode node2 = new ListNode();
            for (int i = 5; i <= 8; i++)
            {
                node2.next = new ListNode(i);
                node2.val = i;
            }


        }

        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            char[] str1 = l1.ToString().ToCharArray().Reverse().ToArray();
            int firstSum = int.Parse(str1.ToString());

            char[] str2 = l2.ToString().ToCharArray().Reverse().ToArray();
            int secondSum = int.Parse(str2.ToString());

            int sum = firstSum + secondSum;
            char[] result = sum.ToString().ToCharArray().Reverse().ToArray();
            ListNode node = new ();

            foreach (char c in result)
            {
                int digit = int.Parse(c.ToString());
                node.next = new ListNode(digit);
                node = node.next;
            }
            return node;
        }
    }
    

   class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }


  

}