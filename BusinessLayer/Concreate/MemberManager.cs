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
    public class MemberManager : IMemberService
    {
        IMemberDAL _memberDal;

        public MemberManager(IMemberDAL memberDal)
        {
            _memberDal = memberDal;
        }

        public Member GetById(int id)
        {
            return _memberDal.GetById(id);
        }

        public List<Member> GetList()
        {
            return _memberDal.GetList();
        }

        public void TDelete(Member t)
        {
            _memberDal.Delete(t);
        }

        public void TInsert(Member t)
        {
            _memberDal.Insert(t);
        }

        public void TUpdate(Member t)
        {
            _memberDal.Update(t);
        }
    }
}
