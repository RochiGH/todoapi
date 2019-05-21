using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class DoneItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
    }
}
