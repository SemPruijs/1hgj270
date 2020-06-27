using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int moneyCollected = 0;
    public float timer = 30f;
    public GameObject player;
    
    public State state;
    private static GameManager _instance;
         public static GameManager Instance {
         get {
             return _instance;
         }
    }
    private void Awake()
    {
         if (_instance != null && _instance != this)
         {
            Destroy(this.gameObject);
         } else {
            _instance = this;
         } 
    }

    public enum State
    {
        InGame,
        Menu,
        PlayAgain,
        Credit
    };

    void Start()
    {
        Menu();
    }

    private void Update()
    {
        if (state == State.InGame)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                state = State.PlayAgain;
            }
        }
    }

    public void Menu()
    {
        state = State.Menu;
    }

    public void InGame()
    {
        state = State.InGame;
        timer = 30f;
    }

    public void Credit()
    {
        state = State.Credit;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
