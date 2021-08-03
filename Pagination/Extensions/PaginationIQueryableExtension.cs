using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sintaxis.Collections.Pagination.Extensions
{
    public static class PaginationIQueryableExtension
    {
        public static IQueryable<T> Paginate<T>(this IQueryable<T> target, int page, int pageSize)
        {
            target = target
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            return target;
        }
    }
}
