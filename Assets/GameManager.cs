using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverUI;
    public TextMeshProUGUI Score_Text, Game_Over_Score;
    private float score;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverUI.SetActive(true);
            Score_Text.gameObject.SetActive(false);
        }
        else if (GameObject.FindGameObjectWithTag("Player")!=null)
        {
            score += 1 * Time.deltaTime;
            Score_Text.text = ((int)score).ToString();
            Game_Over_Score.text = ((int)score).ToString();
        }
    }


    public void ReloadScene()
    {
        SceneManager.LoadScene("Virus run");
    }
}
