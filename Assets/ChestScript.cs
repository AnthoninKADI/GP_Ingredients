using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : Interactive
{
    public GameObject SilverKey;
    public Animator animator;

    void Start()
    {
        SilverKey.SetActive(false);
    }
    public override void OnInteraction()
    {
        animator.enabled = true;
        Invoke("SpawnKey", 1f);
    }

    private void SpawnKey()
    {
        SilverKey.SetActive(true);
    }
}
