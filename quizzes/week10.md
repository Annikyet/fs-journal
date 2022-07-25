# C# Fundamentals


**1.** What is the purpose of a `namespace`?
<!-- enter you answer in the space below -->
```
to hold collections of objects for reference within another module.
```
**2.** What is the difference between a `class` and a `struct`?
<!-- enter you answer in the space below -->
```
classes has inheritance and other weird oop properties.
```
**3.** What is the method that returns an instance of a class, yet it has no return type?
<!-- enter you answer in the space below -->
```
static method?
```
## Example 1
```c#
abstract class Car
{
  ...
  public virtual string Start()
  {
    return "Vroooom";
  }
}
```
**5.** In the example what is the access modifier of the `Start()` method?
<!-- enter you answer in the space below -->
```
public
```
**6.** In the example what is `string` an indication of?
<!-- enter you answer in the space below -->
```
type
```
**7.** In the example what is `abstract` preventing?
<!-- enter you answer in the space below -->
```
concrete-ness?
```
**8.** In the example what is the purpose of `virtual`?
<!-- enter you answer in the space below -->
```
can only run in virtual machines?
```
**9.** Name four access modifiers:
<!-- enter you answer in the space below -->
```
public, private, internal, scoped(?)
```
**10.** If you set a class or method to private, what can access it?
<!-- enter you answer in the space below -->
```
only itself.
```