using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ex1 : MonoBehaviour
{
   [SerializeField] int vidaPlayer = 100;
    string resultado;
    // Start is called before the first frame update
    void Start()
    {
        if(vidaPlayer > 0)
    {
       print  ("personagem vivo!");
    }
        else
        {
            print("Game Over");
        }

        resultado = (vidaPlayer > 0) ? "Personagem vivo!" : "Game Over!";
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
