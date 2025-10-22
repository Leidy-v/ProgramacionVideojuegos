using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float timeLimit = 10f;
    public Text timerText;
    public GameObject winPanel;
    public GameObject losePanel;

    private float timer;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        timer = timeLimit;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F1");

        if (timer <= 0)
        {
            LoseGame();
        }
    }

    public void WinGame()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void LoseGame()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0;
    }
}
