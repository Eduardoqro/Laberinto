using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    //Variables
    public float speed = 0f;
    float originalXposition, originalYposition, originalZposition;
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        // se guada la posicion de inicio del jugador
        originalXposition = transform.position.x;
        originalYposition = transform.position.y;
        originalZposition = transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement(); // para comprobar si el jugadpr se esta moviendo todo el tiempo
    }

    //Configurar el movimienton del jugador //Input.GetAxi para cuando se tocan las teclas del teclado//Time.deltaTime para evitar problemas de sincrocnia
    void PlayerMovement()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, Input.GetAxis("Vertical") * speed * Time.deltaTime,0);
    }
    //esta funcion devuelve al jugador a la poscion incial del juego // vector el para guarda 3 variables
    public void RestartPlayerPosition()
    {
        transform.position = new Vector3(originalXposition, originalYposition, originalZposition);
    }

    //Funcion para detectar cuando hayas cocando con un trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Enemy")
        {
            //Reiniciar la posicion del jugador
            //RestartPlayerPosition();
            GM.GameOverMenu();
            
        }
        if(collision.tag=="FinishLine")
        {
            //RestartPlayerPosition();
            GM.GameOverMenu();
        }
    }
}
