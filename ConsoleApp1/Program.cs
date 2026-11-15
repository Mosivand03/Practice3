// Mohammad mosivand
// Dar in tamrin meghdar az karbar dariaft mishe
// Va amaliat hesabi roie an ha anjam mishe
// Hadf az in tamrin raaiat algorithm dar hal masaleh hast
// Tamrin aval
Console.Clear();
try
{
    Console.Write("Tedad saat: ");
    
}
catch
{
    
}
try{
    var saat = Convert.ToDouble(Console.ReadLine());
    var dastmozdKhales = saat * 3.5;
    var maliat = (dastmozdKhales * 5) / 100;
    var hoghooghDariafti = dastmozdKhales - maliat;
    Console.WriteLine($"Hoghoogh Khales: {dastmozdKhales}$");
    Console.WriteLine($"Maliat: {maliat}$");
    Console.WriteLine($"Hoghoogh dariafti: {hoghooghDariafti}$");
}
catch (OverflowException)
{
    Console.WriteLine("Adad nadorost vared shodeh ast ");
}
catch (FormatException)
{
    Console.WriteLine("Adadi vared nashodeh ast ");
}
catch
{
    Console.WriteLine("Ba poshtiban tamas begirid ");
}
finally
{
    Console.WriteLine("Mamnon az tavajoh shoma ");
}
Console.WriteLine("Paian ");
//await Task.Delay(15000);
// Tamrin 2
 //Console.Clear();
//Console.WriteLine("Namaiesh akse adad 4 raghami ");
//try
//{
   // Console.Write("Number: ");
   // var number = Convert.ToInt32(Console.ReadLine());
   // var number1 = number % 10;
   // var number2 = ((number - number1) / 10) % 10;
   // var number3 = ((number - ((number2 * 10) + number1)) / 100) % 10;
   // var number4 = (number - ((number3 * 100) + (number2 * 10) + (number1))) / 1000;
   // Console.Write(number1);
   // Console.Write(number2);
   // Console.Write(number3);
   // Console.WriteLine(number4);
//}
//catch (OverflowException)
//{
  //  Console.WriteLine("Adad nadorost vared shodeh ast");
//}
//catch (FormatException)
//{
   // Console.WriteLine("Adadi vared nashodeh ast ");
//}
//catch
//{
   // Console.WriteLine("Ba poshtiban tamas begirid");
//}
//finally
//{
   // Console.WriteLine("Mamnon az tavajoh shoma ");
//}
//Console.WriteLine("Paian ");