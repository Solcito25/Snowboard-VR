using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPMountain : MonoBehaviour
{
    public GameObject player;
    public GameObject visor;
 
    public void named()
    {
        Debug.Log("Boton pressed");
        player.transform.position = visor.transform.position;
        player.transform.rotation = visor.transform.rotation;
        //GameObject.FindGameObjectWithTag("SnowBoard").transform.parent = player.transform;
        player.transform.parent = GameObject.FindGameObjectWithTag("SnowBoard").transform;
        GameObject.FindGameObjectWithTag("SnowBoard").GetComponent<gyro_script>().enabled = true;
        //RigidBody
        //public Rigidbody rb;
        //rb = GameObject.FindGameObjectWithTag("SnowBoard").GetComponent<RigidBody>();
    }
}
