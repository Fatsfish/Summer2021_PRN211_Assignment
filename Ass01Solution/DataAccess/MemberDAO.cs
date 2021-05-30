using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class MemberDAO
    {
        private static List<MemberObject> MemberList = new List<MemberObject>
        {
            new MemberObject{ MemberID=1, MemberName="Dêm", City="HCM", Country="VN", Email="Dêm@Dêm.com", Password="1"},

            new MemberObject{ MemberID=2, MemberName="NDungx", City="HCM", Country="VN", Email="ND@Dêm.com", Password="1"}
            };

        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<MemberObject> GetList => MemberList;

        public MemberObject GetMemberByID(int memberID)
        {
            MemberObject member = MemberList.SingleOrDefault(prop => prop.MemberID == memberID);
            return member;
        }
        public void Add(MemberObject member)
        {
            MemberObject mem = GetMemberByID(member.MemberID);
            if (mem == null) MemberList.Add(mem);
            else throw new Exception("Car is already exists.");
        }
        public void Update(MemberObject member)
        {
            MemberObject mem = GetMemberByID(member.MemberID);
            if (mem != null)
            {
                var index = MemberList.IndexOf(mem);
                MemberList[index] = member;
            }
            else throw new Exception("Car is not already exists.");
        }
        public void Remove( int MemID)
        {
            MemberObject mem = GetMemberByID(MemID);
            if (mem != null)
            {
                MemberList.Remove(mem);
            }
            else throw new Exception("Car is not already exists.");
        }
    }
    
}

