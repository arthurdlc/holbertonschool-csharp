using System;

class Character
{
    public static bool IsLower(char c)
    {
        int asciiValue = (int)c; // Conversion du caractère en code ASCII
        if (asciiValue >= 97 && asciiValue <= 122) // Vérifie si c'est une lettre minuscule
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
