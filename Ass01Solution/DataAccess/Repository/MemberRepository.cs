using BusinessObject;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
  {
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetList;
        public MemberObject GetMemberByID(int MemberID) => MemberDAO.Instance.GetMemberByID(MemberID);
        public void InsertMember(MemberObject member) => MemberDAO.Instance.Add(member);
        public void DeleteMember(int MemberID) => MemberDAO.Instance.Remove(MemberID);
        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

    }
}
