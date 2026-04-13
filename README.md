# Task Management System (OOP Demonstration)

A console-based application built with **C#** to manage different types of tasks. This project is designed to showcase the practical application of **Object-Oriented Programming (OOP)** concepts learned during my first year in Computer Science.

## 🚀 Features
- **Task Categorization:** Supports both `WorkTask` and `PersonalTask`.
- **Status Tracking:** Ability to mark tasks as complete.
- **Priority Management:** Uses an `IPriority` interface to handle priority levels for specific task types.
- **Filtered View:** Displays only the completed tasks to the user.

## 🛠️ OOP Concepts Applied
- **Abstraction:** Used an `abstract class BaseTask` to define the shared structure of all tasks.
- **Inheritance:** `WorkTask` and `PersonalTask` inherit from `BaseTask`.
- **Polymorphism:** Overriding methods like `GetTaskType()` to provide specific behavior for each subclass.
- **Interfaces:** Implemented `IPriority` to add optional functionality (Priority Setting) to classes without forcing it on all tasks.
- **Casting & Type Checking:** Used the `is` keyword to safely check for interface implementation at runtime.

## 📂 Project Structure
- `Program.cs`: The entry point and main logic.
- `BaseTask.cs`: The abstract parent class.
- `IPriority.cs`: The interface for priority control.
- `WorkTask.cs` & `PersonalTask.cs`: Specific task implementations.

  ## Developed as part of my Level 1 Computer Science studies at New Mansoura University.
