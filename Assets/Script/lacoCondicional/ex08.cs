using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Contador de horas e dias) Crie um script que em que uma
//vari�vel inteira hora seja incrementada de uma unidade a cada 10
//segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
//completar um ciclo, incremente uma vari�vel dias e escreva o
//n�mero de dias que se passaram no console. (Coloque o c�digo
//dentro da fun��o-evento Update).


public class ex08 : MonoBehaviour
{
    [SerializeField]int horas;
    [SerializeField]int dias;
    [SerializeField]float segundos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if(segundos >= 10f )
        {
            horas++;
            segundos = 0;
            if (horas == 24)
            {
                dias++;
                horas = 0;
                print(dias);

            }
        } 
    }
}
