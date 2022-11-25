using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEndThomasScript : Interactive
{
    public GameObject GoldenKey;
    public Animator animator;


    public override void OnInteraction()
    {
        GoldenKey.SetActive(true);
        Invoke("AnimationDoorEndThomas", 1f);
    }

    private void AnimationDoorEndThomas()
    {
        animator.enabled = true;
    }
}