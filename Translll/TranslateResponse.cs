using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

namespace Translll
{
    class TranslateResponse
    {
        public static Regex reg = new Regex("\"dst\":\"(.+)\"}]}$", RegexOptions.Compiled);
        public string from { get; set; }
        public string to { get; set; }
        public List<object> trans_result { get; set; }
        public static string ParseDest(string resp)
        {
            string dst = reg.Match(resp).Groups[1].Value;
            if (dst.Contains(@"\u"))
                // Unicode 字符串
                return FromUnicodeString(dst);
            else
                // ASCII 字符串
                return dst;
        }

        public TranslateResponse(
            string from = "auto", string to = "zh", 
            Dictionary<string, string> dict = null)
        {
            this.from = from;
            this.to = to;
            this.trans_result = new List<object>();
            if (dict!=null) this.trans_result.Add(dict);
        }

        public static string FromUnicodeString(string str)
        {
            StringBuilder strResult = new StringBuilder();
            if (!string.IsNullOrEmpty(str))
            {
                string[] strlist = str.Replace("\\", "").Split('u');
                try
                {
                    for (int i = 1; i < strlist.Length; i++)
                    {
                        int charCode = Convert.ToInt32(strlist[i], 16);
                        strResult.Append((char)charCode);
                    }
                }
                catch (FormatException ex)
                {
                    return Regex.Unescape(str);
                }
            }
            return strResult.ToString();
        }
    }
}
