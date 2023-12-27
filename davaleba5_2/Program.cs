using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebPage page = new WebPage();
            page.SetSiteName("Youtube.com");
            page.SetPath("https://www.youtube.com/");
            page.SetSiteDescription("Youtube Videos");
            page.SetIpAddress("100.10.10.11");
            page.ShowWeb();
        }
    }
}
