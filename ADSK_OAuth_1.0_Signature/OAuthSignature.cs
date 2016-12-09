using OAuth;
using System;

namespace ADSK_OAuth_1._0_Signature
{
    class OAuthSignature
    {
        public static void Main (string [] args)
        {
            var o2 = new OAuthHmac();
            string consumerKey= "8d8bed6f-bd27-416a-94ae-557ae963ce76";
            string consumerSecret= "3ff2efbe-a998-4b9f-a791-666c66ece5c7";
            string timestamp = "1477603197";
            string nonce = "xnSGam";
            string url = "https://accounts-staging.autodesk.com/api/accounts/v1/user";
            string s1 = o2.GenerateHeader(url, consumerKey, consumerSecret);
            string s2 = o2.GenerateSignature(url, consumerKey, consumerSecret,null,null, "POST",timestamp,nonce);
            Console.WriteLine(s1);
            //Console.WriteLine(s2);
            Console.ReadKey();
        }
    }
}
