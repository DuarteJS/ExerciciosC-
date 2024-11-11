using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Lacos de repeticao

//for -> é utilizado quando se sabe a quantidade.

//while ou dowhile -> é utilizado quando nao se sabe a quantidade de repeticao.

//foreach ->Quando tem uma lista para cada elemento que fazer uma repeticao.

//ArrayList -> uma lista.

public class LancoDeRepeticao : MonoBehaviour
{
    int x = 0; //while;
    int y = 10; //DoWhile;
    // Start is called before the first frame update
    void Start()
    {
        //for(inicializador; condicao; incremento/decremento)
        //for (int i = 0; i <= 10; i++)
        //{
        //break;
        //if(i == 5)
        //{
        //    break;
        //}

        //continue -> ele pula o elemento imposto no caso "6"
        //if(i == 6)
        //{
        //    continue;
        //}
        //print(i);

        //while (x<10)
        //{
        //    print(x);
        //    x++;
        //}

        //        do
        //        {
        //            print(y);
        //            y--;
        //        }
        //        while (y >=0);
        //    }
        //array
        //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };
        //print(num[3]);
        //num[0]++;
        //print(num[0]);

        string[] nomes;
        nomes = new string[5];
        nomes[0] = "Tadola";
        print(nomes[0]);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
