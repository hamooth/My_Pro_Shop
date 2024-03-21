using My_Pro_Shop.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Pro_Shop.Services
{
    public class Loginservices
    {
        Repository _Repo;
        public Loginservices()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Login_Table> ListAll()
        {
            return _Repo.GetAll<Login_Table>().ToList();
        }

        public void AddData(string loginrole, string Uname, string Pwd)
        {
            var mydata = new shop_firstEntities.DataSet.Login_Table()
            {
                loginrole = loginrole,
                Username = Uname,
                Password = Pwd
            };


            _Repo.AddData(mydata);
        }

    }
}
