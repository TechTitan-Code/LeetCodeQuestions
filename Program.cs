
//public class Solution
//{
//     public int[] TwoSum(int[] nums, int target) {
//        for (int i = 0; i < nums.Length; i++)
//        {
//            for (int j = i + 1; j < nums.Length; j++)
//            {
//                if (nums[i] + nums[j] == target)
//                {
//                    return new int[]{i, j};
//                }
//            }
//        }
//        return null;
//     }

//     public static void Main(string[] args)
//     {
//        Solution solution = new Solution();
//        int[] nums = { 2, 7, 11, 15 };
//        int target = 9;
//       int[] result = solution.TwoSum(nums, target);

//        Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
//     }
//}

//public class ListNode {
//      public int val;
//      public ListNode next;
//      public ListNode(int val=0, ListNode next=null) {
//          this.val = val;
//         this.next = next;
//     }
//  }
//public class Solution {
// public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
//        ListNode listNode = new ListNode(0);
//        ListNode current = listNode;
//        int carry = 0;
//        while (l1 != null || l2 != null || carry != 0) {
//            int x = (l1 != null) ? l1.val : 0;
//            int y = (l2 != null) ? l2.val : 0;
//            int sum = x + y + carry;
//            carry = sum / 10;
//            current.next = new ListNode(sum % 10);
//            current = current.next;
//            if (l1 != null) l1 = l1.next;
//            if (l2 != null) l2 = l2.next;
//        }
//        return listNode.next;
//    }
//    public static void Main(string[] args) 
//{
//    ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
//    ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
//    Solution solution = new Solution();
//    ListNode result = solution.AddTwoNumbers(l1, l2);
//    Console.Write("Result: ");
//    while (result != null)
//    {
//        Console.Write(result.val);
//        result = result.next;
//        if (result != null)
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}

//     }
//     */
//     public class Solution
//{    public int LengthOfLongestSubstring(string s)
//    {
//        HashSet<char> set = new HashSet<char>();
//        int left = 0;
//        int maxLength = 0;    

//        for (int right = 0; right < s.Length; right++)
//        {
//            char currentChar = s[right];
//            while (set.Contains(currentChar))
//            {
//                set.Remove(s[left]);
//                left++;
//            }
//            set.Add(currentChar);
//            maxLength = Math.Max(maxLength, right - left + 1);
//        }
//        return maxLength;
//    }
//}

//public class Program
//{    public static void Main(string[] args)
//    {
//        Solution solution = new Solution();
//        string[] testStrings = { "abcabcbb" };
//        foreach (string testString in testStrings)
//        {
//            int result = solution.LengthOfLongestSubstring(testString);
//            Console.WriteLine($"Length of Longest Substring: {result}");
//        }
//    }
//}





// Baseball Game
//public class Solution
//{
//    public int AddScores(string[] baseballScores)
//    {
//        List<int> record = new List<int>();
//        foreach (var score in baseballScores)
//        {
//            if (score == "C")
//            {
//                record.RemoveAt(record.Count - 1);
//            }
//            else if (score == "D")
//            {
//                record.Add(record[record.Count - 1] * 2);
                
//            }
//            else if (score == "+")
//            {
//                if (record.Count > 0)
//                {
//                    record.Add(record[record.Count -1] + record[record.Count - 2]);
//                }
//            }
//            else
//            {
//                record.Add(int.Parse(score));
//            }
//        }
//        return record.Sum();
//    }
//    public static void Main(string[] args)
//    {
//        Solution solution = new Solution();
//        string[] records = ["5", "2", "C", "D", "+"];

//        int result = solution.AddScores(records);

//        Console.WriteLine(result);

//        Console.ReadKey();
//    }
//}
