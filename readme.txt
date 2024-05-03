Self-Assessment: Onion Architecture, MVC, and Web API (.NET Core) with Bottlenecks (Encountered)
Conceptual Understanding:
 
Onion Architecture: (Yes/No) 
 
Have you heard of the Onion Architecture principle in software design?
Yes
 
 
MVC Pattern: (Yes/No) 
 
Are you familiar with the Model-View-Controller (MVC) pattern for building web applications?
Yes

 
Web API: (Yes/No) 
 
Do you understand the concept of building RESTful APIs using ASP.NET Core Web API?
No 
 
 

Application & Bottlenecks:
Onion Architecture:
 
 
Benefits: (1-3 keywords)
 
Briefly list some key benefits of using Onion Architecture in .NET Core projects. (e.g., separation of concerns, testability)
 
Reusability: Components in the core layer can be reused across different parts of the application or even in other projects. This promotes code reuse and reduces duplication.
Scalability: The modular nature of Onion Architecture allows for easier scalability. As the application grows, new features can be added without disrupting existing functionality.
Separation: Separation enhances maintainability and makes it easier to understand and modify individual components without affecting others.
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with Onion Architecture in your projects? If so, briefly describe the bottleneck(s). (e.g., Increased complexity for simple projects, difficulty finding developers familiar with the pattern)
Yes, in some of my projects implementing the onion architecture is not necessary and even takes longer for me to complete the simple project.
 
MVC:
 
Components:

Model: Data representation, business logic.
View: User interface, presentation layer.
Controller: Mediates between Model and View, handles user input, updates Model, selects View.


Briefly describe the roles of the Model, View, and Controller in the MVC pattern.
Model: Represents the data and logic of the application.
View: Presents the data to the user and handles user interactions. It's responsible for the visual representation of the application.
Controller: Handles user input, updates the model, and selects the appropriate view to render. It acts as an intermediary between the Model and View. 
 
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
Have you encountered any challenges with tight coupling between Model and Controller in MVC projects? If so, briefly describe the issue(s). (e.g., Difficulty in unit testing controllers, logic changes rippling through the application)
Yes, but it is due to the lack of experience in mvc causing me to lose time trying to figure out what i am looking at. 
 
 

Web API:
 
 
Differences from MVC: (Yes/No and Briefly Explain)
 
 
Can you differentiate between traditional MVC applications and Web APIs? Briefly explain the main difference.
 
No, because i have not learnt what the differences are yet.
 
 
Bottlenecks (Encountered): (Yes/No and Briefly Explain)
 
Have you encountered any performance challenges with traditional MVC applications compared to Web APIs? If so, briefly describe the scenario(s). (e.g., Frequent page refreshes causing performance overhead, complex data exchange requiring a more lightweight approach)'
no, i do not have that much experience with APIs