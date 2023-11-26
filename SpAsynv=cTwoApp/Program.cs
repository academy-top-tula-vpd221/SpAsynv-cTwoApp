List<Task<int>> tasks = new();

for (int i = 30; i >= 20; i-=2)
    tasks.Add(AmountN(i));

int[] results = await Task.WhenAll(tasks.ToArray());
foreach (int result in results)
    Console.WriteLine(result);

async Task<int> AmountN(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Thread {n} {i}");
        await Task.Delay(1);
        result += i;
    }
    return result;
}

/*
var t1 = AmountN(20);
var t2 = AmountN(50);

Console.WriteLine($"s1 = {t2.Result}");
Console.WriteLine($"s2 = {t1.Result}");

async ValueTask<int> AmountN(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine(i);
        await Task.Delay(100);
        result += i;
    }
        
    return result;
}
*/

/* // Event Handler - void async

BankAccount acc1 = new();
acc1.BankAccountChanged += AccountPrintAsync;

acc1.Put(1000);

await Task.Delay(2000);


async void AccountPrintAsync(object? sender, string text)
{
    await Task.Delay(1000);
    Console.WriteLine(text);
}

class BankAccount
{
    int amount;
    public void Put(int amount)
    {
        this.amount += amount;
        BankAccountChanged?.Invoke(this, $"To account added {amount} rub");

    }

    public event EventHandler<string> BankAccountChanged;
}
*/

// Bad code - NO VOID!!!
//PrintAsync("Hello world");
//PrintAsync("Hello people");

//Console.WriteLine("Main end");
//await Task.Delay(3000);


//async void PrintAsync(string text)
//{
//    await Task.Delay(1000);
//    Console.WriteLine(text);
//}