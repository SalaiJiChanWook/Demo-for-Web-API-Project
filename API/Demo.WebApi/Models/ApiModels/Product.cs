using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WebApi.Models.ApiModels
{
    public class Product
    {
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public string? ProductCode { get; set; }

        public decimal Price { get; set; }

        public bool Isdeleted { get; set; }
    }
}
