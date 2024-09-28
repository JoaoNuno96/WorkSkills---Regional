using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class ScriptInimigo : MonoBehaviour
{

    ScriptHeroi heroi;
    float velocidadeInimigo = 0.02f;
    TextMeshProUGUI tryAgainButtonText;
    Image tryAgainButtonImg;
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
        transform.position -= new Vector3(0, 0, velocidadeInimigo);
        if (transform.position.z < -14.47)
        {
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
