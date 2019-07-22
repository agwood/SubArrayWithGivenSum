using System;


class GFG
{
    static void Main(string[] args)
    {
        int numOfTests = Convert.ToInt32(Console.ReadLine());

        IndividualTest[] tests = new IndividualTest[numOfTests];

        for (int i = 0; i < numOfTests; i++)
        {
            var sizeAndSum = Console.ReadLine();
            var stringArray = Console.ReadLine();

            IndividualTest test = new IndividualTest();
            test.size = Convert.ToInt32(sizeAndSum.Split(' ')[0]);
            test.sum = Convert.ToInt32(sizeAndSum.Split(' ')[1]);
            test.numsToTest = ConvertToIntArray(stringArray);
            tests.SetValue(test, i);
        }

        foreach (IndividualTest test in tests)
        {
            int size = test.size;
            int sum = test.sum;
            int[] arrayToTest = test.numsToTest;
            int startingArryPoint = -1;
            int finishArrayPoint = -1;

            for (int i = 0; i < size; i++)
            {
                int totalSum = 0;
                int j = i;
                while (totalSum < sum && j < size)
                {
                    totalSum += arrayToTest[j];
                    if (totalSum >= sum)
                    {
                        break;
                    }
                    j++;

                }
                if (totalSum == sum)
                {
                    startingArryPoint = i + 1;
                    finishArrayPoint = j + 1;
                    break;
                }
            }

            if (startingArryPoint == -1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                Console.WriteLine(startingArryPoint.ToString() + " " + finishArrayPoint.ToString());
            }

        }
    }

    private static int[] ConvertToIntArray(string stringArray)
    {
        String[] tempArray = stringArray.Split(' ');
        int[] intArray = new int[tempArray.Length];

        for (int i = 0; i < tempArray.Length; i++)
        {
            intArray[i] = Convert.ToInt32(tempArray[i]);
        }
        return intArray;
    }
}


public class IndividualTest
{
    public int size { get; set; }
    public int sum { get; set; }
    public int[] numsToTest { get; set; }
}