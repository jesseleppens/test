using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    public Animator Animator;
    int toggle = -1;

    public void ButtonClick()
    {
        toggle *= -1;
        if (toggle == 1)
        {
            Animator.Play("NavOpen");
        }
        else
        {
            Animator.Play("NavClose");
        }
    }

    public void Test()
    {
        Debug.Log("ja");
    }
}


