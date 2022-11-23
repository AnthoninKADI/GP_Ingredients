using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTorch : Interactive
{

    public static int LitTorchesCount = 0;
    public GameObject Chest;
    public GameObject ChestLight;
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //
        //Activate light and fire
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        LitTorchesCount++;
        if(LitTorchesCount == 3)
        {
            ChestLight.SetActive(true);
            Chest.SetActive(true);
        }
    }
}
