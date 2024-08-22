using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Game2 : MonoBehaviour
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

    

}
