using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeightPattern
{
    class WebsiteFactory
    {
        private Dictionary<string, Website> websites = new Dictionary<string, Website>();
        public Website GetWebsiteCategory(string key)
        {
            if (!websites.ContainsKey(key))
            {
                websites.Add(key, new RealWebsite(key));
            }
            return (Website)websites[key];
        }
        public int GetWebsiteCount()
        {
            return websites.Count;
        }
    }
}
