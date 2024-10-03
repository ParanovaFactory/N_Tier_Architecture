using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public string CommentContent { get; set; }
        public bool CommentStatus { get; set; }
    }
}
