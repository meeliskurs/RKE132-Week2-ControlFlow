// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/s)
//rakendus küsb kasutajal sisestada tema perekonnanime
//lähtudes tema valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome Ms. [kasutaja perekonnanimi]

using System;

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string formaadis
Console.WriteLine("Please enter your name:");

string userLastName = Console.ReadLine();
if(userGender == 'm') 
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");

} 
 else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}





