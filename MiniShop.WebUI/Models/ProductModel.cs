using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShop.WebUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        [Display(Name="Ürün Adı", Prompt ="Ürün adı giriniz")]
        public string Name { get; set; }

        [Display(Name="Ürün Fiyatı", Prompt ="Fiyatı giriniz")]
        public decimal Price { get; set; }

        [Display(Name="Açıklama", Prompt ="Özellikleri giriniz")]
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public DateTime DateAdded { get; set; }  
    }
}