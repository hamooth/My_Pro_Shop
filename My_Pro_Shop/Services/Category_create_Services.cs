using My_Pro_Shop.DataSet;
using System;
using System.Collections.Generic;
using System.Linq;


namespace My_Pro_Shop.Services
{
    public class Category_create_Services
    {
        Repository _Repo;

        public Category_create_Services()
        {
            _Repo = new Repository();
        }

        public IEnumerable<Category_create_Table> ListAll()
        {
            return _Repo.GetAll<Category_create_Table>().ToList();
        }



        public void AddDataEntry1(string Category_name)
        {
            var mydata = new Category_create_Table
            {
                
                Category_Name = Category_name,

            };

            _Repo.AddData(mydata);
        }

        
    }
}