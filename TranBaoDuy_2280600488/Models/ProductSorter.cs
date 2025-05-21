using System;
using System.Collections.Generic;
using System.Linq;
using TranBaoDuy_2280600488.Models;

namespace TranBaoDuy_2280600488.Helpers
{
    public static class ProductSorter
    {
        public static IEnumerable<Product> Sort(
            IEnumerable<Product> products,
            string sortBy,
            string sortOrder)
        {
            sortBy = sortBy?.ToLower();
            sortOrder = sortOrder?.ToLower();

            return (sortBy, sortOrder) switch
            {
                ("title", "asc") => products.OrderBy(p => p.Name),
                ("title", "desc") => products.OrderByDescending(p => p.Name),
                ("price", "asc") => products.OrderBy(p => p.Price),
                ("price", "desc") => products.OrderByDescending(p => p.Price),
                _ => products.OrderBy(p => p.Name) // mặc định
            };
        }
    }
}
