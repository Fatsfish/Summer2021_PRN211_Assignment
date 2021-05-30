using BusinessObject;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
    IEnumerable<MemberObject> GetMembers();
    MemberObject GetMemberByID (int MemberID);
    void InsertMember(MemberObject member);
    void DeleteMember(int MemberID);
    void UpdateMember(MemberObject member);
    }
}
