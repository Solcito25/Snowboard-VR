using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject visor;
 
    public void named()
    {
        Debug.Log("Boton pressed");
        player.transform.position = visor.transform.position;
        player.transform.rotation = visor.transform.rotation;
    }
}
