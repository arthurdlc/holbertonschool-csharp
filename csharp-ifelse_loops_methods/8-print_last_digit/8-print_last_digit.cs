using System;

class Number
{
    public static int PrintLastDigit(int number)    {
        int last_digit = number % 10; // Dernier chiffre (conserve le signe)
        ConsoleWrite(last_digit);
    }
}
