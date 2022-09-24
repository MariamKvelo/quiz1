// N2

/*string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

bool isDouble1 = double.TryParse(num1, out double result1);
bool isDouble2 = double.TryParse(num2, out double result2);

double sum = result1 + result2;
double sub = result1 - result2;
double mult = result1 * result2;

Console.WriteLine($"{sum} {sub} {mult}");*/



// N3

/*string x = Console.ReadLine();
string y = Console.ReadLine();

bool isInt1 = int.TryParse(x, out int result1);
bool isInt2 = int.TryParse(y, out int result2);

int s = result1 * result2;
int p = (result1 + result2) * 2;

Console.WriteLine($"{s} {p}");*/


// N3

string num1 = Console.ReadLine();
string num2 = Console.ReadLine();
string num3 = Console.ReadLine();

bool isDouble1 = double.TryParse(num1, out double result1);
bool isDouble2 = double.TryParse(num2, out double result2);
bool isDouble3 = double.TryParse(num3, out double result3);

if (result1 >= result2 && result2 > result3)
{

    Console.WriteLine($"{result1} {result2} {result3}");
}

if (result2 >= result1 && result1 > result3)
{

    Console.WriteLine($"{result2} {result1} {result3}");
}

if (result3 >= result1 && result1 > result2)
{

    Console.WriteLine($"{result3} {result1} {result2}");
}

if (result3 >= result2 && result2 > result1)
{

    Console.WriteLine($"{result3} {result2} {result1}");
}