using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject falaA;
    public GameObject falaB;

    public void ApertouBtnA()
    {
        falaA.SetActive(false);
        falaB.SetActive(true);
    }
    public void ApertouBtnB()
    {
        SceneManager.LoadSceneAsync(3);
    }
}
