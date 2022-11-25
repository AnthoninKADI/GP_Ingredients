using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldScript : Interactive
{
    public GameObject Sword, Banner;
    public override void OnInteraction()
    {
        Sword.SetActive(true);
        Banner.SetActive(true);
    }
}
