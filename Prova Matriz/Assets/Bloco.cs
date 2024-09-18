using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloco : MonoBehaviour
{
    bool conquistado;
    SpriteRenderer spriteRenderer;
    int jogadorDono;
    

    void Awake()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        InicializarBloco(Color.white);
        
    }

    private void InicializarBloco(Color cor)
    {
        spriteRenderer.color = cor;
        conquistado = false;
       
    }
    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        corDoJogador = Color.red;
        if (jogador1 = conquistado )
        {
            jogadorDono = jogador1 ? 1 : 0;
            GameManager.instance.ConquistarTerritorio();


        }
        else
        {
            jogadorDono = 2;
            GameManager.instance.ConquistarTerritorio();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
