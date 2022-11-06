using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginMenuController : MonoBehaviour {
    public GameObject LoginScreen;
    public TMP_InputField LoginField;
    public TMP_InputField PasswordField;
    public Button LoginButton;

    public GameObject CoursesScreen;

    /// <summary>Obtém o usuário digitado.</summary>
    private string Login => this.LoginField.text.Trim();

    /// <summary>Obtém a senha digitada.</summary>
    private string Password => this.PasswordField.text.Trim();

    void Start()
    {
        this.UpdateLogin();
    }

    /// <summary>Atualiza a tela de login.</summary>
    public void UpdateLogin()
    {
        //this.LoginButton.interactable = (this.Login.Length > 0 && this.Password.Length > 0);
    }

    /// <summary>Realiza o login do usuário.</summary>
    public void DoLogin()
    {
        Debug.Log("Usuário: " + this.Login + " | Senha: " + this.Password);

        // Esconder tela de login e exibir tela de cursos.
        this.LoginScreen.SetActive(false);
        this.CoursesScreen.SetActive(true);
    }
}
