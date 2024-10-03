using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CommentMenager : ICommentService
    {
        ICommentDAL _commentDAL;

        public CommentMenager(ICommentDAL commentDAL)
        {
            _commentDAL = commentDAL;
        }

        public Comment GetById(int id)
        {
            return _commentDAL.GetById(id);
        }

        public List<Comment> GetList()
        {
            return _commentDAL.GetList();
        }

        public void TCommentListWithLocationAndMember()
        {
            _commentDAL.commentListWithLocationAndMember();
        }

        public void TDelete(Comment t)
        {
            _commentDAL.Delete(t);
        }

        public void TInsert(Comment t)
        {
            _commentDAL.Insert(t);
        }

        public void TUpdate(Comment t)
        {
            _commentDAL.Update(t);
        }
    }
}
