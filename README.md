# DesignPatterns.Command
This is a demonstration from my DesignPattern series.

---

Command is a Behavioral Design Pattern that turns a request into a stand-alone object that contains all information about the request. 
This transformation lets you pass requests as method arguments.

Real life uses of this pattern are queuing operations, scheduling their execution, executing them remotely or undoing operations.

---

In this example I made an app that mimics the ordering cycle at a restaurant.
An order (command) is passed to the waiter (invoker) and that command object is in turn passed to a receiver (either Bartender for drinks or Cook for food).

![image](https://user-images.githubusercontent.com/51697555/198310035-123d2c39-6381-4809-b076-0848ec96d8f1.png)
