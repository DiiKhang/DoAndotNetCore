using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Model;



namespace Model.Dao
{
    public class UserDao
    {

        OnlineShop1Context db = null;
        public UserDao()
        {
            {
                db = new OnlineShop1Context();
            }
        }
        public long Insert(User entity)
        {
            db.Add(entity);
            db.SaveChanges();
            return entity.Id;
        }


        public User GetByID(int userID)
        {

            return db.User.Find(userID);

        }
        public bool Login(string userName, string passWrod)
        {
            var result = db.User.Count(x => x.Username == userName && x.Password == passWrod);
            if (result > 0)
            {
                return true;
            }
            else {

                return false;
                 }
        }


        }
}
