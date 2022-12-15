using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class SnowBalls : NetworkBehaviour
{
    public GameObject target;
    public GameObject objeto;

    /*public void balling()
    {
        Debug.Log("Snow boton");
        Vector3 movement = new Vector3(0f, 100.0f, 0f);
        Instantiate(objeto, target.transform.position + movement, target.transform.rotation);
    }*/


    [Command(requiresAuthority = false)]
    public void Cmdballing()
    {
        if (objeto != null)
        {
            Debug.Log("Snow boton");
            Vector3 movement = new Vector3(0f, 100.0f, 0f);
            var ball = Instantiate(objeto, target.transform.position + movement, target.transform.rotation);
            NetworkServer.Spawn(ball);
        }
    }
}
