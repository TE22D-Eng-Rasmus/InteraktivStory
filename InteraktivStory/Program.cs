using System.Globalization;

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Du känner dig lite trött och tänker att en liten promenad kan väcka dig lite");
Console.WriteLine("Efter en stund kommer du till än väg som delas i två. Till höger ser du massor av enhörningar och regnbågar.\nTill vänster ser du en elak häxa och masviss av onda ting. Vart väljer du att gå?");
string väg = Console.ReadLine();

if (väg.ToUpper() == "VÄNSTER"){
Console.WriteLine("Du fortsätter att gå mot häxan.\nHäxan verkar vara väldigt trevlig och bjuder in dig på fika. Vill du komma in på fika? Ja/Nej");
string fika = Console.ReadLine();
if (fika.ToUpper() == "JA"){
    Console.WriteLine("Häxan blev väldigt glad och bjöd på dem bästa bullarna du någonsin smakat. \nDu överlevde!");
    Console.ReadLine();
}
if (fika.ToUpper() == "NEJ"){
    Console.WriteLine("Häxan blev arg och käka upp dig! \nGAME OVER");
    Console.ReadLine();
}
}