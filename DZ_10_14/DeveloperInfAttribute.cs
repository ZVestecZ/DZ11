using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_10_14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DeveloperInfAttribute : Attribute
    {
        public string DeveloperName { get; set; }
        public DateTime DateDeveloped { get; set; }

        public DeveloperInfAttribute(string developerName, string date)
        {
            DeveloperName = developerName;
            DateDeveloped = DateTime.Parse(date);
        }
    }
}
