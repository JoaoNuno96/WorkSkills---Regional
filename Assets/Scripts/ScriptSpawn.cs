using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSpawn : MonoBehaviour
{

    public GameObject inimigoA;
    public GameObject inimigoB;
    Vector3 posicaoInimigoX = new Vector3(0, 0.6f, 14.51f);
    float temporizadorInimigoA = 0;
    float temporizadorInimigoB = 0;

    //public GameObject inimigoB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temporizadorInimigoA += Time.deltaTime; 
        if (temporizadorInimigoA > 1) {
            float posicaoAleatoriaInimigo = Random.Range(-9.45f, 9.45f);
            posicaoInimigoX.x = posicaoAleatoriaInimigo;
            GameObject newPositionRotation = Instantiate(inimigoA, posicaoInimigoX, Quaternion.identity);
            newPositionRotation.transform.Rotate(new Vector3(0,180,0));
            temporizadorInimigoA = 0;
        }
        temporizadorInimigoB += Time.deltaTime;
        if (temporizadorInimigoB > 2)
        {
            float posicaoAleatoriaInimigo = Random.Range(-9.45f, 9.45f);
            posicaoInimigoX.x = posicaoAleatoriaInimigo;
            GameObject newPositionRotation = Instantiate(inimigoB, posicaoInimigoX, Quaternion.identity);
            newPositionRotation.transform.Rotate(new Vector3(0, 180, 0));
            temporizadorInimigoB = 0;
        }


    }
}
