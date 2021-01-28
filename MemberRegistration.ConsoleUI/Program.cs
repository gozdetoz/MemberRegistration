using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.DependencyResolvers.Ninject;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();
            memberService.Add(new Member{Email = "engindemirog@gmail.com", FirstName = "Engin", LastName = "Demiroğ", DateOfBirth = new DateTime(1985,1,6), TcNo = "28861499108"});
            Console.WriteLine("Eklendi");
            Console.ReadLine();
        }
    }
}
