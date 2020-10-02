using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLesson13.Models
{
    public class Season
    {
        public string Name { get; set; }
        public List<Month> Months { get; set; } = new List<Month>();
    }
}
