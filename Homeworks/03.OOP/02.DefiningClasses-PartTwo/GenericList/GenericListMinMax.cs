using System;

// 7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
public static class GenericListMinMax
{
    // 7.1 You may need to add a generic constraints for the type T.
    public static T Min<T>(this GenericList<T> genericList) where T : IComparable
    {
        if (genericList.Count == 0)
        {
            throw new ArgumentNullException("The list is empty.");
        }
        dynamic min = genericList[0];
        for (int i = 1; i < genericList.Count; i++)
        {
            if (genericList[i] < min)
            {
                min = genericList[i];
            }
        }
        return (T)min;
    }

    public static T Max<T>(this GenericList<T> genericList) where T : IComparable
    {
        if (genericList.Count == 0)
        {
            throw new ArgumentNullException("The list is empty.");
        }
        dynamic max = genericList[0];
        for (int i = 1; i < genericList.Count; i++)
        {
            if (genericList[i] > max)
            {
                max = genericList[i];
            }
        }
        return (T)max;
    }
}