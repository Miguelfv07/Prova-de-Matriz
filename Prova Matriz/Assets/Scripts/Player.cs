using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class Player : MonoBehaviour
{
    const int velocidade = 2;
    bool jogador1;
    bool jogador2;
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
            else
            {
                moveHorizontal = 0;
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                moveVertical = 1;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                moveVertical = -1;
            }
            else
            {
                moveVertical = 0;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            float moveHorizontal = 0;
            float moveVertical = 0;
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveHorizontal = -1;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveHorizontal = 1;
            }
            else
            {
                moveHorizontal = 0;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveVertical = -1;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveVertical = 1;
            }
            else
            {
                moveVertical = 0;
            }
            transform.Translate(direcao * velocidade * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Block"))
        {
            Bloco bloco = other.GetComponent<Bloco>();
        }
       
    }
}