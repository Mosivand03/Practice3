// Mohammad mosivand
// Dar in tamrin meghdar az karbar dariaft mishe
// Va amaliat hesabi roie an ha anjam mishe
// Hadf az in tamrin raaiat algorithm dar hal masaleh hast
// Tamrin aval
Console.Clear();
try
{
Console.Write("Tedad saat: ");
var saat=Convert.ToDouble(Console.ReadLine());
var dastmozdKhales=saat*3.5;
var maliat=(dastmozdKhales*5)/100;
var hoghooghDariafti=dastmozdKhales-maliat;
Console.WriteLine($"Hoghoogh Khales: {dastmozdKhales}$");
Console.WriteLine($"Maliat: {maliat}%"); 
Console.WriteLine($"Hoghoogh dariafti: {hoghooghDariafti}$");
}
catch(OverflowException)
{
    Console.WriteLine("Adad nadorost vared shodeh ast");
}
catch(FormatException)
{
    Console.WriteLine("Adadi vared nashodeh ast ");
}
catch
{
    Console.WriteLine("Ba poshtiban tamas begirid");
}
finally
{
    Console.WriteLine("Paian");
}
Console.WriteLine("Mamnon az tavgoh shoma");