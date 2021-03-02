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
            string url = @$"https://www.reddit.com/r/{subreddit.Trim()}/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);
            try
            {
                if(subreddit.Length >= 3 && subreddit.Length <= 21)
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    StreamReader rd = new StreamReader(response.GetResponseStream());

                    string JSON = rd.ReadToEnd();
                    return JSON;
                }
                else
                {
                    throw new Exception("Error: Subreddit Names must be bewteen 3 and 21 characters");
                }

            }
            catch(Exception e)
            {
                return "Error:" + e.StackTrace;
            }
   
        }

        public SubRedditRoot GetPosts(string sub)
        {
            string subRedditData = GetData(sub);
            if (subRedditData.Contains("Error:"))
            {
                SubRedditRoot error = new SubRedditRoot();
                error.Error = true;
                error.ErrorMessage = subRedditData;
                return error;
            }
            else
            {
                SubRedditRoot s = new SubRedditRoot();
                s = JsonConvert.DeserializeObject<SubRedditRoot>(subRedditData);
                return s;
            }
        }
    }
}
