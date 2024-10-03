using BusinessLayer.Concreate;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Internal;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NTierArchitecture
{
    internal class Presentation
    {
        static void Main(string[] args)
        {
            //LOCATION CRUD

            //LocationManager locationManager = new LocationManager(new EFLocationDAL());
            //Location location = new Location();

            ////Location list
            //var values = locationManager.GetList();

            //void list()
            //{
            //    foreach (var value in values)
            //    {
            //        Console.WriteLine(value.LocationName);
            //        Console.WriteLine("-----------------");
            //    }
            //}

            //Location Insert
            //location.LocationName = "Rotterdam";
            //locationManager.TInsert(location);
            //list();

            //Location Delete
            //int id = int.Parse(Console.ReadLine());
            //var LocationId = locationManager.GetById(id);
            //locationManager.TDelete(LocationId);
            //list();

            //Location Update
            //int id = int.Parse(Console.ReadLine());
            //var LocationId = locationManager.GetById(id);
            //LocationId.LocationName = Console.ReadLine();
            //locationManager.TUpdate(LocationId);
            //list();


            //MENBER CRUD

            //MemberManager memberManager = new MemberManager(new EFMemberDAL());
            //Member member = new Member();

            ////LISTING
            //var values = memberManager.GetList();

            //void list()
            //{
            //    foreach (var value in values)
            //    {
            //        Console.WriteLine(value.MemberName + " " + value.MemberSurname);
            //        Console.WriteLine("------------------------");
            //    }
            //}
            //list();

            //member.MemberName = "Berkay";
            //member.MemberSurname = "Karaduman";
            //memberManager.TInsert(member);
            //list();

            //var memberId = memberManager.GetById(1);
            //memberId.MemberSurname = "Çınar";
            //memberManager.TUpdate(memberId);

            //var memberId = memberManager.GetById(9);
            //memberManager.TDelete(memberId);

            //CommentMenager commentMenager = new CommentMenager(new EFCommentDAL());
            //Comment comment = new Comment();


            //LISTING
            /*
             When working with Entity Framework, we need to create a separate method to list relational tables and do this.
            */
            //Context context = new Context();
            //var values = (from x in context.Comments
            //              join y in context.Locations
            //              on
            //              x.LocationId equals y.LocationId
            //              join z in context.Members
            //              on
            //              x.MemberId equals z.MemberId
            //              select new
            //              {
            //                  x.CommentId,
            //                  y.LocationName,
            //                  z.MemberName,
            //                  z.MemberSurname,
            //                  x.CommentContent
            //              }).ToList();
            //foreach (var value in values)
            //{
            //    Console.WriteLine(value.CommentId + " " + value.LocationName + " " + value.MemberName + " " + value.MemberSurname + " " + value.CommentContent);
            //    Console.WriteLine("-----------------------------------------");
            //}

            //commentMenager.TCommentListWithLocationAndMember();

            //Fluent Validation
            //MemberManager memberManager = new MemberManager(new EFMemberDAL());
            //Member member = new Member();
            //member.MemberName = "Berkay";
            //member.MemberSurname = "Karaduman";
            //MemberValidator memeberValidator = new MemberValidator();
            //ValidationResult result = memeberValidator.Validate(member);
            //if (result.IsValid)
            //{
            //    memberManager.TInsert(member);
            //    Console.WriteLine("Inserted successfully");
            //}
            //else
            //{
            //    foreach (var item in result.Errors)
            //    {
            //        Console.WriteLine(item.ErrorMessage);
            //    }
            //}

            //Save data in file
            LocationManager locationManager = new LocationManager(new EFLocationDAL());
            Location location = new Location();

            //Location list
            var values = locationManager.GetList();
            string path = "C:\\Users\\berka\\Desktop\\Test.txt";
            FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            foreach (var value in values)
            {
                writer.WriteLine(value.LocationName);
            }
            fileStream.Flush();
            writer.Close();
            fileStream.Close();
        }
    }
}
