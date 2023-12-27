using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace davaleba5_2
{
    internal class WebPage
    {
        public string _name;
        public string _path;
        public string _description;
        public string _ip;

        public void Webpage(string name, string path, string description, string ip)
        {
            name = _name;
            path = _path;
            description = _description;
            ip = _ip;
        }

        public void ShowWeb()
        {
            Console.WriteLine($"Name: {_name}\nPath: {_path}\nDescription: {_description}\nIP: {_ip}");
        }

        public string GetSiteName()
        {
            return _name;
        }

        public void SetSiteName(string value)
        {
            _name = value;
        }

        public string GetPath()
        {
            return _path;
        }

        public void SetPath(string value)
        {
            _path = value;
        }

        public string GetSiteDescription()
        {
            return _description;
        }

        public void SetSiteDescription(string value)
        {
            _description = value;
        }

        public string GetIpAddress()
        {
            return _ip;
        }

        public void SetIpAddress(string value)
        {
            _ip = value;
        }
    }      
 }

