﻿using System;
// ReSharper disable InconsistentNaming


namespace DTO
{
    public class CreateOrderGoodDTO
    {
        public DateTime date { get; set; }
    }

    public class UpdateOrderGoodDTO
    {
        public int id { get; set; }
        public DateTime date { get; set; }
    }
}
