using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public GameManager Manager;
    public bool playcountdown;
    public int seconds = 100;
    public TextMeshProUGUI timer;
    private ButtonAffect buttonAffect;
    [SerializeField] private bool isRunning;
    public float worsening = 0.5f;
    private bool gameover = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonAffect = GetComponent<ButtonAffect>();
    }

    private void Update()
    {
        if (buttonAffect.randomBoolean)
        {
            // Only start the coroutine if it is not already running
            if (!isRunning)
            {
                StartCoroutine(countdown());
            }
        }
        if (gameover) { Manager.EndGame(); }
        /*
        else
        {
            // Stop the coroutine if it is running and reset the seconds
            if (isRunning)
            {
                StopCoroutine(countdown());
                seconds = 100;
                timer.text = seconds.ToString();
            }
        }
        */
    }
    IEnumerator countdown()
    {
        isRunning = true;
        while (playcountdown) 
        { 
            if (seconds > 0)
            {
                seconds--;
                yield return new WaitForSeconds(1.0f * worsening);
            }
            timer.text = seconds.ToString();
            if (seconds == 0)
            {
                gameover = true; break;
            }
        }
        isRunning = false;
    }

    public void ResetAndWorsen()
    {
        if(seconds == 100) { return; }
        else
        {
            isRunning = false;
            playcountdown = false;
            seconds = 100;
            timer.text = seconds.ToString();
            worsening = worsening / 2;
        }
    }
    public void Activate()
    {
        playcountdown=true;
    }
}
