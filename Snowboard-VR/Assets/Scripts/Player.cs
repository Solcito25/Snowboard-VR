using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : NetworkBehaviour{

    //General
    public GameObject player;
    bool touched;
    //Skater
    //public GameObject skater;
    //Modifier
    //public GameObject modifier;
    //public GameObject objeto;
    //--Screen size
    private float width;
    private float height;
    
    void Start()
    {
        width = (float)Screen.width;
        height = (float)Screen.height;
        touched = false;
}
    void Update()
    {
        if (isServer)
        {
            Debug.Log("Soy server");
            Debug.Log(width + " & "+ height);
        }
        else
        {
            //if (Input.GetKeyDown("space"))
            Debug.Log("Soy el cliente");
            //SpawnTrees();
        }

    }

    /*public void SpawnTrees(){
        int x = 0;
        for (int i = 0; i < 5; ++i)
        {
            GameObject treeGo = Instantiate(treePrefab, new Vector3(x++, 0, 0), Quaternion.identity);
            NetworkServer.Spawn(treeGo);
        }
    }*/
}

