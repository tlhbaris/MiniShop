using System;
using System.Collections.Generic;

namespace MiniShop.Entitiy
{
    public class Category
    {

        public int CAtegoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }




         public List<ProductCategory> ProductCategories { get; set; }

        


 




    }





}