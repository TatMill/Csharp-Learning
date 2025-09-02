Human human = new();
Teacher teacher = new();
human.Walk();
teacher.Walk();


int[] nums = { 10, 52, 44, 22, 78, 56, 23, 11, 99, 23 };
int sum = 0;


for (int i = 0; i < nums.Length; i++)
    sum += nums[i];
float arif = sum / nums.Length;
int temp = 0;

    List<int> biggerThanAverage = new List<int>();
    foreach (int n in nums)
    {
        if (n > arif)
        {
            biggerThanAverage.Add(n);
        }
    }

for (int i = 0; i < biggerThanAverage.Count - 1; i++)
{
    for (int j = i + 1; j < biggerThanAverage.Count; j++)
    {
        if (biggerThanAverage[i] < biggerThanAverage[j])
        {
            temp = biggerThanAverage[i];
            biggerThanAverage[i] = biggerThanAverage[j];
            biggerThanAverage[j] = temp;
        }
    }
}
foreach (int n in biggerThanAverage)
{
    Console.WriteLine(n);
}

Car shevrolet = new();

shevrolet.model = "Niva";
shevrolet.color = "Grey";
shevrolet.price = "4999$";

shevrolet.Info();
class Car
{
    public string model;
    public string color;
    public string price;


    public void Info()
    {
        Console.WriteLine($"Модель{model} \tЦвет {color} \tЦена{price} ");
    }
}



