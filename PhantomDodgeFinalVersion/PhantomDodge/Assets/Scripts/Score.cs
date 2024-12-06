using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;
    public int highScore;
    public Text scoreDisplay;
    public Text highScoreDisplay;

    private void Start()
    {
        // Carrega a pontuação máxima salva ao iniciar
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreDisplay();
    }

    private void Update()
    {
        scoreDisplay.text = "Pontuação: " + score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!Player.isAlive) return; // Não conta pontos se o jogador estiver morto

        score++;
        Destroy(other.gameObject);

        // Atualiza a pontuação máxima se a pontuação atual for maior
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore); // Salva a nova pontuação máxima
            UpdateHighScoreDisplay();
        }
    }

    private void UpdateHighScoreDisplay()
    {
        highScoreDisplay.text = "High Score: " + highScore.ToString();
    }
}
