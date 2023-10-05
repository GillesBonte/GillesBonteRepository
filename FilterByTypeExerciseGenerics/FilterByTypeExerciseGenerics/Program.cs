List<T> FilterByType<T>(List<object> mixedList)
{
    List<T> result = new List<T>();

    foreach (object item in mixedList)
    {

        if (item is T)
        {
            result.Add((T)item);
        }

    }

    return result;
}



List<object> checkList = new List<object>();
List<DateTime> resultList = new List<DateTime>();

checkList.Add(1);
checkList.Add("1");
checkList.Add(DateTime.Now);

resultList = FilterByType<DateTime>(checkList);

foreach (object item in resultList) 
{
    Console.WriteLine(item.ToString());
}


Console.ReadLine();
