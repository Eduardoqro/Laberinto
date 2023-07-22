using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    // variables
    float speed = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();//para que rote sobre si mismo todo el tiempo
    }

    //Funcion para rotar imagen de enemigo
    void EnemyMovement()
    {
        transform.Rotate(0,0,speed*Time.deltaTime);
    }
}
