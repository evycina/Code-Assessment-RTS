RTS Code Assessment 
Applicant: Eveli Bayne
Language used: C#

Includes unit tests developed using MSTest. Development was performed using Visual Studio 2019, but only source files have 
been included for review. 

To my reviewers: Thank you so much for taking the time to review my assessment and consider me for this opportunity!!!

=============================================== Thank you! ===============================================

Prompt: 

Write a class in the language of your choice that contains the following two public methods:

aboveBelow
	Parameters:
		An unsorted collection of integers (the list)
		an integer (the comparison value)
	Returns:
		Key/Value Pair Collection containing 
			Keys:
				"Above"
				"Below"
			Values
				Int equal to number of integers from list that are above or below comparison vaue, respectively

	Example:
		input: [1, 5, 2, 1, 10], 6
		output: { "above": 1, "below": 4 }

stringRotation
	Parameters:
		A string (original string)
		A positive integer (rotation amount)

	Returns:
		String representing original string shifted right by rotation amount, wrapping overflow to start. 

	Example:
		input: "MyString", 2
		output: "ngMyStri"

