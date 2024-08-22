using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Infos1 : MonoBehaviour
{
    public GameObject ABoto;
    public GameObject ACavalo;
    public GameObject ALontra;
    public GameObject AFoca;
    public GameObject APepino;
    public GameObject ATartaruga;
    public GameObject AEstrela;
    public GameObject ALeao;
    public GameObject AOurico;
    public GameObject ABaleia;
    public GameObject ACaconete;

    public void Baleia()
    {
        ABaleia.SetActive(false);
        ABoto.SetActive(true);
    }
    public void Boto()
    {
        ABoto.SetActive(false);
        ACavalo.SetActive(true);
    }
    public void Cavalo()
    {
        ACavalo.SetActive(false);
        ACaconete.SetActive(true);
    }
    public void Caconete()
    {
        ACaconete.SetActive(false);
        AEstrela.SetActive(true);
    }
    public void Estrela()
    {
        AEstrela.SetActive(false);
        AFoca.SetActive(true);
    }
    public void Foca()
    {
        AFoca.SetActive(false);
        ALeao.SetActive(true);
    }
    public void Leao()
    {
        ALeao.SetActive(false);
        ALontra.SetActive(true);
    }
    public void Lontra()
    {
        ALontra.SetActive(false);
        AOurico.SetActive(true);
    }
    public void Ourico()
    {
        AOurico.SetActive(false);
        APepino.SetActive(true);
    }
    public void Pepino()
    {
        APepino.SetActive(false);
        ATartaruga.SetActive(true);
    }
    public void Tartaruga()
    {
        ATartaruga.SetActive(false);
        ABaleia.SetActive(true);
    }
    public void Fechar()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
