Module Modulo1
	Sub Main()
		Console.WriteLine("The Name Game")

		Console.Write("What's your first name? ")
		Dim firstName As String = Console.ReadLine()
		
		Console.Write("What's your last name ? ")
		Dim lastName As String = Console.ReadLine()
		
		Console.Write("What's your city? ")
		Dim city As String = Console.ReadLine()

		dim firstNameArray As char() = firstName.ToCharArray()
		Array.Reverse(firstNameArray)

		Dim lastNameArray As char() = lastName.TocharArray()
		Array.Reverse(lastNameArray)

		Dim cityArray As char() = city.ToCharArray()
		Array.Reverse(cityArray)

		Dim result As String = ""

		For Each item As String in firstNameArray
			result &= item
		Next

		result &= " "


		For Each item As String in lastNameArray
			result &= item
		Next

		result += " "
		For Each item As String in cityArray
			result &= item
		Next

	
		'DisplayResult(fistName, lastName, city)	

		Console.WriteLine("Resutls: " + result)
		Console.ReadLine()
	End Sub

	
	Sub DisplayResult(message As String)
		Console.Write("Results: ")
		Console.Write(message)
	End Sub

	' Overloaded Method
	Sub DisplayResult(reversedFirstName as String, 
			  reversedLastName As String,
			  reversedCity as String)
		Console.Write("Results: ")
		Console.Write("{0} {1} {2}",
		reversedFirstName, 
		reversedLastName,  		
		reversedCity) 
	End Sub

	Function GetReverseString(ByVal message As String) As String
		Dim

	
	Sub ReverseString(ByRef message As String) As String
End Module     
