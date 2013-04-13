using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GenericList<T> where T:IComparable
{
    private T[] elemArray;
    public GenericList(int size)
    {
        elemArray=new T[size];
    }
    public T this[int index]
    {
        get
        {
            return elemArray[index];
        }
        set
        {
            elemArray[index] = value;
        }
    }
    private int  position;
    public T Max()
    {
        dynamic maxElem = int.MinValue;
        for (int i = 0; i < elemArray.Length; i++)
        {
            if (elemArray[i] > maxElem)
            {
                maxElem = elemArray[i];
            }
        }
        return maxElem;
    }

    public T Min()
    {
        dynamic minElem = int.MaxValue;
        for (int i = 0; i < elemArray.Length; i++)
        {
            if (elemArray[i] < minElem)
            {
                minElem = elemArray[i];
            }
        }
        return minElem;
    }

    public void AddElement(T element)
    {
        if (position >= elemArray.Length)
        {
            // autogrow
            T[] newList = new T[elemArray.Length * 2];
            for (int i = 0; i < elemArray.Length; i++)
            {
                newList[i] = elemArray[i];
            }
            position++;
            newList[elemArray.Length] = element;
            elemArray = newList;
        }
        else
        {
            elemArray[position] = element;
            position++;
        }
    }
    public void RemoveElemAtIndex(int index)
    {
        if (index < elemArray.Length)
        {
            T[] newList = new T[elemArray.Length - 1];
            bool beforeRem = true;

            for (int i = 0; i < elemArray.Length - 1; i++)
            {
                if (i == index)
                {
                    beforeRem = false;
                }

                if (beforeRem)
                {
                    newList[i] = elemArray[i];
                }
                else
                {
                    newList[i] = elemArray[i + 1];
                }
            }

            elemArray = newList;
        }
        else
        {
            Console.WriteLine("Outside the array");
        }
    }

    public void InsertElemAtIndex(int index, T element)
    {
        if (index < elemArray.Length)
        {
            T[] newList = new T[elemArray.Length + 1];
            bool beforeRem = true;

            for (int i = 0; i < elemArray.Length + 1; i++)
            {
                if (i == index)
                {
                    beforeRem = false;
                    newList[i] = element;
                    continue;
                }

                if (beforeRem)
                {
                    newList[i] = elemArray[i];
                }
                else
                {
                    newList[i] = elemArray[i - 1];
                }
            }

            elemArray = newList;
        }
        else
        {
            Console.WriteLine("Outside the array");
        }
    }

    public void ClearList()
    {
        elemArray = new T[elemArray.Length];
    }

    public int FindElemByValue(T value)
    {
        int indexFound = -1;

        for (int i = 0; i < elemArray.Length; i++)
        {

            if (elemArray[i].Equals(value))
            {
                indexFound = i;
                break;
            }
        }

        return indexFound;
    }

    public override string ToString()
    {
        StringBuilder endText = new StringBuilder();
        foreach (var item in elemArray)
        {
            endText.AppendFormat("{0} ", item);
        }
        return endText.ToString().Trim();
    }
}

