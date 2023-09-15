//###################
//Variables
//###################
//Console.WriteLine(name); //will not compile, because  is not yet declared and initialized

using System.Windows.Markup;

string name = "Nisha"; //variable initialization at declaration
int number; //variable declaration
number = 5; //variable initialization
number = 10; //assigning new value to a variable
Console.WriteLine(number); //10 will be printed
//int lastName = "Smith"; //will not compile, we can't assign string to int

//###################
//Naming variables
//###################
//string class = "First"; //will not compile, class is reserved keyword
string @class = "First"; //we can use a reserved keyword if we precede it with @
int _number = 10;
int also_some_number = 5; //valid name, but not in line with C# convention
int alsoSomeNumber = 5; //C# uses lower camel case
//int 1number = 1; //will not compile, digit cannot be the first character
string name1 = "Anna"; //digit is fine if it is not the first character
int age, Age; //they are two different variables, C# is case-sensitive 
//int number-one = 10; //will not compile, we can't use '-'

//###################
//Operators
//###################
int sum = 5 + 10;
int resultNoParenthesis = 5 + 2 * 3;
int resultParenthesis = 5 + (2 * 3);
var stringAndInt = "abc" + 5;



//###################
//Implicitly typed variables
//###################
string word1 = "text"; //explicitly typed variable
var word2 = "text"; //implicitly typed variable
//var invalidVariable; //will not compile; implicitly typed variables must be initialized



//###################
//Comments
//###################

//this is a single-line comment
/*
this is
a multiline
comment
*/

//###################
//Boolean type.
//Logical negation, equality,
//comparison and modulo operators
//###################
Console.WriteLine("Enter a word:");
var userInput = Console.ReadLine();
bool isUserInputAbc = userInput == "ABC";
bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC"); //will be the same as above
var isLargerThan5 = number > 5;
var isSmallerThan10 = number <= 10;
var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;
var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = number % 2 == 0;
var isOdd = number % 2 != 0;



//###################
//Boolean type.
//Logical negation, equality,
//comparison and modulo operators
//###################
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 =
    number == 2 || number > 6 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 =
    number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 5; //the second conditin will not be evaluated due to short-circuiting
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0; //the second conditin will not be evaluated due to short-circuiting