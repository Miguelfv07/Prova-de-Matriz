using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const int velocidade = 2;
    bool jogador1;
    Color cordojogador;
    private Vector2 direcao;
   
    
    void Update()
    {
        if (jogador1)
        {
            float moveHorizontal = 0;
            float moveVertical = 0;
            if (Input.GetKeyDown(KeyCode.A))
            {
                moveHorizontal = -1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {  
                moveHorizontal = 1;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                moveVertical = -1;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                moveVertical = 1;
            }


        }
    }
}
