# Uninitialized Property Access in C#

This repository demonstrates a subtle but common error in C#: accessing a class member (specifically, a property) before it has been assigned a value.  Unlike some languages that throw an exception in this scenario, C# will often default to a zero value (for value types) or null (for reference types), potentially leading to unexpected behavior and difficult-to-debug issues.

The `bug.cs` file contains code exhibiting this problem. The `bugSolution.cs` shows how to correctly initialize the property to avoid this issue.