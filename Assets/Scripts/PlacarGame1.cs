using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlacarGame1 : MonoBehaviour
{
    public Text txtBoto;
    public Text txtCavalo;
    public Text txtCaconete;
    public Text txtEstrela;
    public Text txtLontra;
    public Text txtPepino;

    public GameObject Baleia;
    public static int Baleiaptns;
    public Text txtBaleia;

    public GameObject Foca;
    public static int Focaptns;
    public Text txtFoca;

    public GameObject Leao;
    public static int Leaoptns;
    public Text txtLeao;

    public GameObject Ourico;
    public static int Ouricoptns;
    public Text txtOurico;

    public GameObject Tartaruga;
    public static int Tartarugaptns;
    public Text txtTartaruga;

    public void ClickBaleia()
    {
        if (Baleia.tag == "Baleia")
        {
            Baleia.SetActive(false);
            Baleiaptns++;
        }
    }
    
    public void ClickFoca()
    {
        if (Foca.tag == "Foca")
        {
            Foca.SetActive(false);
            Focaptns++;
        }
    }
    public void ClickLeao()
    {
        if (Leao.tag == "Leao")
        {
            Leao.SetActive(false);
            Leaoptns++;
        }
    }
    
    public void ClickOurico()
    {
        if (Ourico.tag == "Ourico")
        {
            Ourico.SetActive(false);
            Ouricoptns++;
        }
    }
    
    public void ClickTartaruga()
    {
        if (Tartaruga.tag == "Tartaruga")
        {
            Tartaruga.SetActive(false);
            Tartarugaptns++;
        }
    }

    void Start()
    {
        txtBoto.text = PlacarGame.Botoptns.ToString();
        txtCavalo.text = PlacarGame.Cavaloptns.ToString();
        txtCaconete.text = PlacarGame.Caconeteptns.ToString();
        txtEstrela.text = PlacarGame.Estrelaptns.ToString();
        txtLontra.text = PlacarGame.Lontraptns.ToString();
        txtPepino.text = PlacarGame.Pepinoptns.ToString();
    }
    void Update()
    {
        txtBaleia.text = Baleiaptns.ToString();
        txtFoca.text = Focaptns.ToString();
        txtLeao.text = Leaoptns.ToString();
        txtOurico.text = Ouricoptns.ToString();
        txtTartaruga.text = Tartarugaptns.ToString();

        if ((PlacarGame.Botoptns == 2) && (PlacarGame.Cavaloptns == 2) && (Focaptns == 2) && (PlacarGame.Lontraptns == 2) && (PlacarGame.Pepinoptns == 2) && (Tartarugaptns == 2) && (PlacarGame.Caconeteptns == 2) && (PlacarGame.Estrelaptns == 2) && (Leaoptns == 2) && (Ouricoptns == 2) && (Baleiaptns == 2))
        {
            SceneManager.LoadSceneAsync(7);
        }
    }
}
