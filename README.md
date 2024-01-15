# Guided Assignment - Implementing Method Overloading in C#

## Introduction
Method overloading is a feature in C# that allows a class to have multiple methods with the same name, but with different parameters. It enhances the readability and reusability of the code, allowing methods to perform similar functions while handling different types and numbers of arguments.

## What is Overloading?

Method overloading is when you have multiple methods in a class with the same name but different parameters. This feature allows methods to perform essentially the same function, tailored to different input types or counts.

***Example Code***
```csharp
// Method Overloading
public string MethodName(int num1, int num2) { /*.. Code ..*/ }
public string MethodName(double num1, double num2) { /*.. Code ..*/ }
```

***Example Usage***
```csharp
public static void Main(string[] args) {
	MethodName(1, 2);
	MethodName(5.4, 1.3);
}
```

The compiler determines at compile time which method variant to call based on the argument types. This helps keep the namespace clean and avoids redundant method names.

---

## Detailed Requirements

**Project Setup (20 Points):**

- Create a new console application in your IDE.
- Name the project `GA_MethodOverloading_YourName`.

**Understanding of Method Overloading (15 Points):**

- Write an explanation of method overloading in C#.
- Describe how method overloading works with different parameter types and counts.
- Explain the benefits of using method overloading in a software application.

**Implementation of Method Overloading (15 Points):**

- Implement method overloading in C# within a class.
- Create methods with the same name but different parameters (varying types and counts).
- Ensure your code demonstrates the concept of method overloading effectively.

**Explanation of Method Logic (15 Points):**

- Provide comments explaining:
    - The reason for using method overloading.
    - How different methods with the same name are resolved.
    - Examples of scenarios where method overloading is beneficial.

**Implementing Efficient Method Overloads (15 Points):**

- Implement method overloads that handle

different types of data efficiently.
- Explain through comments how these overloads cater to different data types or scenarios.
- Discuss the role of these overloads in making the code more flexible and maintainable.

**Optimizing the Method Overloading Process (10 Points):**

- Optimize the method overloads to handle edge cases or specific data patterns.
- Explain how this optimization improves the usability and reliability of the methods.
- Discuss the importance of optimization in method overloading for better performance.

**Code Testing and Output Accuracy (5 Points):**

- In the `Main` method, create test cases to demonstrate method overloading.
- Test with different data types and argument counts.
- Verify that the correct method overloads are being called and producing accurate results.

**Submission (5 Points):**

- Upload the complete project to GitHub.
- Make the repository public and include all necessary files.
- Provide the GitHub repository link in your Canvas submission.

**Total (100 Points):**

- Each section is required.
- Points are awarded based on meeting the detailed requirements accurately.

Follow these requirements closely to meet all the criteria outlined in the rubric for your assignment.

---
## Step By Step

## Step 1 - Math Operations

1. Create a new class called `MathOperations`.
2. Add the following code.

```csharp
public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

	public double Add(double a, double b, double c) {
		return a + b + c;
	}
}
```

Here's how this works:

- The first `Add` method takes two integer parameters and returns their sum as an integer.
- The second `Add` method takes two double parameters and returns their sum as a double.
- The third `Add` method takes two string parameters and concatenates them.

When you call these methods, the appropriate one is selected based on the argument types. For example:

```csharp
MathOperations math = new MathOperations();

int sum1 = math.Add(2, 3); // Calls the first Add method for integers
double sum2 = math.Add(2.5, 3.7); // Calls the second Add method for doubles
double sum3 = math.Add(2,3,4); // Calls the third Add method for 3 parameters
```

## Assignment - Part 1 - Math Operations
1. Add methods for
	- Subtract
		- Takes 2 ints
		- Takes 2 doubles
		- Takes 3 double
	 - Multiply
		- Takes 2 ints
		- Takes 2 doubles
		- Takes 3 double
	- Divide
		- Takes 2 ints 
		- Takes 2 doubles

For the Divide you must throw an error if the 2nd argument is a 0.
```csharp
  if (b != 0)
  {
	  // Your code
  }
  else
  {
	  throw new DivideByZeroException("Cannot divide by zero.");
  }
```


## Assignment - Part 2 - Employee Database

In this example you will replicate adding names to an Employee database.
1. Create a class called `EmployeeDatabase`.
2. Add the following methods.

```csharp
public class EmployeeDatabase
{
    // Overloaded method to add an employee with just a name
    public void AddEmployee(string name)
    {
        // Add employee to the database with name only
        Console.WriteLine($"Added employee: {name}");
    }

    // Overloaded method to add an employee with name and age
    public void AddEmployee(string name, int age)
    {
        // Add employee to the database with name and age
        Console.WriteLine($"Added employee: {name}, Age: {age}");
    }

    // Overloaded method to add an employee with name, age, and department
    public void AddEmployee(string name, int age, string department)
    {
        // Add employee to the database with name, age, and department
        Console.WriteLine($"Added employee: {name}, Age: {age}, Department: {department}");
    }
}
```

In this example:

- We have an `EmployeeDatabase` class with three overloaded `AddEmployee` methods.
- Each method has a different parameter list (method signature).
- The first method takes only the employee's name, the second method takes the name and age, and the third method takes the name, age, and department.

You can call these methods with different numbers of parameters:

```csharp
EmployeeDatabase database = new EmployeeDatabase();

database.AddEmployee("Your Name"); // Calls the first method with name only
database.AddEmployee("A Friends Name", 30); // Calls the second method with name and age
database.AddEmployee("A Friends Name", 25, "A Position"); // Calls the third method with name, age, and department
```

---
### Assignment - Part 3 - Code to Run

In your main 
1. Create a new instance of `MathOperations()`
2. Create a new instance of `EmployeeDatabase()`

 Call and display the result for 
 1. Add Method
 2. Subtract Method
 3. Multiply Method
 4. Divide method ( make sure to throw in a try catch )
 5. Test ALL of your Employee Database methods


```csharp
  public static void Main(string[] args)
  {
	  MathOperations math = new MathOperations();
	  EmployeeDatabase database = new EmployeeDatabase();

	  // Math operations
	  int sum1 = math.Add(10, 5);
	  Console.WriteLine($"Sum1: {sum1}");

	  double difference = math.Subtract(7.5, 3.2);
	  Console.WriteLine($"Difference: {difference}");

	  double product = math.Multiply(4.0, 2.5, 3.0);
	  Console.WriteLine($"Product: {product}");

	  try
	  {
		  double result = math.Divide(8.0, 2.0);
		  Console.WriteLine($"Division Result: {result}");
	  }
	  catch (DivideByZeroException ex)
	  {
		  Console.WriteLine($"Error: {ex.Message}");
	  }

	  // Employee database
	  database.AddEmployee("John Doe");
	  database.AddEmployee("Jane Smith", 30);
	  database.AddEmployee("Robert Johnson", 25, "HR");
  } // main
```

---

## Rubric

| Criteria | Description | Points |
|----------|-------------|--------|
| **Project Setup** | Proper creation of a new console application named GA_MethodOverloading_YourName. | 20 |
| **Understanding of Method Overloading** | Clear explanation of method overloading in C#. | 15 |
| **Implementation of Method Overloading** | Correct implementation of method overloading in C#. | 15 |
| **Explanation of Method Logic** | Detailed comments explaining the logic of method overloading. | 15 |
| **Implementing Efficient Method Overloads** | Correct implementation and explanation of efficient method overloads. | 15 |
| **Optimizing the Method Overloading Process** | Implementation and explanation of optimization techniques in method overloading. | 10 |
| **Code Testing and Output Accuracy** | Successful testing and demonstration of method overloading. | 5 |
| **Submission** | Successful upload to GitHub with the correct link provided. | 5 |
| **Total** |  | 100 |

This guided assignment provides a comprehensive overview of method overloading in C#, covering its concept, implementation, optimization, and testing.