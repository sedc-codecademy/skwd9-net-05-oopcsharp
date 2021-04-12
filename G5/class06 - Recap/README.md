# Class 6 - Recap 📒

* What is C#?
* What is the .NET framework?
* Difference between C# and .NET framework?
* Why is it Strict-typed?
* What are Data types in C# and how they are different from javascript?
* What is data parisng ?
* What is the difference between .parse and .TryParse?
* What is branching ?
* What is the difference between while and do while loop?
* What are continue and break used for?
* How can we escape special character in C# strings?
* What are arrays in c# and how they differentiate from javascript arrays?
* What are Methods in C#?
* What kind of methods can we have in C# and how they differentiate from javascript methods?
* What is object-oriented programing and why it is important?
* What are classes?
* How do classes work and why they are important for OOP?
* Difference between Classes and Objects?
* What is constructor in a Class?
* What are access modifiers? 

## Task 1
Create a method called NumberStats that accepts a number. This method should:
* Find out if the number is negative or positive
* Find out if the number is odd or even
* Find out if the number is decimal or integer
* After finding all the stats it should print them like this:

**Stats for number: 25**

**Positive**

**Integer**

**Odd**

The number should be entered in the console by the user.

**Bonus**: Validate if the user is entering a number

**Bonus**: Ask the user to press Y to try again or X to exit

## Task 2
Create a class User with the following:
* Id - int
* Username - string
* Password - string
* Messages - Array of strings
Create an array of users and add 3 users to it manually ( hard-coded ).

Create a Console UI that will ask the user:

1) Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
**Welcome NAME. Here are your messages:**

**Message1**

**Message2**

If not found, it should print an error message

2) Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
**Registration complete! Users:**

**23 Username1**

**44 Username2**

**1 Username3**

**56 Username4**

## Task 3
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