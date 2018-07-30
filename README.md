# ContactAPI

Application consists of the basic CRUD functionalities related contact deatils.
i.e.
Fetching List of contacts
Add a contact
Edit/Update a contact
Delete a contact
Inactivate a contact 
Activate a contact

# Getting Started-
Build the project
Perform the testing using Postman by hitting the required URL.

# Prerequisites-
We require visual studio 2015 and the Postman API development application to be installed in the local machine.

# Installing the development environment-
Open the solution debug the same, get the base URL.
(or we need to publish the solution to the IIS)
Use the base Url + api request URI in the Postman.

# Pattern Use (Coding style)-
Dependency Injector - Ninject
Under application start folder, NinjectWebCommon.cs includes the function RegisterServices() which contains the mapping of concrete implementation of the interfaces (example - kernel.Bind<IContactDataAdaptor>().To<FileAdaptor>())
In this application we have used file database (.json) we can map with the SQL adaptor as well.
Implemented the Repository pattern.
