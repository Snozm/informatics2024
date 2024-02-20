using CurrencyConvert;
Converter conv = new Converter();
while (true)
{
    int mode;
    do
    {
        Console.WriteLine("Choose mode:\n1: BGN to EUR\n2: EUR to BGN\n3: Exit");
        mode = int.Parse(Console.ReadLine());
    } while (mode != 1 && mode != 2 && mode != 3);
    string prompt = "";
    switch (mode)
    {
        case 1:
            prompt = "Enter BGN:";
            break;
        case 2:
            prompt = "Enter EUR:";
            break;
        default:
            break;
    }
    if (prompt == "")
    {
        break;
    }
    Console.WriteLine(prompt);
    double curr;
    bool success;
    do
    {
        success = double.TryParse(Console.ReadLine(), out curr);
    } while (!success);

    switch (mode)
    {
        case 1:
            prompt = $"EUR: {conv.BGNtoEUR(curr)}";
            break;
        case 2:
            prompt = $"BGN: {conv.EURtoBGN(curr)}";
            break;
    }
    Console.WriteLine(prompt);
   
    Console.WriteLine("\nNew Conversion?");
}
