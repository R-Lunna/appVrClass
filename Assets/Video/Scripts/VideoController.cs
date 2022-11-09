using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VideoController : MonoBehaviour {

    void Start()
    {
        this.UpdateLogin();
    }

    /// <summary>Atualiza a tela de login.</summary>
    public void UpdateLogin()
    {
        //this.LoginButton.interactable = (this.Login.Length > 0 && this.Password.Length > 0);
    }


    public void BackVideo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("mainMenu");
    }
}
