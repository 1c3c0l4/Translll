using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web;

namespace Translll
{
    public class Config
    {
        private readonly static Random rand = new Random();
        private readonly static MD5CryptoServiceProvider md5Csp =
            new MD5CryptoServiceProvider();

        public readonly string DetailUrl =
            @"https://fanyi.baidu.com/translate";
        public readonly string ApiUrl =
            @"http://api.fanyi.baidu.com/api/trans/vip/translate";
        public readonly string AppID =
            @"";
        public readonly string AppKey =
            @"";
        public string Salt { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Q { get; set; }
        public string Sign { get; set; }

        private void GenerateSign() 
        {
            StringBuilder signResult = new StringBuilder();
            Salt = rand.Next(100000000, 1000000000).ToString();
            byte[] inputBytes = Encoding.UTF8.GetBytes($"{AppID}{Q}{Salt}{AppKey}");
            byte[] outputBytes = md5Csp.ComputeHash(inputBytes);
            foreach (var b in outputBytes)
                signResult.Append(b.ToString("x2"));
            Sign = signResult.ToString();
        }

        public static Config BuildConfig(string from, string to, string q)
        {
            Config config = new Config();
            config.From = from;
            config.To = to;
            config.Q = q;
            config.GenerateSign();
            return config;
        }

        public string GetDetailUrl()
        {
            return $"{DetailUrl}?query={HttpUtility.UrlEncode(Q)}&lang={From}2{To}";
        }
    }
}
