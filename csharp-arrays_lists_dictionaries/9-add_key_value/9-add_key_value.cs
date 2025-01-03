using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // If the key already exists, replace the value; otherwise, add the new key-value pair
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value;  // Update the existing key's value
        }
        else
        {
            myDict.Add(key, value);  // Add the new key-value pair
        }

        return myDict;  // Return the updated dictionary
    }
}