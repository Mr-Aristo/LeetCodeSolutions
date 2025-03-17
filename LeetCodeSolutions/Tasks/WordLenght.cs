using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tasks
{
    public static class WordLenght
    {
        public static int LengthOfLastWord(string s)
        {//example Input: s = "   fly me   to   the moon  "
            List<string> mylist = s.Trim().Split(" ").ToList();
            int i = mylist.Count() - 1;
            var myword = mylist[i];
            int mycount = myword.Length;
            return mycount;
            //Trim() stringin basindaki ve sonundaki bosluklari siler. 
            //Split ile de kelimeleri ayri ayri aliriz. arada bosluk odugus surece
        }
    }
}
