using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CauldronScript : Interactive
{
    public GameObject RustyKey;


    public override void OnInteraction()
    {
        RustyKey.SetActive(true);
    }
}