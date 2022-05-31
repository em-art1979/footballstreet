using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack: MonoBehaviour
{

  public GameObject Player1;
  public GameObject Player2;

  Player1 player1;
  Player2 player2;

  public bool Player1Selected;
  public bool Player2Selected;

  public bool Player1Playing;
  public bool Player2Playing;


    // Start is called before the first frame update
    void Awake()

    {

    }

    void Start()
    {


      Player1Selected=true;
      Player2Selected=false;


    }

    // Update is called once per frame
    void Update()
    {
        //seleccion de jugador mediante boton mientras ataca el contrario//

        if(Player1Selected==true)
        {
          Player1Playing=true;
          Player2Playing=false;
        }
        if(Player2Selected==true)

        {
          Player1Playing=false;
          Player2Playing=true;

        }

        if(Player1Playing==true)
        {

          player1=FindObjectOfType<Player1>();
          player1.EnableMovement();


        }
        if(Player2Playing==true)

        {
          player2=FindObjectOfType<Player2>();
          player2.EnableMovement();

        }

        if(Player1Playing==false)
        {
          player1=FindObjectOfType<Player1>();
          player1.DisableMovement();
        }

        if(Player2Playing==false)

        {
          player2=FindObjectOfType<Player2>();
          player2.DisableMovement();

        }

    }


}
