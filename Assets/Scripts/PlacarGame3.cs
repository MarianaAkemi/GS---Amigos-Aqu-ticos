using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlacarGame3 : MonoBehaviour
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

    public GameObject Estrela;
    public GameObject Leao;
    public GameObject Ourico;
    public GameObject Baleia;
    public GameObject Caconete;


    public void ClickEstrela()
    {
        if (Estrela.tag == "Estrela")
        {
            Destroy(Estrela);
            PlacarGame.Estrelaptns++;
        }
    }
    public void ClickLeao()
    {
        if (Leao.tag == "Leao")
        {
            Destroy(Leao);
            PlacarGame1.Leaoptns++;
        }
    }
    public void ClickOurico()
    {
        if (Ourico.tag == "Ourico")
        {
            Destroy(Ourico);
            PlacarGame1.Ouricoptns++;
        }
    }
    public void ClickBaleia()
    {
        if (Baleia.tag == "Baleia")
        {
            Destroy(Baleia);
            PlacarGame1.Baleiaptns++;
        }
    }
    public void ClickCaconete()
    {
        if (Caconete.tag == "Caconete")
        {
            Destroy(Caconete);
            PlacarGame.Caconeteptns++;
        }
    }

    void Start()
    {
        txtBoto.text = PlacarGame.Botoptns.ToString();
        txtCavalo.text = PlacarGame.Cavaloptns.ToString();
        txtFoca.text = PlacarGame1.Focaptns.ToString();
        txtLontra.text = PlacarGame.Lontraptns.ToString();
        txtPepino.text = PlacarGame.Pepinoptns.ToString();
        txtTartaruga.text = PlacarGame1.Tartarugaptns.ToString();
    }
    void Update()
    {
        txtCaconete.text = PlacarGame.Caconeteptns.ToString();
        txtEstrela.text = PlacarGame.Estrelaptns.ToString();
        txtLeao.text = PlacarGame1.Leaoptns.ToString();
        txtOurico.text = PlacarGame1.Ouricoptns.ToString();
        txtBaleia.text = PlacarGame1.Baleiaptns.ToString();

        if ((PlacarGame.Botoptns == 2) && (PlacarGame.Cavaloptns == 2) && (PlacarGame1.Focaptns == 2) && (PlacarGame.Lontraptns == 2) && (PlacarGame.Pepinoptns == 2) && (PlacarGame1.Tartarugaptns == 2) && (PlacarGame.Caconeteptns == 2) && (PlacarGame.Estrelaptns == 2) && (PlacarGame1.Leaoptns == 2) && (PlacarGame1.Ouricoptns == 2) && (PlacarGame1.Baleiaptns == 2))
        {
            SceneManager.LoadSceneAsync(7);
        }
    }
}
