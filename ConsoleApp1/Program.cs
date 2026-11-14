// Mohammad mosivand
// Dar in tamrin meghdar az karbar dariaft mishe
// Va amaliat hesabi roie an ha anjam mishe
// Hadf az in tamrin raaiat algorithm dar hal masaleh hast
// Tamrin aval
Console.Clear();
Console.Write("Tedad saat: ");
var saat=Convert.ToDouble(Console.ReadLine());
var dastmozdKhales=saat*3.5;
var maliat=(dastmozdKhales*5)/100;
var hoghooghDariafti=dastmozdKhales-maliat;
Console.WriteLine($"Hoghoogh Khales: {dastmozdKhales}$");
Console.WriteLine($"Maliat: {maliat}%"); 
Console.WriteLine($"Hoghoogh dariafti: {hoghooghDariafti}$");