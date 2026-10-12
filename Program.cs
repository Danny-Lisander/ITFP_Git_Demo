int[] numbers = { 1, 2, 3, 4, 5 };

Console.WriteLine(SumEven(numbers));

static int SumEven(IEnumerable<int> numbers)
    => numbers
    .Where(x => x % 2 == 0)
    .Where(x => x > 2)
    .Sum();

