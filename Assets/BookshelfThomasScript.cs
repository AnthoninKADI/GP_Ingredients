using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookshelfThomasScript : Interactive
{
    public Animator animator;
    public GameObject Book;


    public override void OnInteraction()
    {
        Book.SetActive(true);
        animator.enabled = true;
    }
}

