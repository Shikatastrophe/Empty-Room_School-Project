using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInteract : MonoBehaviour, IInteractable
{
    private Animator animator;
    public AudioSource buttonsound;
    public Countdown countdown;
    public ButtonAffect buttonAffect;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Interact()
    {
        animator.SetTrigger("Click");
        countdown.ResetAndWorsen();
        buttonAffect.RestartThingy();
    }

    public void PlaySound()
    {
        buttonsound.Play();
    }
}
