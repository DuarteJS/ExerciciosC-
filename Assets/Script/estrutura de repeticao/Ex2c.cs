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
        for (int combo = 10; combo <= 70; combo += 7)
        {
            if (combo == 70)
            {
                print("Pontuação total 70.");
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
            }
