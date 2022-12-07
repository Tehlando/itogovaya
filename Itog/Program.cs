Console.Clear();
string[] array = {"калыван", "1245", "zimbabwe", "12", "aes"};
Console.WriteLine (String.Join(' ', array));
Console.WriteLine();
string variable = string.Empty;
for ( int i = 0; i < array.Length; i++)
{
if (array[i].Length <4) variable = variable +array[i]+ " ";
}

string[] result = variable.Split(' ');
Console.WriteLine(String.Join(' ',result));