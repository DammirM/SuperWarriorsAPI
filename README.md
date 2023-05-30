The structure of the system:
Separation of the layerers of Models and Controllers was done in purpose of separating logic and API code. The creation of the program in steps: 1.Models (objects) 2.ModelRepositories (objectRepositories) 3.Interfaces (to implement repository pattern) 4.Controllers(API)

Pros
Another advantage of using .NET is the wide range of tools and resources available to develop the application, making it possible to find and use the best technical methods to solve the problem. For example, lambda expressions, Dependency Injection (DI), and LINQ syntax have been used in the code.

Cons
A disadvantage of this solution may be that it can be perceived as somewhat heavyweight and complex. This can lead to longer development times and higher maintenance costs.

Summary
In summary, I believe that the choice of .NET and the use of repositories and the DAO pattern are a suitable solution for this project. It provides a scalable and maintainable architecture while giving developers the flexibility to choose the technical methods that are most appropriate for the project. The choice to have interfaces which decide which methods the classes will be able to perfor, to later construct and use in a controller, is indeed a good arcitecture-design, to create a possibility to recreate according to the interface.
