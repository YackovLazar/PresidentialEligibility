// Yackov Lazar
// T00432543
Console.WriteLine("Lets find out if you are eligible to be a president of the United States of America.");
var naturalBornCitizen = "";
var ageStr = "empty";
var age = 1;
var yearsOfResidencyStr = "empty";
var yearsOfResidency = 0;
var yearsOfPresidencyStr = "empty";
var yearsOfPresidency = 0;

while (naturalBornCitizen?.ToLower() is not "yes" and not "no")
{
    Console.WriteLine("Are you a natural born citizen of the USA? (yes/no)");
    naturalBornCitizen = Console.ReadLine();
}

if (naturalBornCitizen.ToLower() is "no")
{
    Console.WriteLine("You are not eligible to be a president of the United States of America.");
    return;
}

while (!(int.TryParse(ageStr, out age)) || age <= 0)
{
    Console.WriteLine("Please enter your age: ");
    ageStr = Console.ReadLine();
}

if (age < 35)
{
    Console.WriteLine("You are not eligible to be a president of the United States of America.");
    return;
}

while (!int.TryParse(yearsOfResidencyStr, out yearsOfResidency) || yearsOfResidency <= 0 || yearsOfResidency > age)
{
    Console.WriteLine("Please enter the number of years you have been a resident of the USA: ");
    yearsOfResidencyStr = Console.ReadLine();
}

if (yearsOfResidency < 14)
{
    Console.WriteLine("You are not eligible to be a president of the United States of America.");
    return;
}

while (!int.TryParse(yearsOfPresidencyStr, out yearsOfPresidency) || yearsOfPresidency <= 0 || yearsOfPresidency > age - 35 || yearsOfPresidency > yearsOfResidency)
{
    Console.WriteLine("Please enter the number of years you have been a president of the USA: ");
    yearsOfPresidencyStr = Console.ReadLine();
}

if (yearsOfPresidency >= 6) // 2 year in case of takeover as VP and 4 years as president
{
    Console.WriteLine("You are not eligible to be a president of the United States of America.");
    return;
}

Console.WriteLine("You are eligible to be a president of the United States of America.");
