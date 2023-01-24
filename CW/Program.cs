
void FindString(string[] strings)
{
    string[] newStr = new string[strings.Length];
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            newStr[j] = strings[i];
            j++;
        }
    }
    System.Console.WriteLine($"{string.Join(" ", strings)} --> {string.Join(" ", newStr)}");
}

System.Console.WriteLine("Введите массив строк через пробел: ");
string[] str = Console.ReadLine().Split(' ');
FindString(str);
