using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject TileWin;
    [SerializeField] private GameObject TileStart;
    [SerializeField] private GameObject GridCells;


    
    void Start()
    {
        Instantiate(TileStart, new Vector3(-5, -2, -1), Quaternion.identity);
        Instantiate(TileWin, new Vector3(5, 8, -1), Quaternion.identity);
    }

    void Update()
    {
        
    }

    public void TapToStart()
    {
        Instantiate(Player, new Vector3(-5, -2, -2), Quaternion.identity);
    }
}
