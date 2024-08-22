using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private bool Ligado = true;
    public AudioSource audioSource;

    public void BtnPressionado()
    {
        if (Ligado)
        {
            Ligado = false;
            audioSource.mute = true;
        }
        else
        {
            Ligado = true;
            audioSource.mute = false;
        }
    }
    public void PlayMenu()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Sair()
    {
        Application.Quit();
    }
    public void PlayInfos()
    {
        SceneManager.LoadSceneAsync(2);
    }
}
