using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlacarGame : MonoBehaviour
{
    public Text txtBaleia;
    public Text txtFoca;
    public Text txtLeao;
    public Text txtOurico;
    public Text txtTartaruga;

    public GameObject Boto;
    public static int Botoptns;
    public Text txtBoto;

    public GameObject Cavalo;
    public static int Cavaloptns;
    public Text txtCavalo;

    public GameObject Caconete;
    public static int Caconeteptns;
    public Text txtCaconete;

    public GameObject Estrela;
    public static int Estrelaptns;
    public Text txtEstrela;

    public GameObject Lontra;
    public static int Lontraptns;
    public Text txtLontra;

    public GameObject Pepino;
    public static int Pepinoptns;
    public Text txtPepino;

    public void ClickPepino()
    {
        if (Pepino.tag == "Pepino")
        {
            Destroy(Pepino);
            Pepinoptns++;
        }
    }
    public void ClickLontra()
    {
        if (Lontra.tag == "Lontra")
        {
            Destroy(Lontra);
            Lontraptns++;
        }
    }
    public void ClickBoto()
    {
        if (Boto.tag == "Boto")
        {
            Destroy(Boto);
            Botoptns++;
        }
    }
    public void ClickCavalo()
    {
        if (Cavalo.tag == "Cavalo")
        {
            Destroy(Cavalo);
            Cavaloptns++;
        }
    }
    public void ClickCaconete()
    {
        if (Caconete.tag == "Caconete")
        {
            Destroy(Caconete);
            Caconeteptns++;
        }
    }
    public void ClickEstrela()
    {
        if (Estrela.tag == "Estrela")
        {
            Destroy(Estrela);
            Estrelaptns++;
        }
    }

    void Start()
    {
        txtBaleia.text = PlacarGame1.Baleiaptns.ToString();
        txtFoca.text = PlacarGame1.Focaptns.ToString();
        txtLeao.text = PlacarGame1.Leaoptns.ToString();
        txtOurico.text = PlacarGame1.Ouricoptns.ToString();
        txtTartaruga.text = PlacarGame1.Tartarugaptns.ToString();
    }
    void Update()
    {
        txtBoto.text = Botoptns.ToString();
        txtCavalo.text = Cavaloptns.ToString();
        txtCaconete.text = Caconeteptns.ToString();
        txtEstrela.text = Estrelaptns.ToString();
        txtLontra.text = Lontraptns.ToString();
        txtPepino.text = Pepinoptns.ToString();

        if ((Botoptns == 2) && (Cavaloptns == 2) && (PlacarGame1.Focaptns == 2) && (Lontraptns == 2) && (Pepinoptns == 2) && (PlacarGame1.Tartarugaptns == 2) && (Caconeteptns == 2) && (Estrelaptns == 2) && (PlacarGame1.Leaoptns == 2) && (PlacarGame1.Ouricoptns == 2) && (PlacarGame1.Baleiaptns == 2))
        {
            SceneManager.LoadSceneAsync(7);
        }
    }
}
