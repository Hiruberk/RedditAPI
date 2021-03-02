using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditAPILab.Models
{
    public class RedditDAL
    {
        public string GetData(string subreddit)
        {
            string url = @$"https://www.reddit.com/r/{subreddit}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string JSON = rd.ReadToEnd();

            return JSON;
            
        }

        public SubRedditRoot ConvertToSubReddit(string subreddit)
        {
            string subRedditData = GetData(subreddit);
            SubRedditRoot s = new SubRedditRoot();
            s = JsonConvert.DeserializeObject<SubRedditRoot>(subRedditData);
            
            return s;
        }
    }
}
