using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptMenuPrincipal : MonoBehaviour
{
    public void Jogar() {
        SceneManager.LoadSceneAsync(1);
    }
}
