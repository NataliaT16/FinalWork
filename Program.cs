string[] array = FindArray();

string[] FindArray() 
{
    Console.WriteLine("Введите массив строк через пробел: ");
    return Console.ReadLine().Split(" ");
}



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