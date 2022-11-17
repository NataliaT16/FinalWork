string[] array = FindArray();

string[] FindArray() 
{
    Console.WriteLine("Введите массив строк через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] ChooseLess(string[] input, int n)
{
    string[] output = new string[CountLess(input, n)];

    for(int i = 0, j = 0; i < input.Length; i++)
{
        if(input[i].Length <= n)
{
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

string[] result = ChooseLess(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");


int CountLess(string[] input, int n)
{
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }

    return count;
}