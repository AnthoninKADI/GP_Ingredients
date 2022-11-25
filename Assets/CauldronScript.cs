using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class CauldronScript : Interactive
{
    public GameObject RedPotion, PurplePotion, GreenPotion;
    public GameObject RustyKey, GoldenKey;


    public override void OnInteraction()
    {
        RustyKey.SetActive(true);
    }

    private void SpawnGoldenKey()
    {
        GoldenKey.SetActive(true);
    }
}