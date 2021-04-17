# Class 10 - Recap Part 2 📒

○ What is static class?
○ From how many classes can we inherit from in C#?
○ What is class-based inheritance?
○ What are virtual and ovrride keywords used for?
○ How can we call the constructor of the parent class?
○ What can classes inherit from?
○ Why is inheritance important in OOP?
○ What are enumerations (enums) and when should we use them? 
○ What is a class library project?
○ What kind of different collection types we have in C# and what is the diference between them?
○ What methods are specific for each of this colletions?
○ What is LINQ and how can we use it?
○ What LINQ methods do you know? 
○ What is the difference between build time errors and runtime errors?
○ How do we handle runtime errors?
○ What are exceptions?
○ How can we create and throw custom exception?

## Task 1
### Create an ATM application
Create an ATM application. A customer should be able to authenticate with card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:
1) Balance checking - This should print out the current balance of money on their account
2) Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal  
3) Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.

In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.

**Example**

Welcome to the ATM app

Please enter your card numer:

**\>** 1234-1234-1234-1234

Enter Pin:

**\>** 4325

Welcome Bob Bobsky!

What would you like to do:

1) Check Balance
2) Cash Withdrawal
3) Cash Deposit

**\>** 2

You withdrew 250\$. You have 400\$ left on your account.

Thank you for using the ATM app.
 
**Bonus:** The balance and pin should not be public

**Bonus:** The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.

**Bonus:** When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action. If not it should print a goodbye message and show up the login menu again.

**Bonus:** Add an option to register a new card in the system that store the customer in the system if the card number is not used for any other customer

## Task 2
### Create an Academy Management app
The app will have users that can login and perform some actions.
The user can choose one of the 3 roles and login:
* Admin
* Trainer
* Student ( has a current Subject, and Grades )

After logging in there should be different options for different roles:
* Admins can add/remove Teachers , Students and other Admins ( can't remove it self )
* Trainer can choose between seeing all students and all subjects
	*	When choosing Students, all student names should appear
	*	When chosen a name, it should print all the subjects
	*  When choosing Subjects, all Subject names appear with how many students attend it next to it
* Student are shown the name of the subject that they are listening and a list of their grades

Try and handle all scenarios with exception handling. Handle expected exceptions with special messages.  