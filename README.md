# DependencyInjection

In this project, you have implemented the Dependency Injection design pattern in C#. You have created four classes (DatabaseLog, FileLog, EmailNotification, and SMSNotification) that implement two interfaces (ILog and INotification). The Customer class has two constructor parameters of type ILog and INotification, respectively.

You have created a test method called TestCustomer that instantiates three Customer objects with different combinations of the ILog and INotification implementations. When the Add method of each Customer object is called, it logs a message using the ILog implementation and sends a notification using the INotification implementation.
