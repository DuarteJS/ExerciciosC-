using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Cálculo de moedas coletadas) O jogador coleta 3 moedas a
//cada fase. Após 10 fases, exiba o total de moedas coletadas.
public class Ex3c : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int fase = 3; fase <= 30; fase +=3 )
        {
            if (fase == 30)
            {
                print("30 Moedas coletadas.");
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
