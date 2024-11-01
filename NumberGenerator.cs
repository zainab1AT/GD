using System;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    void Start()
    {
        Random random = new Random();
        int number;

        while (true)
        {
            number = random.Next(1, 21); 

            if (number == 5)
            {
                continue; 
            }

            Debug.Log("Random number: " + number);

            if (number == 15)
            {
                break;
            }
        }
    }
}
