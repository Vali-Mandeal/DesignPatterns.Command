# DesignPatterns.Command
This is a demonstration from my DesignPattern series.

---

Command is a Behavioral Design Pattern that turns a request into a stand-alone object that contains all information about the request. 
This transformation lets you pass requests as method arguments.

Real life uses of this pattern are queuing operations, scheduling their execution, executing them remotely or undoing operations.

---

In the first example (v1) I made an app that mimics the ordering cycle at a restaurant.
An order (command) is passed to the waiter (invoker) and that command object is in turn passed to a receiver (either Bartender for drinks or Cook for food).

![image](https://user-images.githubusercontent.com/51697555/198310035-123d2c39-6381-4809-b076-0848ec96d8f1.png)

---

In the second example (v2) I made an app that mimics the behavior of a shopping basket.
Here I take advantage of the Command undo feature.

As you can see in the snip below, I have 6 items. The actions are performed in the following order:
1) 3 items are being added in the basket
2) An undo operation is taking place
3) Another 3 items are being added

![image](https://user-images.githubusercontent.com/51697555/198554387-ff129fae-1804-476c-9f6c-1ac11043d1a3.png)
