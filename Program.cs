using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);

            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = {0,1,0,3,12};
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if(Isomorphic(s61,s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if(HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number",n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if(profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}",profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        ///  Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>

        private static void ShuffleArray(int[] nums, int n)
        {
            //Logic :
            /*
            As the Size of Array is 2N  so we take new array initialize two variables one from from 
            begining and other from mid of the array  and keep inserting data into new array
            */
            try
            {
                int[] new_arr = new int[nums.Length];
                int j=0;
                int mid = nums.Length/2;
                for(int i=0;i<mid;i++)
                {
                    new_arr[j]=nums[i];
                    j+=1;
                    new_arr[j]=nums[mid+i];
                 
                    j+=1;
                }
                foreach(var x in new_arr)
                Console.Write(x+" ");
                Console.WriteLine();               
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write a method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements. 
        /// You must do this in-place without making a copy of the array.
       /// Example:
       ///Input: [0,1,0,3,12]
       /// Output: [1,3,12,0,0]
       /// </summary>
       
        private static void MoveZeroes(int[] ar2)
        {
            //Logic:
            /*
            Here we initalize a temp varaiable and start traversing array
            for every element if its zero we continue if non zero elements 
            we will update the cuurent temp with that element and proceed
            
            In the from temp to length of array we fill zeros
            */
            try
            {
                int i=0;
                for(int j=0;j<ar2.Length;j++)
                {
                    if(ar2[j]!=0)
                    {
                        ar2[i]=ar2[j];
                        i+=1;
                    }
                }
                for(int j=i;j<ar2.Length;j++)
                {
                    ar2[j]=0;
                }

                foreach(var x in ar2)
                Console.Write(x+" ");
                Console.WriteLine();                
            }
            catch (Exception)
            {

                throw;
            }
        }
        

        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5) 
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>

        private static void CoolPairs(int[] nums)
        {
            /*
            Logic:
            here we store all the elements as keys and there count of occurences as value in the dictionoary

            sice we traverse the array from left to right all elements of each key will defalut satisfy the 
            Condition " i<j " so for the count i cacluated the number of pairs using permutations.
            
            (nc2 ==> n*(n-1)/2) ==> gives number of pairs for the count

            Example : [1,2,3,1,1,3] "1"  repeated 3 times so number of pairs for 1 are (3*2/2) == 3 
                                    "3"  repeated 2 times so number of pairs for 1 are (3*2/2) == 1 so total 4
            */

            try
            {
               int totalPairs=0;
                Dictionary<int,int> data=new Dictionary<int,int>();
                for(int i=0;i<nums.Length;i++)
                {
                    if(data.ContainsKey(nums[i]))
                    {
                        data[nums[i]]+=1;
                    }
                    else
                    data[nums[i]]=1;
                }
                foreach(var x in data)
                {
                if(data[x.Key]>1)
                {
                    int z=data[x.Key];
                    totalPairs+=((z*(z-1))/2);
                }

            }    
            Console.WriteLine(totalPairs);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            /*

            Here I stored the elements as key and there occurences in the list as values 
            reason for used List is to handle the corner cases as given  in the Example 3

            so I traversed array for each element i looked for target-element in the dictionary 
            if it is found i am returning.

            */
            try
            {
                Dictionary<int,List<int>> track = new Dictionary<int, List<int>>();
                int x=0,y=0;
                for(int i=0;i<nums.Length;i++)
                {
                    if(track.ContainsKey(nums[i]))
                    track[nums[i]].Add(i);
                    else
                    {
                    track.Add(nums[i],new List<int>());
                    track[nums[i]].Add(i);
                    }
                }
                
            for(int i=0;i<nums.Length;i++)
            {
                x=i;
                if(track.ContainsKey(target-nums[x]) )
                {
                    if(track[(target-nums[x])][0]!=i)
                    {
                     y=track[(target-nums[x])][0];   
                     break;
                    }
                    else if(track.Count>1)
                    {
                        y=track[(target-x)].Last();
                        break;
                    }

                }
                
            }
            Console.WriteLine("["+x+","+y+"]");
                
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, “K” should be at index 6, “O” should be at index 4 and so on. “korfsucy” becomes “usfrocky”
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            /*
            
            Logic:
            here i used new array of length same as string and as i traverse the 
            indices array i kept the present element in S at the index mentioned 
            in the indices array. 
            
            */
            try
            {
                 char[] shuffle = new char[s.Length];
                for(int i=0;i<indices.Length;i++)
                {
                    shuffle[indices[i]]=s[i];
                }
                foreach(var x in shuffle)
                Console.Write(x);
                Console.WriteLine();               
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = “bulls” s2 = “sunny” 
        ///Output : True
        ///Explanation: ‘b’ can be replaced with ‘s’ and similarly ‘u’ with ‘u’, ‘l’ with ‘n’ and ‘s’ with ‘y’.
        ///Example 2:
        ///Input: s1 = “usf” s2 = “add”
        ///Output : False
        ///Explanation: ‘u’ can be replaced with ‘a’, but ‘s’ and ‘f’ should be replaced with ‘d’ to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = “ab” s2 = “aa”
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                /*
                Logic:

                Here the simple Logic i used is that i checked for One to one relationship 
                between the strings s1 and s2. for that used two dictinories to check that.

                One-to-One Relation: Each element in s1 should be associated with only one element in s2


                */
                Dictionary<char,char> st1=new Dictionary<char, char>();
                Dictionary<char,int> st2=new Dictionary<char, int>();
                if(s1.Length!=s2.Length)
                return false;
                int j=0;
                for(int i=0;i<s1.Length;i++)
                {
                    if(st1.ContainsKey(s1[i]))
                    {
                        if(st1[s1[i]]!=s2[j])
                            return false;
                    }
                    else
                    {
                        if(st2.ContainsKey(s2[j]))
                            return false;
                        else{
                            st1.Add(s1[i],s2[j]);
                            st2.Add(s2[j],1);
                        }
                    }
                    j+=1;

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            /*
            Logic:

            Here i used  dictionary to store the values associated with each ID in the list as value,
            then i sorted the values for each key and used inbuilt LIst functions to extract first 5 elements
            and cacluated there Average.
            
            */
            try
            {
                List<List<int>> ans = new List<List<int>>();
                Dictionary<int,List<int>> track = new Dictionary<int, List<int>>();
                for(int i=0;i<items.GetLength(0);i++)
                {
                    if (!track.ContainsKey(items[i,0]))
                    {
                        track.Add(items[i,0], new List<int>());
                        track[items[i,0]].Add(items[i,1]);
                    }
                    else
                        track[items[i,0]].Add(items[i,1]);
                }

                foreach(var x in track)
                {
                    track[x.Key].Sort();
                    track[x.Key].Reverse();
                }

                foreach(var x in track)
                {
                    List<int> temp= new List<int>();
                    temp.Add(x.Key);
                    temp.Add((int)track[x.Key].GetRange(0,5).AsQueryable().Sum()/5);
                    ans.Add(temp);

                }

            foreach(var x in ans)
            {
                Console.Write("[");
                foreach(var j in x)
                Console.Write(j+" ");
                Console.Write("]");
            }
            Console.WriteLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
                

        //Question 8
        /// <summary>
        /// Write an algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///•	Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///•	Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///•	Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>

        private static bool HappyNumber(int n)
        {
            /*
            Logic :

            Here i used Dictionary to store all the occured as we progress with the steps 
            if the values repeat then i return False if i encounter "1" return True.
            
            */
            try
            {
            Dictionary<int,int> track = new Dictionary<int, int>();
            track.Add(n,1);
            int x=0;
            while(true)
            {
                x=0;
                while(n>0)
                {
                    x+=(int)Math.Pow(n%10,2);
                    n=(int)n/10;
                }
                n=x;
                if(x==1)
                return true;
                if(track.ContainsKey(x))
                return false;
                else
                track.Add(x,1);
            
            }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>

        private static int Stocks(int[] prices)
        {
            /*
            Logic:

            Here i assumed first one as minimun value stock and kept cacluating the 
            profit,and used max function to keep track of max profit in the  end i returned 
            the profit.

            */
            try
            {
                int profit=0;
                int min_stock=prices[0];
                for(int i=0;i<prices.Length;i++)
                {
                    min_stock=math.Min(min_stock,prices[i]);

                    profit=math.Max(profit,(prices[i]-min_stock));
                }
                return profit;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways. 
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>

        private static void Stairs(int steps)
        {
            /* Logic 

            If we look clearly here Professor Clinton  can take 1 or 2 steps at each stair 
            So for a stair n number of steps will be number steps for n-1 + number of steps for n-2 stairs 
           
            */

            try
            {
              int[] steps_count= new int[n];
              steps_count[0]=1;
              steps_count[1]=2;
              for(int i=2;i<n;i++)
              {
               steps_count[i]=steps_count[i-1]+steps_count[i-2];
              }
               Console.WriteLine(steps_count[n-1]);
              }

            }
            catch (Exception)
            {

                throw;
            }
}
