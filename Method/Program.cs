


//static void Number(int n)
//{

//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("the number is divided");

//    }
//    else
//    {
//        Console.WriteLine("the number is not divisible");
//    }

//}

//int t = 26;

//Number(t);






//static void GetSum(int n, int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;

//    }
//    Console.WriteLine(sum);
//}


//int a = 10;
//int b = 14;

//GetSum(a, b);






//static void NumberOfOddNumbers(int n, int m)
//{
//    int count = 0;

//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)

//            count++;

//    }

//    Console.WriteLine(count);

//}
//int n = 4;
//int m = 16;

//NumberOfOddNumbers(n, m);






//static void SumOfOddNumbers(int n, int m)
//{
//    int sum = 0;

//    for (int i = n; i <= m; i++)
//    {
//        if (i % 2 == 1)

//            sum += i;

//    }

//    Console.WriteLine(sum);

//}
//int a = 4;
//int b = 12;

//SumOfOddNumbers(a, b);







//static void SumOddNumbers(int[] nums)
//{
//    int sumElem = 0;

//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] % 2 == 1)
//        {
//            sumElem += nums[i];
//        }
//    }

//    Console.WriteLine(sumElem);

//}

//int[] nums = { 3, 6, 7, 9, 0, 11 };

//SumOddNumbers(nums);







//static void NumberOfEvenNumbers(int[] nums)
//{
//    int count = 0;

//    foreach (var item in nums)
//    {
//        if (item % 2 == 1)
//        {
//            count++;

//        }

//    }

//    Console.WriteLine(count);

//}

//int[] nums = { 2, 4, 5, 7, 9, 15, 17, 19 };

//NumberOfEvenNumbers(nums);





//static void GetNumbers(int num)
//{

//    int count = 0;

//    for (int i = 1; i < num; i++)

//        if (num % i == 0)
//        {
//            count++;
//        }

//    if (count == 2)

//    {
//        Console.WriteLine("complex");
//    }
//    else
//    {
//        Console.WriteLine("simple");
//    }


//}


//int r = 9;


//GetNumbers(r);






//static bool IsPowerOfTwo(int n)
//{
//    if (n == 0)
//        return false;

//    while (n != 1)
//    {
//        if (n % 2 != 0)
//            return false;

//        n = n / 2;
//    }
//    return true;
//}



//int k = 15;

//Console.WriteLine(IsPowerOfTwo(k));





//static void Number(int[] nums)
//{

//    int multiply = 1;

//    foreach (var item in nums)

//    {
//        if (item >= 1 && item <= 20)
//        {
//            multiply *= item;
//        }

//    }

//    Console.WriteLine(multiply);
//}


//int[] nums = { 1, 45, 67, 3, 4, 23 };

//Number(nums);





//static void GetSum(int[] nums)
//{

//    int sumOfEven = 0;

//    int result = 0;


//    foreach (int item in nums)
//    {
//        if (item % 2 == 0)
//        {
//            sumOfEven += item;

//            result = sumOfEven * sumOfEven;
//        }
//    }

//    Console.WriteLine(result);
//}


//int[] nums = { 1, 2, 4, 7, 8, 11 };

//GetSum(nums);
