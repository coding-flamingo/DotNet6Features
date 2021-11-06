// See https://aka.ms/new-console-template for more information

using DotNet6Features.Models;

Console.WriteLine("Hello, World!");
//MAUI https://www.youtube.com/watch?v=Uicylw5QdV4
//Hot Reload (mid video https://www.youtube.com/watch?v=wHTJXUtGHtI)
//Faster 
//Blazor AOT

//Date Only / Time only
DateTime dateTime = DateTime.Now;
DateOnly? dateOnly = DateOnly.FromDateTime(dateTime);
TimeOnly timeOnly = TimeOnly.FromDateTime(dateTime);
Console.WriteLine(dateOnly);
Console.WriteLine(timeOnly);

//argument null checks
if (dateOnly == null)
{
    throw new ArgumentNullException("");
}
ArgumentNullException.ThrowIfNull(dateOnly);

var hayStack = new List<int?> { 1, 2, 2 };
var needle = 3;


//select default value
var foundValue = hayStack.FirstOrDefault(x => x == needle);
if (foundValue == null)
{
    Console.WriteLine("We couldn't find the value");
}

foundValue = hayStack.FirstOrDefault(x => x == needle, -1);
if (foundValue == -1)
{
    Console.WriteLine("We couldn't find the value");
}


//max by min by
List<RandomClass> sampleList = new()
{
    new ()
    {
        Id = 68,
        NumberOfCows = 20
    },
    new ()
    {
        Id = 5,
        NumberOfCows = 30
    },
    new()
    {
        Id = 4,
        NumberOfCows = 54
    },
    new()
    {
        Id = 6,
        NumberOfCows = 23
    }
};

var maxCowsObject = sampleList.OrderByDescending(x => x.NumberOfCows).First();
maxCowsObject = sampleList.MaxBy(x => x.NumberOfCows);
var minCowsObject = sampleList.MinBy(x => x.NumberOfCows);

//chunk by

var chunks = sampleList.Chunk(2);

Console.WriteLine("Thanks for watching");