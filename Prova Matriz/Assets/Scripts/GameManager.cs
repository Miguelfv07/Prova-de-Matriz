using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject blocoPrefab;
    public GameObject jogador1;
    public GameObject jogador2;
    int linha;
    int coluna;
    float espacamento;
    Bloco[,] grade;
    int contador;
    static public GameManager instance;

    private void Awake()
    {
        instance = this;
        grade = grade[linha, coluna];
        CriarGrade();
    }

    public void CriarGrade()
    {
       int posicao ;
        Vector2 jogadores;
        for(int i = 0; i < grade.Length;i++)
        {
            for (int j = 0; j < grade.Length;j++)
            {
                posicao = coluna + linha;
                Bloco bloco = Instantiate(blocoPrefab, new Vector2(i, j), Quaternion.identity);
                grade[i,j] = bloco;

             
            }
        }
      

        jogadores = new Vector2((linha * coluna) / 2, (linha * coluna) / 2);

               





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
