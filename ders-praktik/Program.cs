/// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 4)
//    {
//        Console.WriteLine("Found -" + arr[i]);
//        break;
//    }
//}

//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 6)
//    {
//        count++;
//        if (count == 6)
//        {
//            break;
//        }
//        Console.WriteLine("Found min 6 time" + arr[i]);

//    }
//}




//int n = 4;
//int count  = 0;

//if (n < 2)
//{
//    Console.WriteLine("Ne sade ,ne murekkeb");
//}
//else
//{
//    for (int i = 1; i <= n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//            if (count == 3)
//            {
//                break;
//            }
//        }
//    }
//    if (count == 2)
//    {
//        Console.WriteLine("sade");
//    }
//    else
//    {
//        Console.WriteLine("Murekkeb");
//    }
//}


//stack yaddasda yerlesdiyi ucun deyismir a-nin deyeri

//int a = 5;
//int b =a;

//b = 50;

//Console.WriteLine(a);
//Console.WriteLine(b);   



//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = arr1;

//arr2[0] = 100;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);



//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 300;
//int[] arr2 = arr1;

//arr2[0] = 500;

//arr2[0] = arr1[0] + arr2[0];


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//var lastname = "test";
//lastname = "salam";



//int[] arr = { 1, 2, 3, 4, 5, 6 };

//for  (int i = 0;i<arr.Length;i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }       
//    if (arr[i] == 5)
//    {
//        break;
//    }
//    Console.WriteLine(arr[i]);
//}

//a++ a-nin qiymetini artiracaq

//int a = 5;
//int b =a++;

//Console.WriteLine(a);
//Console.WriteLine(b);



//++a her ikisinin qiymetini artiracaq


//int a = 10;
//int b = ++a;

//Console.WriteLine(a);  
//Console.WriteLine(b);


//int a = 20;    // a=20
//int b = --a;   //b=19  a=19
//int c = ++b;   //b=20  c=20

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);