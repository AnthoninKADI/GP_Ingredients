using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalOrbScript : Interactive
{
    public GameObject OrbSpawn;
    public GameObject Book;


    public override void OnInteraction()
    {
        OrbSpawn.SetActive(true);
        Book.SetActive(true);
    }
}
