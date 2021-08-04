using Sintaxis.Collections.Pagination.Extensions;
using System;
using System.Linq;
using Xunit;

namespace Sintaxis.Test
{
    public class PaginationTests
    {
        [Fact]
        public void ShouldReturnExceptionWhenSourceParameterIsNull()
        {
            IQueryable<int> mockCollection = Enumerable.Range(1, 100).AsQueryable();
            mockCollection = null;

            var exception = Assert.Throws<ArgumentException>(() => mockCollection.Paginate(1,10));

            Assert.IsType<ArgumentException>(exception);
        }
        
    }
}
