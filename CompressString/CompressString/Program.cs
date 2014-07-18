using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ppppppppppppppppppp"; //p3a2;
            string output = "";
            Console.WriteLine("result is {0}",mysize2(s, out output));
            Console.WriteLine("Return string {0}", output);

            Console.ReadKey();


        }


        static int mysize2(string s, out string output)
        {
            output = "";
            Dictionary<char,int> list = new Dictionary<char,int>(); 
            if (s.Length == 0 || s == null) return 0;

        
            foreach (char c in s)
            {

                if (list.ContainsKey(c))
                {
                    list[c] = list[c] + 1;
                }
                else
                    list.Add(c,1);
            
            }
            StringBuilder sb = new StringBuilder("");
            foreach (var pair in list)
            {
                var key = pair.Key;
                var value = pair.Value;
                //Console.WriteLine("{0}{1}",key,value);
                sb.Append(key+""+value);
            }


            
            output = sb.ToString();
            
            return sb.Length;
        }


        // not used
        static int mysize(string s)
        {

            if (s == null) return 0;
            if (s == "") return 0; 
            int size = 0;
            int count=1;
            char last_seen = s[0]; 

            for (int i = 1; i <s.Length;i++ )
            {

               
                if (last_seen == s[i])
                {
                    count++;
                    Console.WriteLine("cout is [{0}]--",count);
                    
                }
                else {
                    size = size + 1 + (Convert.ToString(count)).Length;
                    
                    last_seen = s[i];
                    count = 1;
                    Console.WriteLine("cout is [{0}]", count);
                }
               
            }
         
            
            size = size + 1+ (Convert.ToString(count)).Length;
            return size;
    
        }
    }
}
