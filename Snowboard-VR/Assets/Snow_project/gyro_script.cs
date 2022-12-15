using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class gyro_script : NetworkBehaviour
{
    [SyncVar] public GameObject Board;       // Board fisico, acompaña al Avatar
    public GameObject Avatar;      // Camara, vista primera persona  
    bool Freno;                    // Detener tabla

    void Start()
    {
        //activar
        Debug.Log("Dentro gyro");
        gameObject.AddComponent<Rigidbody>();
        Input.gyro.enabled = true;  // Activar gyroscopio
        Freno = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.gyro.attitude.eulerAngles);
        //Debug.Log(Input.GetJoystickNames());
        Mover();
    }

    void Mover()
    {

        //Caer
        float BoardFall = Board.transform.rotation.eulerAngles.x; //Aceleracion gravedad (mejorar)
        if ( !Freno && BoardFall > 2 && BoardFall < 30)
        {
            Board.transform.Translate(new Vector3(0.0f, 0.0f, BoardFall/100)); // Descenso en inclinacion
        }

        //Eje Z (adelante-atras)
        float EulerUD = Input.gyro.attitude.eulerAngles.y;
        if (EulerUD > 10 && EulerUD < 30) //(Frenar)
        {
            Freno = true;
        }
        else { Freno = false; }
        
        if (EulerUD > 330 && EulerUD < 350) // Mover adelante (acelerar)
        {
            Board.transform.Translate(new Vector3(0.0f, 0.0f, (360 - EulerUD) / 100)); // Mover adelante
        }

        //Eje Y (Izquierda-derecha)
        float EulerRL = Input.gyro.attitude.eulerAngles.x;
        if (EulerRL > 15 && EulerRL < 30) //inclinar izquierda
        {
            Board.transform.Rotate(0f, -EulerRL/30, 0f, Space.Self);
        }
        if (EulerRL > 330 && EulerRL < 345) //inclinar derecha
        {
            Board.transform.Rotate(0f, (360-EulerRL) / 30, 0f, Space.Self);
        }
    }
}
