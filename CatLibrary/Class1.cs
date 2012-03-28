using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Data;

namespace RandomCatPictures1
{
    public class GetCat
    {
        public string GetCatPic()
        {
            string caturl = "http://thecatapi.com/api/images/get.php";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(caturl);
            HttpWebResponse response = (HttpWebResponse)req.GetResponse();

            string responseString;
            responseString = response.ResponseUri.ToString();
            return responseString;
        }

        public string CreateLabel(string caturl)
        {
            return "Cat Image Source: " + caturl;
        }

    }
}
