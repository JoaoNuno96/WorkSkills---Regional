using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptHeroi : MonoBehaviour
{

    public int pontos = 0;
    public float velocidadeX = 0.02f;
    public float velocidadeXSuperPoder = 0.04f;
    public float speed = 0;
    float tempoMunicao = 0;
    public GameObject municao;

    // Start is called before the first frame update
    void Start()
    {
        speed = velocidadeX;


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.45f)
        {
            if (VerificaPoder())
            {
                speed = velocidadeXSuperPoder;
            }
            else
            {
                speed = velocidadeX;
            }
            transform.position += new Vector3(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -9.45f)
        {

            if (VerificaPoder())
            {
                speed = velocidadeXSuperPoder;
            }
            else
            {
                speed = velocidadeX;
            }
            transform.position -= new Vector3(speed, 0, 0);
        }

        tempoMunicao += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            if (tempoMunicao > 0.2)
            {
                Instantiate(municao, this.transform.position, Quaternion.identity);
                tempoMunicao = 0;
            }
        }

    }
    bool VerificaPoder()
    {

        if (Input.GetKey(KeyCode.V))
        {
            return true;
        }
        else
        {
            return false;

        }
    }
}
