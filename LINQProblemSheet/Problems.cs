using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblemSheet
{
    class Problems
    {
        public Problems()
        {

        }
        public void ProblemOne()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            IEnumerable<string> test = from w in words
                    where w.Contains("th")
                    select w;
        
            foreach (string w in test)
            {
                
                Console.WriteLine(Convert.ToString(w));
                Console.ReadLine();
            }
        }
        public void ProblemTwo()
        {
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };
            IEnumerable<string> test = names.Distinct();
            foreach(string n in test)
            {
                Console.WriteLine(n);
                Console.ReadLine(); 
            }
        }
        public void ProblemThree()
        {
            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };
            IEnumerable<string> test = classGrades.
        }
    }
}

