# Uninitialized Property Access in C#

This repository demonstrates a common C# error: accessing an uninitialized property.  The `ExampleClass` in `bug.cs` attempts to access the `MyProperty` property before it has been assigned a value. This can result in unexpected behavior, often default values (0 for integers), or even exceptions depending on the property type and context.

The solution, shown in `bugSolution.cs`, illustrates initializing the property either directly in the class declaration or within the constructor. This prevents the issue of accessing an undefined value.

## How to Reproduce
1. Clone the repository.
2. Compile and run `bug.cs`. Note the output.
3. Compile and run `bugSolution.cs`. Observe the different and expected behavior.