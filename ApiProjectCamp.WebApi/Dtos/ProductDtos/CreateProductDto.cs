﻿namespace ApiProjectCamp.WebApi.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
