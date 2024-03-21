using My_Pro_Shop.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;

namespace My_Pro_Shop.Services
{
    public class Worker_Register_services
    {
        Repository _Repo;
      

        public Worker_Register_services()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Table_Worker_Register> ListAll()
        {
            return _Repo.GetAll<Table_Worker_Register>().ToList();
        }

        

        public void AddDataEntry(string worker_id, string fname, string lname, DateTime dob, string gender, int pnumber, string nic, string address, string state, string city, string email, string qualification, string eskille, byte[] img)
        {
            byte[] Picture = null;
            var mydata = new shop_firstEntities.DataSet.Table_Worker_Register()
            {
                Woker_ID = worker_id,
                First_Name = fname,
                Last_Name = lname,
                DOB = dob,
                Gender = gender,
                Phone_Number = pnumber,
                NIC = nic,
                Address = address,
                State = state,
                City = city,
                Email = email,
                Qualification = qualification,
                Extra_Skills = eskille,
                Picture = Picture,


            };


            _Repo.AddData(mydata);
        }
    }
}
