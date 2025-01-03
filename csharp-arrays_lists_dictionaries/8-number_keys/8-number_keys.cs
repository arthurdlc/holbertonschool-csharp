using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keyCount = 0;

        // Iterate through the dictionary and count the keys
        foreach (var keyValuePair in myDict)
        {
            keyCount++;
        }

        return keyCount;
    }
}