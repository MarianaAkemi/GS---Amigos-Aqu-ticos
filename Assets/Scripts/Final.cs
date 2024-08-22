using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Final : MonoBehaviour
{
    public GameObject fala;
    public GameObject reiniciar;

    public void ApertouBtn()
    {
        fala.SetActive(false);
        reiniciar.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
