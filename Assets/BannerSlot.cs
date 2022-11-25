using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BannerSlot : Interactive
{
    public Animator animator;
    public GameObject BannerSpawn;

    public override void OnInteraction()
    {
        animator.enabled = true;
        BannerSpawn.SetActive(true);
    }
}
