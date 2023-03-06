﻿namespace Application.Features.Queries.Response
{
    public class GetByIdProductQueryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
