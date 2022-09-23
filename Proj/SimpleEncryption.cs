using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj
{
    public class SimpleEncryption
    {
        public string Encrypt(string text, int number)
        {
            if (!string.IsNullOrEmpty(text) && number > 0)
            {

                for (int i = 0; i < Math.Abs(text.Length - number); i++)
                {
                    var left = new StringBuilder();
                    var right = new StringBuilder();
                    for (int j = 0; j < text.Length; j++)
                    {
                        if (j % 2 != 0)
                        {
                            left.Append(text[j]);
                        }
                        else
                        {
                            right.Append(text[j]);
                        }
                    }
                    text = left.ToString() + right.ToString();
                }
                
            }
            return text;


        }


        public string Decrypt(string text, int number)
        {
            if (!string.IsNullOrEmpty(text) && number > 0)
            {
               

                if ((text.Length % 2) != 0)
                {

                }
                int res = Math.Abs(text.Length - number);

                if (res > text.Length - 1)
                {
                    res %= text.Length;
                }

                
                return Encrypt(text, res);
            }
            return text;
        }

    }
}
