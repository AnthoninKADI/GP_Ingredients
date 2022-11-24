using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : Interactive
{
    public Animator animator;

    public override void OnInteraction()
    {
        animator.enabled = true;
    }
}
