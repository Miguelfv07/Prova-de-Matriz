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
        jogadorDono = 0;
       
    }
    public void AlterarConquista(bool jogador1, Color corDoJogador)
    {
        conquistado = true;
        AtualizarCor(corDoJogador);
       
        
        jogadorDono = jogador1 ? 1 : 2;
        GameManager.instance.ConquistarTerritorio();

       
        
    }
    public bool PegarConquistado() 
    {
        return conquistado;
    }
    public int PegarJogadorDono()
    {
        return jogadorDono; 
    }
    private void AtualizarCor( Color novaCor)
    {
        spriteRenderer.color = novaCor;
    }
}
