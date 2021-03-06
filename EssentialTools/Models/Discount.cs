﻿namespace EssentialTools.Models
{
    public interface IDiscountHelper
    {
        decimal ApplyDiscount(decimal totalParam);
    }

    public class DefaultDiscountHelper : IDiscountHelper
    {
        //public decimal  DiscountSize { get; set; }

        public decimal ApplyDiscount(decimal totalParam)
        {
            return (totalParam - (10m / 100m * totalParam));
        }
    }
}