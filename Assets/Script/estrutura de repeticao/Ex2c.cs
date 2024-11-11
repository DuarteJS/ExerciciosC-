using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//(Multiplicação de dano) Um personagem ataca cinco vezes, e o
//dano do ataque aumenta em 2 a cada vez. Exiba o dano a cada
//ataque.
public class Ex2c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int dano = 1; dano == dano; dano +=2 )
        {
            dano += 2;
            print(dano);
            if ( dano == 11)
            {
                break;
            }

         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
            }
