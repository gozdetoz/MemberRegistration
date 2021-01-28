using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.ServiceAdapters
{
    public class TestKpsService:IKpsService
    {
        public bool ValidateUser(Member member)
        {
            return true;
        }
    }
}
