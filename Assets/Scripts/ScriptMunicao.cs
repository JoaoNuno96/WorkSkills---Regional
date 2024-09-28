using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScriptMunicao : MonoBehaviour
{
    TextMeshProUGUI pontosTela;
    ScriptHeroi heroi;

    public float velocidadeMunicao = 0.5f;
    // Start is called before the first frame update

    void Start()
    {
        pontosTela = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        heroi = GameObject.Find("Heroi").GetComponent<ScriptHeroi>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, velocidadeMunicao);
        if (transform.position.z > 30)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "inimigoA")
        {
            if (heroi.speed != 0){
         
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                heroi.pontos += 10;
                pontosTela.text = heroi.pontos.ToString();
            }
           

        }
        if (other.gameObject.tag == "inimigoB")
        {
            if (heroi.speed != 0) {
               
                Destroy(other.gameObject);
                Destroy(this.gameObject);
                heroi.pontos += 10;
                pontosTela.text = heroi.pontos.ToString();
            }
            
        }


    }
}
