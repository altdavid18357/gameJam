using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerLogicManager : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject GameOverScreen;
    private float Timer = 0f;
    private bool isAlive = true;
    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 1f && isAlive)
        {
            PlayerScore += 1;
            Timer = 0f;

            scoreText.text = PlayerScore.ToString();
        }

    }

    public void restartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void GameOver()
    {
        isAlive = false;
        GameOverScreen.SetActive(true);
    }
}