using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static string ProcessText(string textIn)
    {
      
       
        string value = textIn;
        double number;
        double average = 0;
        double total = 0;

        double count = 0;
        
        string[] words = value.Split(' ');

        
        //counts words in string
        while (count < words.Length)
        {
            count++;
        }

       //sum of letters in string
        for (int i = 0; i < count; i++)
        {
            total += words[i].Length;  
        }


        average = total / count;
        

        if (double.TryParse(value, out number))
        {
            return count.ToString() + " Numbers ";
        }
        else
        {
            return count.ToString() + " words in the string. \n Average letters per word: "+ average.ToString("N1");
        }

        //Return a string if the user enters a string
        //Return a number if the user enters a number
        //How many numbers how many strings
    }
}
