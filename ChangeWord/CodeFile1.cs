//this program I wrote one year ago )))


// I like c# very much  (change any word in this sentence )
using System;
using System.Globalization;
namespace Counter 
{
    class Davo 
    {
        public int Qanak(string tox) 
        {
            int count = 0;
            for (int i = 0; i < tox.Length; i++) 
            {
                if (i==tox.Length-1 && tox[i] != ' ') 
                {
                    return (count + 1);
                }
                if (tox[i] != ' ' && tox[i + 1] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        public string func(string tox, int k)
        {
            try
            {
                int index = 0; ;
                string[] M = new string[Qanak(tox)];
                int j = 0;
                for (int i = 0; i < tox.Length; i++)
                {
                    if (i == 0 && tox[i] != ' ')
                    {
                        index = 0;
                    }
                    if (i == tox.Length - 1 && tox[i] == ' ') 
                    {
                        return M[k];
                    }
                    if (tox[i] == ' ' && tox[i + 1] == ' ')
                    {
                        continue;
                    }
                    

                    if (tox[i] == ' ' && tox[i + 1] != ' ')
                    {
                        index = i + 1;
                    }
                    if (i == tox.Length - 1 && tox[i] != ' ')
                    {
                        M[j] = tox.Substring(index, (i - index + 1));
                        return M[k];
                    }
                    if (tox[i] != ' ' && tox[i + 1] == ' ')
                    {
                        M[j] = tox.Substring(index, (i - index + 1));
                        j++;
                    }
                   
                }
                return M[k];
            }
            catch (IndexOutOfRangeException ob) { Console.WriteLine(ob.Message); return "sxal e"; }
        }
      }
    }

class davo 
{
    static void Main() 
    {
        Console.WriteLine("Change appropriate word ");
        Counter.Davo ob = new Counter.Davo();
        Console.WriteLine("Write sentences");
       
        string str = Console.ReadLine();
        string [] M=new string[ob.Qanak(str)];
        
        Console.WriteLine("write what's name you want to change");
        
        string k;
        k = Console.ReadLine();
        
        Console.WriteLine("write your word,wich will put on the old word");
        string tox = Console.ReadLine();
        for (int i = 0; i < ob.Qanak(str); i++) 
        {
            if (ob.func(str, i) == k)
            {
                M[i] = tox;
            }
            else { M[i] = ob.func(str, i); }
        }

        for (int i = 0; i < ob.Qanak(str); i++) 
        {
            Console.Write(M[i] + ' ');
        }
        

        
        
    }
}