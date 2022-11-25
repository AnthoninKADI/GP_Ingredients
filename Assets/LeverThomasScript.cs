using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverThomasScript : Interactive
{
    public Animator animatorGate, animatorLever;

    public override void OnInteraction()
    {
        animatorLever.enabled = true;
        animatorGate.enabled = true;
    }
}
