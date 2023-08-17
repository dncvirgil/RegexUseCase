# Application Description
The C#/.NET 6 application provides a utility to validate strings based on specific criteria. It contains a RegexHelper class that offers a ValidateString method to ensure that a given input conforms to the defined set of rules related to length, character types, and whitespace.

# Regex Implementation Description
The ValidateString function in the RegexHelper class uses regular expressions to perform its validation. It checks if the string's length is within the specified maximum limit. Furthermore, the function ensures that the string includes at least one uppercase letter, one lowercase letter, one digit, and one special character from a predefined list (!"#$%&'()*+,-./:;<=>?@[\]^_{|}~`). Additionally, the regex confirms that the string does not contain any whitespace characters, including spaces, tabs, or newlines. Any deviations from these criteria will result in the function returning a non-match.

# Running the Application Locally
Ensure you have .NET 6 SDK installed on your machine. You can download and install it from the official Microsoft website.
* Clone the repository to your local machine.
bash: git clone [repository_url]
* Navigate to the directory containing the solution (.sln) file.
bash: cd path_to_solution_directory
* Restore the necessary packages.
bash: dotnet restore
* Build the application.
bash: dotnet build
* To run the test library and validate the functionality, navigate to the test library directory and execute the following command:
bash: dotnet test

By following the above steps, you should be able to run the application and its tests on your local machine.