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
            int page = 1;
            int pageSize = 10;
            IQueryable<int> mockCollection = Enumerable.Range(1, 100).AsQueryable();
            mockCollection = null;

            var exception = Assert.Throws<ArgumentException>(() => mockCollection.Paginate(page, pageSize));

            Assert.IsType<ArgumentException>(exception);
        }

        [Fact]
        public void ShouldReturnFrom10To30WhenPageIs2AndTotalIs100()
        {
            int expectedPaginated = 10;
            int expectedFirstPaginatedElement = 11;
            int expectedLastPaginatedElement = 20;
            int page = 1;
            int pageSize = 10;
            IQueryable<int> mockCollection = Enumerable.Range(1, 100).AsQueryable();

            var paginatedResult = mockCollection.Paginate(page, pageSize);
            var firstPaginatedResult = paginatedResult.First();
            var lastPaginatedResult = paginatedResult.Last();

            Assert.Equal(paginatedResult.Count(), expectedPaginated);
            Assert.Equal(expectedFirstPaginatedElement, firstPaginatedResult);
            Assert.Equal(expectedLastPaginatedElement, lastPaginatedResult);
        }

    }
}
