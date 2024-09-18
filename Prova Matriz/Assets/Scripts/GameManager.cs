using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class GameManager : MonoBehaviour
{

    public GameObject blockPrefab;
    public GameObject player1Prefab;
    public GameObject player2Prefab;
    public int numeroLinhas;
    public int numeroColunas;
    public float blockEspaco;
    private Bloco[,] grade;
    private int contagem;
    public static GameManager instance;



    private void Awake()
    {
       instance = this;
       grade = new Bloco[numeroLinhas, numeroColunas];


        CriarGrade();

    }

    private void CriarGrade()
    {
        for (int i = 0; i < numeroLinhas; i++)
        {
            for (int j = 0; j < numeroColunas; j++)
            {

                Vector3 blockposicao = new Vector3(j * blockEspaco, 0, i * blockEspaco);


                GameObject block = Instantiate(blockPrefab, blockposicao, Quaternion.identity);


                grade[i, j] = block.GetComponent<Bloco>();
                PosicionarJogadores();
                AjustarCamera();
            }
        }
    }


private void PosicionarJogadores()
{

    Vector3 player1Position = new Vector3(0, 0, 0);


    Vector3 player2Position = new Vector3((numeroColunas - 1) * blockEspaco, 0, (numeroColunas - 1) * blockEspaco);

    Instantiate(player1Prefab, player1Position, Quaternion.identity);
    Instantiate(player2Prefab, player2Position, Quaternion.identity);
}


private void AjustarCamera()
{

    Vector3 posicaoCentral = new Vector3((numeroColunas - 1) * blockEspaco / 2, 10, (numeroLinhas - 1) * blockEspaco / 2);

    Camera.main.transform.position = posicaoCentral;
    Camera.main.transform.rotation = Quaternion.Euler(90, 0, 0);
    Camera.main.orthographicSize = Mathf.Max(numeroColunas, numeroLinhas) * blockEspaco / 2;
}
    public void ConquistarTerritorio()
    {
     
        contagem++;


        if (contagem == numeroLinhas  *numeroColunas)
        {
  
            int blocosJogador1 = 0;
            int blocosJogador2 = 0;


            for (int i = 0; i < numeroLinhas; i ++)
            {
                for (int j = 0;j  < numeroColunas; j++)
                {
                    Bloco blocoAtual = grade[i, j];

                    if (blocoAtual.ConquistadoPorJogador1)
                    {
                        blocosJogador1++;
                    }
                    else if (blocoAtual.ConquistadoPorJogador2)
                    {
                        blocosJogador2++;
                    }
                }
            }

          
            FimDeJogo(blocosJogador1, blocosJogador2);
        }
    }


    private void FimDeJogo(int blocosJogador1, int blocosJogador2)
    {
        if (blocosJogador1 > blocosJogador2)
        {
            //apenas teste
            Debug.Log("Jogador 1 venceu!");
        }
        else if (blocosJogador2 > blocosJogador1)
        {
            Debug.Log("Jogador 2 venceu!");
        }
        else
        {
            Debug.Log("Empate!");
        }

   
    }

}


