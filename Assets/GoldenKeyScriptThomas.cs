using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenKeyScriptThomas : Interactive
{
    public GameObject GoldenKey;


    public override void OnInteraction()
    {
        GoldenKey.SetActive(true);
    }
}



