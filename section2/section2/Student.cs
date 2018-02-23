using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace section2
{
    public class Student
    {
        public List<int> ScoreList;
        public string Name { get; set; }

        public double ScoreTotal => ScoreList.Aggregate(0, (pInt, nInt) => pInt + nInt);
        public double ScoreAverage => ScoreTotal/ScoreList.Count;
        

        public Student(string name, List<int> scoreList)
        {
            Name = name;
            ScoreList = scoreList;
        }

        public Student(string name)
        {
            Name = name;
        }

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