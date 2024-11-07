using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ex02 : MonoBehaviour
{
    [SerializeField] bool powerUp;

    // Start is called before the first frame update
    void Start()
    {
        if (powerUp == true)
        {
            print("Power-up Coletado!");
        }
        else
        {
            print("Nenhum power-up encontrado");
        }
        //condicao? Caso vdd : Caso Falso

        print(powerUp  ? "Power-up Coletado!" : "Nenhum power-up encontrado");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
