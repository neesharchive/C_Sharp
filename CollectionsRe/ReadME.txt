Understand what a collection is and how it differs from a basic array.

Understand what System.Collections and System.Collections.Generic namespaces offer and why generics matter.

Learn about boxing and unboxing and why it matters in the context of collections.

Understand the limitations of non-generic collections like ArrayList, Hashtable, Queue, and Stack.

Learn List<T> in depth — how it stores data, how indexing works, how resizing and capacity are handled.

Learn Dictionary<TKey, TValue> and how it internally uses hashing to store and retrieve data.

Learn the role of GetHashCode() and .Equals() in hash-based collections.

Learn HashSet<T> and how it ensures uniqueness without keys.

Learn how Queue<T> and Stack<T> implement FIFO and LIFO respectively, and their typical use cases.

Learn SortedList<TKey, TValue> and SortedDictionary<TKey, TValue>, and understand how sorting by keys works under the hood.

Understand how LinkedList<T> works, where it’s useful, and why it’s usually slower in .NET.

Learn about ObservableCollection<T> and its role in UI binding scenarios.

Learn about ReadOnlyCollection<T> and how to wrap collections to prevent modification.

Learn ConcurrentBag<T>, ConcurrentDictionary<TKey, TValue>, and other thread-safe collections.

Understand the full purpose of IEnumerable<T> and how it enables foreach.

Understand IEnumerator<T> and how it’s used to traverse a collection manually.

Understand ICollection<T> and its responsibilities like Count, Add, Remove.

Understand IList<T> and how it allows indexed access and element positioning.

Understand IDictionary<TKey, TValue> and how it standardizes key-value structures.

Understand ISet<T> and how it's used to enforce uniqueness with set operations.

Learn how to create your own collection class like MyList<T> with methods like Add, Remove, Clear, and Count.

Learn how to implement IEnumerable<T> in your custom collection to support foreach.

Learn how to implement a custom IEnumerator<T> and build your own enumerator logic.

Learn how to implement ICollection<T> and optionally IList<T> to make your custom collection behave like built-in ones.

Learn how to override Equals() and GetHashCode() in your custom types to work correctly in hash-based collections.

Learn how List<T> doubles its capacity on internal resize and what happens during array copying.

Learn how Dictionary<TKey, TValue> calculates hash bucket indexes and how it resolves collisions using chaining or probing.

Learn about load factor and how dictionaries resize and rehash when they reach capacity.

Learn why performance can degrade if GetHashCode() is poorly designed or inconsistent with .Equals().

Learn how LINQ extends collection behavior with methods like Where, Select, ToList, ToDictionary, Distinct, and GroupBy.

Learn how to use Comparer<T> and IEqualityComparer<T> for custom sorting and hash key equality logic.

Learn when to use which collection (List vs Dictionary vs HashSet vs LinkedList) based on performance characteristics and use cases.

Understand collection traversal performance — indexing, insertion, deletion time complexities.

Build a full-featured user-defined collection that behaves like List<T>, with interface support and custom enumerator.

Practice using all built-in collections in actual problem-solving: grouping, searching, deduplicating, and mapping.

Practice writing reusable methods that accept and return collections using only their interface types, not concrete types.

Practice refactoring code from arrays to collections and from non-generic to generic versions to enforce type safety.

Be able to explain how each major collection type is implemented internally, what interface it supports, and when to use it.

Know how to debug and fix collection issues caused by missing or incorrect Equals() or GetHashCode() implementations.

Finally, build your own tiny collection library that mimics List, Set, and Map, using generics, interfaces, and enumerators.