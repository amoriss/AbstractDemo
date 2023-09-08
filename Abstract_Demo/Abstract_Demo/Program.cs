using Abstract_Demo;
using Abstract_Demo.Shapes;
// Polymorphism is one thing having many forms

// ex. Console.WriteLine() ---> This method has 17 different forms (overloads)
// AKA Static polymorphism

// Static polymorphism
Console.WriteLine();

// Dynamic Polymorphism

Customer c1; //of type Customer

var bronzeCustomer = new BronzeTierCustomer();
var silverCustomer = new SilverTierCustomer();
var goldCustomer = new GoldTierCustomer();

//Console.WriteLine("Please enter 1 for Bronze, 2 for Silver, and 3 for Gold");
//var userInput = int.Parse(Console.ReadLine());

//if (userInput == 1)
//{
//    c1 = bronzeCustomer;
//}
//else if (userInput ==1)
//{
//    c1 = silverCustomer;
//}
//else
//{
//    c1 = goldCustomer;
//}

//c1.PrintCustomerName(); //from what class are we calling this method?

//depends on what the object is assigned


// you cannot instantiate an abstract class
//cannot do this--- > var customer = new Customer();

//purpose is to act as a hybrid template

//var c2 = new GoldTierCustomer();
//c2.PrintCurrentDate();

var square1 = new Square();
var circle1 = new Circle();
var triangle1 = new Triangle();

var shapes = new List<Shape>();
shapes.Add(square1);
shapes.Add(circle1);
shapes.Add(triangle1);

foreach (var shape in shapes)
{
    Console.WriteLine(shape.NumberOfSides);
    shape.GetArea();
}
