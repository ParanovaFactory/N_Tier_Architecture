# NTier Architecture Example

This project demonstrates the **NTier Architecture** using **.NET**. The project is structured in multiple layers that follow the best practices of separation of concerns. It is a practical example of how to organize code for scalable, maintainable, and flexible applications.

---

## 🚀 Features

- **NTier Architecture**: This project uses a layered architecture with distinct layers to separate different aspects of the application, such as:
  - **Presentation Layer** (UI)
  - **Business Logic Layer** (BLL)
  - **Data Access Layer** (DAL)
- **Separation of Concerns**: Each layer has a clear responsibility, ensuring maintainability and scalability.
- **Scalability**: Easily extendable with new layers, services, or modules.

---

## 🧱 Technologies

- **Language**: C#
- **Platform**: .NET
- **Framework**: ASP.NET Core (if applicable)
- **Architecture**: NTier (Presentation, Business Logic, Data Access Layers)

---

## 🎨 Layers in NTier Architecture

### 1. **Presentation Layer**
This layer contains the user interface and handles user interactions. It is responsible for displaying data to the user and passing user inputs to the business logic layer for processing.

**Example Code**: `Presentation.cs`
```csharp
// Presentation layer example: Handles the user interface logic
public class Presentation
{
    private readonly IBusinessLogic _businessLogic;

    public Presentation(IBusinessLogic businessLogic)
    {
        _businessLogic = businessLogic;
    }

    public void DisplayData()
    {
        var data = _businessLogic.GetData();
        Console.WriteLine(data);
    }
}
