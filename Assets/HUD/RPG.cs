using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RPG : MonoBehaviour
{ 
    public float Score;
    public int CoinLvl;
    public int PowerLvl;
    public int HpLvl;
    public GameObject Enemy;

    string _coin;
    
    public TextMeshProUGUI Coin;

    public float[] BoostCoin = { 1f, 1.2f, 1.5f, 1.7f, 2f, 2.5f};

    void Start()
    {
        Score = 0;
        CoinLvl = 0;
        PowerLvl = 0;
        HpLvl = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _coin = Score.ToString();

        Coin.text= _coin;
    }
    private void OnDestroy()
    {
        if (Enemy.gameObject == null)
        {
            Score += 10;
        }
    }
    public void getMoney()
    {
        Score += BoostCoin[CoinLvl] * 10;
    }
}




