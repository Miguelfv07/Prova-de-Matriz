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
       
    }

}

