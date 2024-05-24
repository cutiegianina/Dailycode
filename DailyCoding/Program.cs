#region 1
using System.Globalization;

string num = Console.ReadLine();
Console.WriteLine(num);
if (Convert.ToInt32(num) < 0 || Convert.ToInt32(num) > 1000)
{
    throw new Exception("Invalid input!");
}
#endregion


string date = Console.ReadLine();

try
{
    DateTime convertedDate = DateTime.ParseExact(date, "d/M/yyyy", CultureInfo.InvariantCulture);
    Console.WriteLine(convertedDate.ToString("dd-MM-yyyy"));
}
catch (Exception ex)
{
    Console.WriteLine("Invalid daste format");
}

string num1 = Console.ReadLine();
int _num = Convert.ToInt32(num1);
static double square(int num) =>
        Math.Sqrt(num);
int input = Convert.ToInt32(Console.ReadLine());
double squared = square(input);

Console.Write(squared);

static double getAverage(int[] nums) =>
    nums.Average();

int[] averageToInput = [8, 2, 2, 1];
try
{
    double average = getAverage(averageToInput);
    Console.WriteLine(average);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}

static string ToUpperCase(string text) => text.ToUpper();

Console.WriteLine(ToUpperCase("lowercase"));


List<int> nums = [8, 2, 1, 0];
try
{
    for (int i = 0; i < nums.Count; i++)
    {
        Console.WriteLine(nums[i]);
    }
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}

static int ToInt(string input) => Convert.ToInt32(input);