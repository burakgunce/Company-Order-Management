﻿using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Order : Entity
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }

        public string FirmaId { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
