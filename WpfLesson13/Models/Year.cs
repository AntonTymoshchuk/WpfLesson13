using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLesson13.Models
{
    public class Year
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Season> Seasons { get; set; } = new List<Season>();
    }
}
