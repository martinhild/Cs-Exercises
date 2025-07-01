using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

internal class BinarySearch
{
    
    public static void Run()
    {
        List<int> sortedList;
        sortedList = SortedList(200,1000);
    }


    private static List<int> SortedList(int length, int range)
    {
        List<int> list = [];
        Random random = new Random();

        for (int i = 0; i <= length; i++)
        {
            list.Add(random.Next(1, range+1));
        }
        list.Sort();
        return list;
    }

    private static int binarySearch(int number, List<int> list)
    {
        return -1;
    }

}
