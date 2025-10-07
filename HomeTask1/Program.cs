#region HomeTask1
//Console.WriteLine("Istediyiniz ededi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//int max = 0;
//
//for (int i = n; i > 0; i /= 10)
//{
//    int reqem = i % 10;
//    if (reqem > max)
//    {
//        max = reqem;
//    }

//}
//Console.WriteLine(max);
#endregion
#region 2quvveti
//restart:

//Console.WriteLine("Ededi daxil edin");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n < 0)
//{
//    Console.WriteLine("Musbet eded daxil edin");
//    goto restart;
//}
//for (; n%2==0; n/=2)
//{

//}
//if (n == 1)
//{
//    Console.WriteLine("Eded 2 nin quvvetidir");
//}
//else
//{
//    Console.WriteLine("Eded 2 nin quvveti deyil");
//}

#endregion
#region MaxMin
//int[] n = { 5, 6, 7, 8, 9, 10, 11, 12 };
//int max = n[0];
//int min = n[0];


//for (int i = 0; i<n.Length; i++)
//{
//    if (n[i]>max)
//    {
//        max = n[i];
//    }
//    if (n[i] <min)
//    {
//        min = n[i];
//    }
//}
//Console.WriteLine(min+max);
#endregion
#region 3ebolunen
//int[] n = { 1, 2, 3, 45, 6, 7, 8, 9, };
//int say = 0;
//for (int i = 0; i < n.Length; i++)
//{
//    if (n[i]%2==1 && n[i]%3==0)
//    {
//        say++;
//    }

//}
//Console.WriteLine(say);
#endregion

#region murekkeb
//int[] n = { 3, 4, 6, 7, 8, 9, 1, 5 };
//int murekkebCount = 0;


//for (int i = 0; i < n.Length; i++)
//{
//    int num = n[i];


//    bool murekkeb = false;

//    for (int j = 2; j< num; j++)
//    {
//        if (num % j == 0)
//        {
//            murekkeb = true;
//            break;
//        }
//    }
//if (murekkeb) murekkebCount++;
//}
//Console.WriteLine(murekkebCount);




#endregion


