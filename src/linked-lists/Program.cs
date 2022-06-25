// See https://aka.ms/new-console-template for more information
//dotnet new console --framework net5.0

using linked_lists;

var linkedList = new LinkedList();
var head = new Node(10);
linkedList.Head = head;
var secondNode = new Node(20);
var thirdNode = new Node(30);
linkedList.AddEelementAtEnd(secondNode);
linkedList.AddEelementAtEnd(thirdNode);
linkedList.PrintElements();
