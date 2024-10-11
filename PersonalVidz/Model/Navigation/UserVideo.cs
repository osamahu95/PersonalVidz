using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Navigation
{
    public class UserVideo
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual User? User { get; set; }
        public Guid VideoId { get; set; }
        public virtual Video? Video { get; set; }
    }
}
