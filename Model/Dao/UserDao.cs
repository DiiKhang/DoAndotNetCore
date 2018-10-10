using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Dao
{
    
    public class UserDao
    {

        OnlineShop1Context db = null;


        public UserDao()
        {

            db = new OnlineShop1Context();

        }
        public long Insert(User entity)
        {

            db.User.Add(entity);
            db.SaveChanges();
            return entity.Id;


        }
        public bool Login(string userName, string passWrod)
        {

            var result = db.User.Count(x => x.Username == userName && x.Password == passWrod);
            if (result > 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

    }
}
