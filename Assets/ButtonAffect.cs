using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAffect : MonoBehaviour
{
    public Countdown countdown;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateBoolean", 10f, 10f);
    }
    public bool randomBoolean;
    void GenerateBoolean()
    {
        // Set the threshold to 0.5
        float threshold = 0.5f;
        // Get a random float between 0 and 1
        float randomValue = Random.value;
        // Compare the random value with the threshold
        randomBoolean = randomValue > threshold;

        if (randomBoolean)
        {
            countdown.Activate();
        }
        Debug.Log("The random boolean is " + randomBoolean);
    }

    public void RestartThingy()
    {
        CancelInvoke();
        InvokeRepeating("GenerateBoolean", 10f, 10f);
    }
}
