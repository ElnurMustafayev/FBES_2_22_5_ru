using System;
using System.Threading.Channels;


// Parallel
if(false)
{
    Action[] actions = {
        () => {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"1. {i}");
            }
        },
        () => {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine($"2. {i}");
            }
        },
        () => {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(800);
                Console.WriteLine($"3. {i}");
            }
        }
    };

    ParallelOptions parallelOptions = new ParallelOptions();
    Parallel.Invoke(actions);
}

if(false)
{
    //Parallel.For(0, 1000, (index) => Console.WriteLine(index));
    //Parallel.For(0, 100, (index, state) =>
    //{
    //    Console.WriteLine(index);
    //    state.Break();
    //});


    //int[] nums = { 1, 6, 9, 10, 22, 67, -56 };
    //Parallel.ForEach(nums, (num) => Console.WriteLine(num * num));

    int[] nums = { 1, 6, 9, 10, 22, 67, -56 };

#pragma warning disable CS4014

    Parallel.ForEachAsync(nums, async (num, token) => {
        //await nums.MyFuncAsync();

        await Task.Run(() =>
        {

        });
        //return ValueTask.CompletedTask;
    });
}



// PLINQ
if (true)
{
    //int[] nums = { 1, 6, 9, 10, 22, 67, -56 };

    //var query = nums
    //    .AsQueryable()
    //    .Select((num) => num.ToString());

    //var result = query.ToList();

    //foreach (var item in result)
    //{
    //    Console.WriteLine(item);
    //}

    //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    //var result = nums
    //    .AsParallel()
    //    .Where(num =>
    //    {
    //        Console.WriteLine(num);

    //        return num % 2 == 0;
    //    })
    //    .ToList();
}

void PrintKeywordsAsync(string[]? keywords, params string[] filePaths)
{
    keywords ??= new string[] { "test", "apple" };

    //Parallel.ForEach(filePaths, async (filePath) =>
    //{
    //    var text = await File.ReadAllTextAsync(filePath);

    //    foreach (var keyword in keywords)
    //    {
    //        if(text.Contains(keyword))
    //            Console.WriteLine($"{keyword} found in '{filePath}'");
    //    }
    //});

    //var result = filePaths
    //    .AsParallel()
    //    .Select(async (filePath) =>
    //    {
    //        var text = await File.ReadAllTextAsync(filePath);

    //        var foundKeywords = new List<string>(capacity: keywords.Count());
    //        foreach (var keyword in keywords)
    //        {
    //            if (text.Contains(keyword))
    //            {
    //                Console.WriteLine($"{keyword} found in '{filePath}'");
    //                foundKeywords.Add(keyword);
    //            }
    //        }

    //        return foundKeywords;
    //    })
    //    .ToList();
}