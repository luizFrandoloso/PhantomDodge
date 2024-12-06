using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManeger : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelSobre;

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirSobre()
    {
        painelMenuInicial.SetActive(false);
        painelSobre.SetActive(true);
    }

    public void FecharSobre()
    {
        painelSobre.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
