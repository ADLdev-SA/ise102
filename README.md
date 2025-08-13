# ISE102 - Introduction to Software Engineering (TUA)
## Group Assignment Template (A3)

This template is used for Assignment 3. Please check Assignment 3 Task for reference. The requirements include:

**1. Basic coding skills for C# programming language**

**2. Object-oriented programming OOP:**

- Build a base class Client with basic properties, basic methods SetID()
- Build BankAcc that inheritted from the base class, build a constructor
- Build a method in the BankAcc class, override the SetID() method in the base class (can use SetID or TransID in Ultilities or write your own code)
- Create new methods: Withdraw() and Deposit(). The balance change when you use VScrollBar
- Modify lines 32-36 in Program.cs to initialize the array for Clients. (you have more properties)

**3. Build Unit Test for the code of the BankAcc class to test method Withdraw() and Deposit()**
- At least two test cases.
- Mor test cases => more marks.

**4. Attached documents:**
- UML diagram describing the flow of BankApp
- UML diagram describing the Client and BankAcc classes. 
- At least two diagrams. Add more UML diagram => more mark.

**5. Detail comments (for your code).**

**6. Report has screenshots and notes:**
- The video presentation must clearly explain these screenshots.

**7. Create a setup file: Deployment.**
- Use Inno Setup to build a setup file (add all dependencies). Set the name of the app like ISE102-CRN915-Group1. Install it to your computer (Window OS).
- Capture a short video to show your application in "Control Panel/Programs/Programs and Features". Run the app like video demo.

**8. Submit Assignment 3:** 

- Code zip file + report + recorded video (or link).
- Remember to put a reference with this template (add link to Git).

**Task Done**

## Problem with VS 2022

If you download code from GIT and use Visual Studio Community 2022 and encounter error MSB3821 (https://learn.microsoft.com/en-us/visualstudio/msbuild/errors/msb3821?view=vs-2022), fix the issue as follows:

1. Goto menu Tools > Options > Environment > Security. In the Trust Policies, uncheck *Require a trust decision when opening content from the web* then click Ok.
2. Close the Project, then use File Explorer to find the Project Source Code file. Right-click on the *.resx* files (Form1.rexs, Form2.resx, ..., XML-based resource file used to store resources for .NET applications), select Properties. Click check *Unblock* then click Apply.

