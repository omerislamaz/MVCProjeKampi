using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericReporsitory<Category> repo = new GenericReporsitory<Category>();

        public List<Category> GettAllBL()
        {
            return repo.List();
        }

        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(p);
            }
        }
    }
}
