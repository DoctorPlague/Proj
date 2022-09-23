using Proj;

var simple = new SimpleEncryption();

string word = "123456789";

Console.WriteLine(word.Length);

string res = String.Empty;

int[] number = new int[20];

Console.WriteLine();

for (int i = 0; i < 20; i++)
{
    res = simple.Encrypt(word, number[i] = new Random().Next(10));
    Console.WriteLine(res);
   
    Console.WriteLine(simple.Decrypt(res, number[i]));
    Console.WriteLine();
}
