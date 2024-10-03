using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDAL : GenericRepository<Comment>, ICommentDAL
    {
        public void commentListWithLocationAndMember()
        {
            Context context = new Context();
            var values = (from x in context.Comments
                          join y in context.Locations
                          on
                          x.LocationId equals y.LocationId
                          join z in context.Members
                          on
                          x.MemberId equals z.MemberId
                          select new
                          {
                              x.CommentId,
                              y.LocationName,
                              z.MemberName,
                              z.MemberSurname,
                              x.CommentContent
                          }).ToList();
            foreach (var value in values)
            {
                Console.WriteLine(value.CommentId + " " + value.LocationName + " " + value.MemberName + " " + value.MemberSurname + " " + value.CommentContent);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
