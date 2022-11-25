using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : Interactive
{
    public Animator animator;
    public GameObject SwordSpawn;

    public override void OnInteraction()
    {
        animator.enabled = true;
        SwordSpawn.SetActive(true);
    }
}
