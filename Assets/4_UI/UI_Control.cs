using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UI_Control : MonoBehaviour
{
    private float coins = 0;
    private float gems = 0;
    private bool bought = false;

    public float coinsLimit = 99999;
    public float gemsLimit = 99999;

    public TextMeshProUGUI tcoins = null;
    public TextMeshProUGUI tgems = null;

    public void Start()
    {
        if(tcoins != null)
        tcoins.text = coins.ToString();

        if(tgems != null)
        tgems.text = coins.ToString();
    }

    public void GemsDecrease(float cost)
    {

        if (gems >= cost && coins<coinsLimit)
        {
            gems -= cost;
            bought = true;
        }            

        tgems.text = gems.ToString();
    }

    public void CoinsDecrease(float cost)
    {

        if (coins >= cost)
            coins -= cost;

        tcoins.text = coins.ToString();
    }

    public void CoinAddButton(float value)
    {       

        if(coins<coinsLimit && bought == true)
        {
            coins += value;

            if (coins >= coinsLimit)
                coins = coinsLimit;

            bought = false;
        }      

        tcoins.text = coins.ToString();
    }

    public void GemsAddButton(float value)
    {
        if (gems < gemsLimit)
            gems += value;

        tgems.text = gems.ToString();
    }

    public void SceneLoad_0_intro()
    {
        SceneManager.LoadScene(0);

    }

    public void SceneLoad_1_Scenario()
    {
        SceneManager.LoadScene(1);

    }

    public void SceneLoad_2_VFX()
    {
        SceneManager.LoadScene(2);

    }

    public void SceneLoad_3_UI()
    {
        SceneManager.LoadScene(3);

    }

    public void APPQuit()
    {

        Application.Quit();
    }

}
