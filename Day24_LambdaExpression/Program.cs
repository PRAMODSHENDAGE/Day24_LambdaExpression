// See https://aka.ms/new-console-template for more information

using Day24_LambdaExpression;

UserRegistration patterns = new UserRegistration();
Console.WriteLine(patterns.ValidateFirstName("Suraj"));
Console.WriteLine(patterns.ValidateLastName("kumar"));
Console.WriteLine(patterns.ValidateEmail("Soorajkrpandit@gmail.com"));
Console.WriteLine(patterns.ValidatePhoneNumber("91 6200749278"));
Console.WriteLine(patterns.ValidatePassword("LabBridge@001"));
Console.WriteLine();

Console.WriteLine("To validate the user entry using lambda function");
List<Person> listed = new List<Person>();
Lambda.ValidateUserEntry(listed);

