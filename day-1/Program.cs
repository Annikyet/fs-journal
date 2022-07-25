// See https://aka.ms/new-console-template for more information

// This works (explicit import)
// using System;
// Console.WriteLine("Hello, World!");

// So does this (implicit import)
// Console.WriteLine("mrowowow");

// and this (inline import)
// C# uses pascal-case (upper-camel) for globals and method name
System.Console.WriteLine("meow meow");

// var, const, (type)
// implicit typing, but strongly typed

// this is invallid
// var name;
// name  = "meow";

// so is this
// var name = "Saleem";
// name = 9;

// variables are case sensitivek
// strings always use doublequotes
// char is singlequote
// char are UTF-16

// string concatenation works
var catName = "Rye-bread";
string otherCatName = "Say-Say";
System.Console.WriteLine(catName + " & " + otherCatName);

// string interpolation
string meowName = $"{catName} {otherCatName}";
System.Console.WriteLine(meowName);

// line-breakABLE string
System.Console.WriteLine(@"meoww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwo
w3irnowrnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefo
iwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfrnowie
jfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irn
owiejfg weoijfrnowiejfg weoijfwenfd oiwhefo
iwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoi
wjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg 
weoijfiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd 
oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoi");
// System.Console.WriteLine("meoww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowrnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfrnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfrnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfiejfg weoijfwenfd oiwhefoiwjeoiirnowiejfg weoijfwenfd oiwhefoiwjeoifjwoei hooww mwow3irnowiejfg weoijfwenfd oiwhefoi");

// tryParse to convert string to int

// SECTION meow meow meow

Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.Cyan;
var meowPut = Console.ReadLine();
System.Console.WriteLine(meowPut);

// int, float (32-bit)
// other datatypes if you want

// no more truthy/falsy

// if (expression)
// {
//   Console.WriteLine("do a thing");
// }

//else if not elif


// List<String> cats = new List<String>();

// String[] cats = new String[2] {"Salem", "Riley"};

// Lists are length-mutable, arrays are not

// cats.Add("Frankie");
// cats.AddRange(arrCats);
// .RemoveAll is a filter, as is FindAll

// Loops
// for (int i = 0; i < cats.Count; i++)
// {
//   string cat = cats[i];~
// }

// foreach (var item in collection)
// {
  
// }

// cats.ForEach(c => );

// Objects
// POCOs - don't use them

// Dictionaries
// class, key-type, value-type
Dictionary<string, int> catAges = new Dictionary<string, int>();

catAges.Add("Riley", 11);
// Cannot add same key multiple times
catAges["Riley"] = 11;

// Classes
// namespaces can be implicit(?)
namespace day_1.models
{
  // export is implied
  // public - access modifier access from anywhere imported
  // internal - only access within day_1 (implied)
  // protected - only accessible if inherited
  // private - only be accessed within file
  public class Dinosaur
  {
    // constructor is always public
    // no return type
    // name is same as class
    public Dinosaur(string name, string diet) {
      Name = name;
      Diet = diet;
    }


    // // members (fields, properties, methods)
    // // public string Name; // field
    // private string _name;
    // // property
    // public string Name
    // {
    //   get
    //   {
    //     return _name;
    //   }
    //   set
    //   {
    //     _name = value;
    //   }
    // }
    public string Name { get; private set; }
    public string Diet { get; set; }

    public void ChangeName(string name) {
      Name = name;
    }

    public string Speak()
    {
      // must always return something, and must always be the same data type
      return "mrowwww";
    }
  }
}

char input = Console.ReadKey().KeyChar;

switch (input) {
  case 'q':
    //do stuff
    break;
  default:
    break;
}