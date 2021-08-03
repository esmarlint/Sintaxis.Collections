# Sintaxis.Collections
A group of extensions to facilitate collection manipulation and data filtering.

The principal usability of this code is avoid boilerplate code and facilitate the some commons actions executed over collections.

#Pagination example

//Return an IQueryable that will paginate de collection an return 10 elements for the first page of the IQueryable

```IQueryable<object> objects = Enumerable.Range(1,100).AsQueryable().Paginate(1,10);```

