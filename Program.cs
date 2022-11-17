string[] array = FindArray();

string[] FindArray() 
{
    Console.WriteLine("Введите массив строк через пробел: ");
    return Console.ReadLine().Split(" ");
}
