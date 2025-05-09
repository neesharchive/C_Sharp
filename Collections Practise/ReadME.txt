# SmartSetList<T>

SmartSetList is a user-defined generic collection class in C# that behaves like a combination of a list and a set. It stores unique items while maintaining insertion order. No interfaces like IEnumerable or ICollection are implemented.

## Features

- Add items only if they are not already present.
- Delete items if they exist in the collection.
- Check if a specific item exists.
- Get the number of items in the collection.
- Clear all items.
- Print all items in insertion order.

## Methods

- void Add(T item)
- void Delete(T item)
- bool Contains(T item)
- int Count()
- void Clear()
- void PrintAll()

## Usage Example

```csharp
SmartSetList<int> n = new SmartSetList<int>();
n.Add(1);
n.Add(2);
n.Add(1); // Duplicate ignored
n.PrintAll(); // Output: 1 2
n.Delete(1);
Console.WriteLine(n.Contains(2)); // True
Console.WriteLine(n.Count()); // 1
