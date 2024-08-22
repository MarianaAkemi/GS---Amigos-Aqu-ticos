using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dialogos : MonoBehaviour
{
    public AudioSource audio;
    private void Awake()
    {
        DontDestroyOnLoad(audio);
    }
    public void PlayDialogos()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public GameObject fala1;
    public GameObject fala2;
    public GameObject fala3;


    public void ApertouBtn1()
    {
        fala1.SetActive(false);
        fala2.SetActive(true);
    }
    public void ApertouBtn2()
    {
        fala2.SetActive(false);
        fala3.SetActive(true);
    }
    public void ApertouBtn3()
    {
        SceneManager.LoadSceneAsync(8);
    }
}
