using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;
//4. (Pontua��o em combos) Cada combo realizado aumenta em 10
//pontos. Exiba a pontua��o total ap�s 7 combos.
public class Ex4c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int combo = 10; combo <= 70; combo += 7)
        {
            if (combo == 70)
            {
                print("Pontua��o total 70.");
                break;
            }
        } 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
