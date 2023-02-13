// See https://aka.ms/new-console-template for more information

//The first line of code every programmer types :)
using ConsoleApp1;

Console.WriteLine("Hello World");
Console.WriteLine(); //Just to leave a blank line


//Learning variables :)
string name = "John";
int age; //Declaring variable
age = 70; //Giving value to variable
Console.WriteLine("There was once a man named " + name + ".\nHe was " + age + " years old");
Console.WriteLine("He really liked the name " + name + ".\nBut didn't like being " + age);


#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value
//Getting to know data Types :)
string sentence = "This is a complete sentence"; //String allow us to store sentences or words
char alphabet = 'A'; //Character or char datatype allows us to store single alphabets
int num = 6; //Integer or int allows us to store numbers
double pointvalue = 3.4; //Double allows us to store decimals
bool istrueorfalse = true; //Boolean or bool allows us to either store true or false values
#pragma warning restore IDE0059 // Unnecessary assignment of a value
#pragma warning restore CS0219 // Variable is assigned but its value is never used


//Working with Strings
Console.WriteLine("Working\nWith\nStrings"); //The '\n' command is used to move to a new line
string phrase = "A simple string"; //Storing a string in a variable
Console.WriteLine(phrase); //Printing the string stored in the variable
Console.WriteLine("This is " + "concatenating " + "a string"); //This is an example of concatenating strings
Console.WriteLine(phrase.Length); //Using length method in string
Console.WriteLine(phrase.ToUpper()); //Using methods in string to convert into uppercase
Console.WriteLine(phrase.ToLower()); //Using methods in string to convert into lowercase
Console.WriteLine(phrase.Contains("string")); //Using methos in string to check if the string contains the word
Console.WriteLine(phrase[9]); //Accessing letters in a string using methods
Console.WriteLine(phrase.IndexOf("simple")); //Tells the position of a given word or character in a string
Console.WriteLine(phrase.Substring(8)); //Allows you to access and character from the specified index


//Working with numbers
Console.WriteLine(5); //Normally pinting numbers
Console.WriteLine(2 + 5); //Perform normal arithmatic operations by using the specified signs for each operation
Console.WriteLine( 4 + 7 * (1 * 5)); //Specifing order of operations by using brackets
int number = 10; //Storing numbers in a variable
number++; //Incrimenting number in a variable by one digit
number--; //Decrimenting number in a variable by one digit
Console.WriteLine(number); //Printing the variable
Console.WriteLine(Math.Sqrt(2500)); //Finding squareroot using methods


//Getting user input
Console.WriteLine("Enter Your Name"); //Asking the user to give input
var username = Console.ReadLine(); //Storing the input in a variable
Console.WriteLine("Hello " + username + " !"); //Giving Output to the user 
Console.WriteLine("Enter Two Numbers For Addition"); //Asking the user to give input
int userinputnum1 = Convert.ToInt32(Console.ReadLine()); //Converting strings to numbers
int userinputnum2 = Convert.ToInt32(Console.ReadLine()); ////Converting strings to numbers
int total = userinputnum1 + userinputnum2; //Adding both values
Console.WriteLine("The Sum Is " + total); //Giving output


//Arrays
int[] arrayofnum = { 4, 8, 45, 723, 1549, 76428 }; //Creating an array of integers
Console.WriteLine(arrayofnum[4]); //Accessing elements in an array
arrayofnum[3] = 657; //Updating an element in an array
string[] arrayofname = new string [10]; //Creating an array without declaring any value
arrayofname[0] = "Naruto"; //Declaring value to elements of an undeclared array
arrayofname[1] = "Sasuke"; //Declaring value to elements of an undeclared array


//Methods
static void SayHi(string methodname, int methodage ) //Creating a method and getting argument values
{
    Console.WriteLine("Hello " + methodname + " !");
}
SayHi("Aashrith", 13); //Calling method in the main method


//Return statements
static int CubeANumber (int cubenum) //Creating a method
{
    int result = cubenum * cubenum * cubenum; //Performing a calculation
    return result; //Returning the result of a calculation
}
int cuberoot = CubeANumber(5); //Creating a variable as a question
Console.WriteLine(cuberoot); //Printing the returned value


//If statements
bool islearning = true; //Creating a conditional variable

if(islearning == true) //Creating an ifelse statement
{
    Console.WriteLine("Your are learning C#");
}
else
{
    Console.WriteLine("You are not learning C#");
}


//Switch statements
static string GetDay(int daynum) //Creating a method
{
    string dayname; //Creating a variable for return statement
    switch (daynum) //Creating switch statement and checking for each case
    {
        case 0:
            dayname = "Sunday";
            break;
        case 1:
            dayname = "Monday";
            break;
        case 2:
            dayname = "Tuesday";
            break;
        case 3:
            dayname = "Wednesday";
            break;
        case 4:
            dayname = "Thursday";
            break;
        case 5:
            dayname = "Friday";
            break;
        case 6:
            dayname = "Saturday";
            break;
        default:
            dayname = "Invalid Day Number";
            break;
    }
    return dayname; //Creating a return statement
}
Console.WriteLine(GetDay(3)); //Printing the result from the switch statement


//While loops
int index = 1; //Creating a variable
while (index <= 5) //Creating a while loop
{
    Console.WriteLine(index);
    index++;
}

do //Do while loops
{
    Console.WriteLine(index);
    index++;
}
while (index <= 5);


//For loop
for (int i = 1; i <= 10; i++) //Creating a for loop and it is same as while loop but more compact
{
    Console.WriteLine(i);
}


//2d Array
int[,] twodarray =  //Creating a 2d array and 2d arrays allow us to store 2 or more value inside an element
{
    {1, 2 },
    {4, 5 },
    {7, 8 }
};
Console.WriteLine(twodarray[2, 1]); //Printint the accessed element


//Comments
// These double slash is used for single line comment
/*
 * This is a multi-line comment
 */


//Exception Handling
try //This is a piece of code that stops the program if it crashes
{
    Console.WriteLine("Enter a number :");
    int exceptionnum1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter another number :");
    int exceptionnum2 = Convert.ToInt32(Console.ReadLine());
}
catch (DivideByZeroException e) //This piece of code will display the error without terminating the program
{
    Console.WriteLine(e.Message); //Displaying the error
}
catch (FormatException e) //This piece of code will display the error without terminating the program
{
    Console.WriteLine(e.Message); //Displaying the error
}


//Classes and Objects
//A class named book is created as a new file which will be linked with this program
/* It is an example of how a constructor can be created
Book book1 = new Book("Aryan");              //This is a object and multiple objects can be created
book1.title = "Treasure Island";             //Giving information to the object
book1.author = "Robert Louis Stevenson";     //Giving information to the object
book1.pages = 77;                            //Giving information to the object
*/


//Constructor in Classes
Book book2 = new Book("Wings of Fire", "Dr. A.P.J Abdul Kalam", 214); //This is a object in a simple
                                                                      //single line by using constructors
Console.WriteLine(book2.title, book2.pages); //Printing the information stored in the book variable


//Object Methods
Student stu1 = new Student("Jim", "Business", 2.8); //Creating objects
Student stu2 = new Student("Pam", "Art", 3.7); //Creating objects
Console.WriteLine(stu1.HasHonors()); //Calling a method for an object
Console.WriteLine(stu2.HasHonors()); //Calling a method for an object


//Getters and Setters
Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
Movie shrek = new Movie("Shrek", "Adam Adamson", "Doll");


//Static Class Attributes
Songs holiday = new Songs("Kashmir", "Led Zeppelin", 150);
Console.WriteLine(Songs.songcount); //Printing the value in the static variable
Songs kashmir = new Songs("Holiday", "Green Day", 200);
Console.WriteLine(Songs.songcount); //Printing the value in the static variable


//Static Methods and Classes
Usefultools.SayHi("Aashrith");


//Inheritance
Chef chef = new Chef();
chef.MakeChicken();

Italian_chef italianchef = new Italian_chef();
italianchef.MakePasta();



Console.ReadLine(); //Just to keep the console window open