using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class Video
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? URL { get; set; }
        public int Status { get; set; }
    }
}
