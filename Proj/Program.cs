using Proj;

var simple = new SimpleEncryption();

string word = "12345";

int number = 10;

string res = simple.Encrypt(word,number);

Console.WriteLine(res);

Console.WriteLine();

Console.WriteLine(simple.Decrypt(res, number));

