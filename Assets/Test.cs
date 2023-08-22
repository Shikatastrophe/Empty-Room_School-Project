using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Invoke the GenerateBoolean function every 10 seconds
        InvokeRepeating("GenerateBoolean", 0f, 10f);
    }

    // Generate a random boolean value
    void GenerateBoolean()
    {
        // Set the threshold to 0.5
        float threshold = 0.5f;
        // Get a random float between 0 and 1
        float randomValue = Random.value;
        // Compare the random value with the threshold
        bool randomBoolean = randomValue > threshold;
        Debug.Log("The random boolean is " + randomBoolean);
    }
}
