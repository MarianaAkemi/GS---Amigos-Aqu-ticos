using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game : MonoBehaviour
{
    public GameObject placar1;
    public GameObject placar2;

    public void AbrirPlacar()
    {
        placar1.SetActive(true);
    }
    public void ProxPlacar()
    {
        placar1.SetActive(false);
        placar2.SetActive(true);
    }
    public void VoltarPlacar()
    {
        placar1.SetActive(true);
        placar2.SetActive(false);
    }
    public void FecharPlacar()
    {
        placar1.SetActive(false);
        placar2.SetActive(false);
    }
    
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(3);
    }

    public void PlayGame1()
    {
        SceneManager.LoadSceneAsync(4);
    }

    public void PlayGame2()
    {
        SceneManager.LoadSceneAsync(5);
    }

    public void PlayGame3()
    {
        SceneManager.LoadSceneAsync(6);
    }
}
    

    
