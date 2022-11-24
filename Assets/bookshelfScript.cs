using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bookshelfScript : Interactive
{
    public GameObject Book, Lever;

    public override void OnInteraction()
    {
        Book.SetActive(true);
        Lever.SetActive(true);
    }
}
