using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private static int scorePlayer = 0;
    private static int nbFleche = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void SetScorePlayer(int score)
    {
        scorePlayer = score;
    }
    
    public static int GetScorePlayer()
    {
        return scorePlayer;
    }

    public static int GetNbFleche()
    {
        return nbFleche;
    }

    public static void SetNbFleche(int nb)
    {
        nbFleche = nb;
    }
}
