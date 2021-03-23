using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField]
    float velocidade = 5f;
    bool bolalancada = false;
    float tempo = 0f;

    // Start is called before the first frame update
    void Start()
    {
        /*if(Random.value < 0.5f)
        {
            GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.right;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = velocidade * Vector2.;
        }*/

        //GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;

        

    }

    // Update is called once per frame
    void Update()
    {
        if(bolalancada == false)
        {
            tempo = tempo + Time.deltaTime;

            if (tempo >= 2)
            { 
                GetComponent<Rigidbody2D>().velocity = velocidade * Random.insideUnitCircle;
                bolalancada = true;
            
            }

        }
    }
}
