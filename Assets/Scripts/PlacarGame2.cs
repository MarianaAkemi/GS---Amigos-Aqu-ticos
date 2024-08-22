using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlacarGame2 : MonoBehaviour
{
    public Text txtBoto;
    public Text txtCavalo;
    public Text txtCaconete;
    public Text txtEstrela;
    public Text txtLontra;
    public Text txtPepino;
    public Text txtBaleia;
    public Text txtFoca;
    public Text txtLeao;
    public Text txtOurico;
    public Text txtTartaruga;

    public GameObject Boto;
    public GameObject Cavalo;
    public GameObject Lontra;
    public GameObject Foca;
    public GameObject Pepino;
    public GameObject Tartaruga;


    public void ClickBoto()
    {
        if (Boto.tag == "Boto")
        {
            Boto.SetActive(false);
            PlacarGame.Botoptns++;
        }
    }
    public void ClickCavalo()
    {
        if (Cavalo.tag == "Cavalo")
        {
            Cavalo.SetActive(false);
            PlacarGame.Cavaloptns++;
        }
    }
    public void ClickPepino()
    {
        if (Pepino.tag == "Pepino")
        {
            Pepino.SetActive(false);
            PlacarGame.Pepinoptns++;
        }
    }
    public void ClickLontra()
    {
        if (Lontra.tag == "Lontra")
        {
            Lontra.SetActive(false);
            PlacarGame.Lontraptns++;
        }
    }
    public void ClickFoca()
    {
        if (Foca.tag == "Foca")
        {
            Foca.SetActive(false);
            PlacarGame1.Focaptns++;
        }
    }
    
    public void ClickTartaruga()
    {
        if (Tartaruga.tag == "Tartaruga")
        {
            Tartaruga.SetActive(false);
            PlacarGame1.Tartarugaptns++;
        }
    }

    void Start()
    {
        txtCaconete.text = PlacarGame.Caconeteptns.ToString();
        txtEstrela.text = PlacarGame.Estrelaptns.ToString();
        txtLeao.text = PlacarGame1.Leaoptns.ToString();
        txtOurico.text = PlacarGame1.Ouricoptns.ToString();
        txtBaleia.text = PlacarGame1.Baleiaptns.ToString();
    }
    void Update()
    {
        txtBoto.text = PlacarGame.Botoptns.ToString();
        txtCavalo.text = PlacarGame.Cavaloptns.ToString();
        txtFoca.text = PlacarGame1.Focaptns.ToString();
        txtLontra.text = PlacarGame.Lontraptns.ToString();
        txtPepino.text = PlacarGame.Pepinoptns.ToString();
        txtTartaruga.text = PlacarGame1.Tartarugaptns.ToString();

        if ((PlacarGame.Botoptns == 2) && (PlacarGame.Cavaloptns == 2) && (PlacarGame1.Focaptns == 2) && (PlacarGame.Lontraptns == 2) && (PlacarGame.Pepinoptns == 2) && (PlacarGame1.Tartarugaptns == 2) && (PlacarGame.Caconeteptns == 2) && (PlacarGame.Estrelaptns == 2) && (PlacarGame1.Leaoptns == 2) && (PlacarGame1.Ouricoptns == 2) && (PlacarGame1.Baleiaptns == 2))
        {
            SceneManager.LoadSceneAsync(7);
        }
    }
}
