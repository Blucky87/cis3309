using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace section2
{
    public class Student
    {
        //holds all scores for student
        public List<int> ScoreList;
        //holds student name
        public string Name { get; set; }
        
        //wrapper for total score, starts at 0 then adds current to next int in scorelist
        public double ScoreTotal => ScoreList.Aggregate(0, (pInt, nInt) => pInt + nInt);

        //wrapper for getting average score
        public double ScoreAverage
        {
            get
            {
                double avg = ScoreList.Count > 0 ? ScoreTotal / ScoreList.Count : 0;
                return avg;
            }
            
        }

        //constructor with name and list of all scores
        public Student(string name, List<int> scoreList)
        {
            Name = name;
            ScoreList = scoreList;
        }
        //constructor with just name
        public Student(string name)
        {
            Name = name;
        }

        //override tostring for easier output in listbox
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            //add name to geinging of string
            stringBuilder.Append(Name);
            //iterate through all items in scorelist and append them as a formatted string to the builder
            ScoreList.ForEach(score => stringBuilder.Append(String.Format("|{0}", score)));

            //resturn the string builder
            return stringBuilder.ToString();
        }
    }
}