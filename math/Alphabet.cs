using System;
using System.Collections.Generic;
 
    public class Alphabet
    {
 
        public String[] Alpabeth = null;
 
        public Dictionary<String,int> Value = null;
 
        public int Base = 0;
 
        public Alphabet(int n)
        {
            Create(n);
            Base = n;
        }
 
        public String[] Create(int n)
        {
            if (n == 0)
                return null;
 
            int i = 0;
            Alpabeth = new String[n];
            Value = new Dictionary<string, int>();
            while (i < n)
            {
                if (i>=0 && i<=9 )
                {
                    Alpabeth[i] = (char)(48 + i) + "";
                } else
                {
                    if (i >= 10 && i <= 40)
                    {
                        Alpabeth[i] = (char)( (64-9) + i) + "";
                    } else
                    {
                        Alpabeth[i] = "{"+ i +"}";
                    }
                }
 
                Value[Alpabeth[i]] = i;
 
                i = i + 1;
            }
 
            return Alpabeth;
        }
 
    }
