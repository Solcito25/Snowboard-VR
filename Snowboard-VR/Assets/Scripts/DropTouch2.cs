using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class DropTouch2 : NetworkBehaviour
{
    public GameObject god;
    [SyncVar] public GameObject target;
    public GameObject objeto;
    private bool touched;

    [Command(requiresAuthority = false)]
    void CmdSpawnSnow()
    {
        /*GameObject SnowBall = Instantiate(objeto, nozzle.transform.position, transform.rotation);
        bulletClone.GetComponent<Rigidbody>().velocity = nozzle.transform.forward * bulletSpeed;
        NetworkServer.Spawn(bulletClone);*/

        //--------------------
        touched = true;
        UnityEngine.Touch touch = Input.GetTouch(0);

        Vector3 movement = new Vector3(touch.position.x / 5 - 40, 10f, touch.position.y / 5 - 48);
        Debug.Log("Touch Position : " + touch.position);
        GameObject SnowBall = Instantiate(objeto, target.transform.position + movement, Quaternion.identity);
        NetworkServer.Spawn(SnowBall);
    }
    void Start()
    {
        touched = false;
    }


    void Update()
    {
        Vector3 godlike = new Vector3(40f, 75f, 0f);
        god.transform.position = target.transform.position + godlike; ;
        //player.transform.rotation = visor.transform.rotation;

        if (!touched && Input.touchCount > 0)
        {
            /* touched = true;
             UnityEngine.Touch touch = Input.GetTouch(0);

             Vector3 movement = new Vector3(touch.position.x/5 -40, 10f, touch.position.y/5 -48);
             Debug.Log("Touch Position : " + touch.position);
             Instantiate(objeto, target.transform.position + movement, Quaternion.identity);*/
            CmdSpawnSnow();
        }
        if (Input.touchCount == 0)
        {
            touched = false;
        }


        //Static TD pos-------------------------
        /* if (!touched && Input.touchCount > 0)
         {
             touched = true;
             UnityEngine.Touch touch = Input.GetTouch(0);

             Vector3 movement = new Vector3(touch.position.x, 100f,touch.position.y);
             //Debug.Log("Touch Position : " + touch.position);
             Instantiate(objeto, target.transform.position + movement, target.transform.rotation);
         }
         if (Input.touchCount == 0)
         {
             touched = false;
         }
        */

    }
}
