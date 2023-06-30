# LinkedList
This code provides an implementation of a singly linked list in C#. It includes a Node class that represents a node in the linked list, and a LinkedList class that manages the list operations.

## Summary
The linked list implementation provides the following functionality:

- Creation of an empty linked list
- Insertion of nodes at the head of the list
- Checking if a value exists in the linked list
- Retrieving a string representation of the linked list
## Description
The Node class represents a node in the linked list. It has two properties: Value, which stores the value of the node, and Next, which points to the next node in the list.

The List class manages the operations on the linked list. It has a Head property that points to the first node in the list. The class provides the following methods:

- AddFirstList(int value) ,AddLastList(int value) : Inserts a new node with the given value at the head or the tail of the linked list.
- Includes(int value): Checks if a node with the specified value exists in the linked list.
- ToString(): Returns a string representation of all the values in the linked list.
## Approach & Efficiency
- Insertion: The Insert method adds a new node at the head of the linked list. It has a time complexity of O(1) since it always inserts at the beginning of the list.
- Includes: The Includes method iterates through the linked list to check if a node with the given value exists. It has a time complexity of O(n), where n is the number of nodes in the list.
- ToString: The ToString method constructs a string representation of the linked list by iterating through all the nodes. It has a time complexity of O(n), where n is the number of nodes in the list.
## Solution
To use the linked list implementation, you can create an instance of the List class and perform operations such as inserting nodes, checking for values, and retrieving the string representation.








