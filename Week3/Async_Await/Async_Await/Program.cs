using System.Diagnostics;

namespace Async_Await;

class Program
{
    static async Task Main(string[] args)
    {
        Stopwatch sw = new();
        sw.Start();

        Task<int> t1 = NthPrimeAsync(1000000);
        Task<int> t2 = NthPrimeAsync(1000001);
        Task<int> t3 = NthPrimeAsync(1000002);

        await Task.WhenAll(t1, t2, t3);
        
        Console.WriteLine(await t1);
        Console.WriteLine(await t2);
        Console.WriteLine(await t3);

        sw.Stop();
        Console.WriteLine(sw.Elapsed);
    }

    public static async Task<int> NthPrimeAsync(int n)
    {
        return await Task.Run(() => NthPrime(n));
    }

    public static int NthPrime(int n)
    {
        int count = 0;
        int pCandidate = 1;

        while(count < n)
        {
            pCandidate ++;
            if(IsPrime(pCandidate)) count ++;
        }
        return pCandidate;
    }

    public static bool IsPrime(long n)
    {
        if(n < 2) return false;

        //A integer n is prime if it is only divisible by 1 and itself
        for(int i = 2; i <= Math.Sqrt(n); i++)
        {
            if(n % i == 0) return false;
        }
        return true;
    }
}


