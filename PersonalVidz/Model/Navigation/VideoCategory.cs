using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Navigation
{
    public class VideoCategory
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public Guid VideoId { get; set; }
        public virtual Video? Video { get; set; }
    }
}
