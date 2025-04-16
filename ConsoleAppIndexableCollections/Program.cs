//from here
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections#indexable-collections

//create a list
List<string> salmons = [ "chinook", "coho", "pink", "sockeye" ];

//add a new element
salmons.Add( "new" );

//iterate using the index
for ( var index = 0; index < salmons.Count; index++)
  {
  Console.WriteLine( salmons[ index ] + " " );
  }

/* 
 * Output:
 * chinook
 * coho
 * pink
 * sockeye
 * new
 */