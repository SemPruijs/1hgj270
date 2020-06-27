using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject inGame;
    public GameObject playAgain;
    public GameObject credit;

    public Text collectedMoneyText;
    public Text timerText;
    
    void Update()
    {
        menu.SetActive(GameManager.Instance.state == GameManager.State.Menu);
        inGame.SetActive(GameManager.Instance.state == GameManager.State.InGame);
        playAgain.SetActive(GameManager.Instance.state == GameManager.State.PlayAgain);
        credit.SetActive(GameManager.Instance.state == GameManager.State.Credit);
        collectedMoneyText.text = GameManager.Instance.moneyCollected.ToString();
        timerText.text = GameManager.Instance.timer.ToString("F0");
    }
}
