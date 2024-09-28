using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScriptInimigoB : MonoBehaviour
{
    ScriptHeroi heroi;
    TextMeshProUGUI tryAgainButtonText;
    Image tryAgainButtonImg;


    float velocidadeInimigoB = 0.04f;
    // Start is called before the first frame update
    void Start()
    {
        heroi = GameObject.Find("Heroi").GetComponent<ScriptHeroi>();
        tryAgainButtonText = GameObject.Find("TextButton").GetComponent<TextMeshProUGUI>();
        tryAgainButtonImg = GameObject.Find("TryAgainButton").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,0,velocidadeInimigoB);
        if(transform.position.z < -14.47) { 
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "heroi") {
            TextMeshProUGUI gameOverTexto = GameObject.Find("GameOver").GetComponent<TextMeshProUGUI>();
            gameOverTexto.enabled = true;
            tryAgainButtonText.enabled = true;
            tryAgainButtonImg.enabled = true;
            heroi.speed = 0;
            heroi.velocidadeX = heroi.speed;
            heroi.velocidadeXSuperPoder = heroi.speed;

        }
    }
}
