using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using projectevent.ViewModel;
namespace projectevent.Models
{
    public class photorepo
    {
        private static eventDBEntities context = new eventDBEntities();
        public static List<photoview> getallphotographers()
        {
              eventDBEntities context = new eventDBEntities();
            var q = from e in context.photographies
                    select new photoview {
                        photographyID=e.photographyID,
                        photographer_name=e.photographer_name,
                    photographer_phone=e.photographer_phone,
                    photographer_cost=e.photographer_cost};
            return q.ToList();
        }
        public static bool InsertPhoto(photography newphoto)
        {
            try
            {
                context.photographies.Add(newphoto);
                context.SaveChanges();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public static photography GetPhoto(int photoid)
        {
            var res1 = from emp in context.photographies
                       where emp.photographyID == photoid
                       select emp;
            return res1.SingleOrDefault();
        }
        public static bool UpdatePhoto(photography modphoto)
        {
            var query = from e in context.photographies
                        where e.photographyID == modphoto.photographyID
                        select e;
            if (query.Any())
            {
                var ExEmp = query.First();
                ExEmp.photographer_name = modphoto.photographer_name;
                ExEmp.photographer_phone = modphoto.photographer_phone;
                ExEmp.photographer_cost = modphoto.photographer_cost;
                context.SaveChanges();

                return true;
            }
            return false;
        }
        public static List<photoview> DeletePhoto(int photographyID)
        {
            var photo = GetPhoto(photographyID);
            if (photo != null)
            {
                context.photographies.Remove(photo);
                context.SaveChanges();

            }

            return getallphotographers();

        }
    }
}


