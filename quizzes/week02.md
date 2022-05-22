# Intro to JavaScript

**1.** Which keywords are used to declare a variable in JavaScript?
<!-- enter you answer in the space below -->
```js
let myVar
var myGlobalVar
```
**2.** What is the definition of a function?
<!-- enter you answer in the space below -->
```js
function myFunction(parameter) {
  let someValue
  // do stuff
  return someValue
}
```
**3.** What are the `SOLID` principles?
<!-- enter you answer in the space below -->
```
Single responsibility
Open-closed
Liskov Substitution
Interface segregation
Dependency inversion
```
**4.** Given this array: 
```js
let fruit = ['apple', 'banana', 'pineapple',  'orange', 'strawberry']
``` 
What index is the pineapple's current position? How do you know?
<!-- enter you answer in the space below -->
```js
console.log(fruit[2])
// pineapple
// arrays are always 0 indexed
```
**5.** With these two objects: 
```js
let you = { name:"You", hair: true, friends: [] }
let them = { name:"Them", hair: false, friends: [] }
```
how would you .push the `them` object into the `you` object's array of friends?
<!-- enter you answer in the space below -->
```js
you.friends.push(them)
```

**6.** Give an example of a JavaScript `Conditional`:
<!-- enter you answer in the space below -->
```js
if (isTrue1) {
  // Do a thing if isTrue1 evaluates to true
}
else if (isTrue2) {
  // Do a different thing if isTrue1 evaluates to false and isTrue2 evaluates to true
}
else {
  // Do another thing is isTrue1 and isTrue2 both evaluate to false
}
```
**7.** In the `for loop` below, what is the name of the piece belongs inside the empty "______" space? What would you put here to increase `i` by one on every iteration?
```js
for ( let i = 0; i < arr.length; _______ ) {
  //...
```
<!-- enter you answer in the space below -->
```
The iterator.
i++
```
**8.** What does the `DOM` acronym stand for? Which file is first accessed to render the `DOM`?
<!-- enter you answer in the space below -->
```
Document Object Model
index.html
```

**9.** What are the `9` ECMAScript types as defined by MDN?
<!-- enter you answer in the space below -->
```
Null
Undefined
Boolean
Number
String
BigInt
Symbol
Objects
```
**10.** When it comes to functions or methods, what is the difference between a `parameter` and an `argument`?
<!-- enter you answer in the space below -->
```
Parameter is the variable passed to the function containing the argument's value at declaration.
Argument is the value passed to the function at invocation.
```
**11.** What is the difference between a `primitive` value and a `reference` value?
<!-- enter you answer in the space below -->
```
primitives are values themselves (numbers, strings, booleans, etc)
reference values are data types that refer to a memory location containing other values (objects)
```