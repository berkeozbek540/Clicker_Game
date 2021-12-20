using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skillTree : MonoBehaviour
{
    public UpgradeManager upgradeManager;
    public Controller controller;

    public static int boughtGems=1;
    public static int currentGems;
    public static int skill1Level = 1;

    public GameObject buyGem;
    public TMP_Text o2Text;
    public TMP_Text gemText;
    public TMP_Text gemCostText;
    public TMP_Text skill1LevelText;
    public TMP_Text skill1InfoText;

    private void Start()
    {
        buyGem.SetActive(false);
    }
    private void Update()
    {
        o2Text.text = Mathf.Round((float)Data.o2).ToString();
        gemText.text = currentGems.ToString();
        gemCostText.text = "Gereken: " + gemCost1X();
        skill1LevelText.text = "Seviye: " + skill1Level.ToString() + "/5";
        skill1InfoText.text = "Seviye başına 2 kat fazla tıklama (Şuan: " + skill1Level+ " kat fazla    tıklama.)";
    }

    public double gemCost1X()
    {
        return upgradeManager.gemBaseCost * Mathf.Pow((float)upgradeManager.gemMult, boughtGems) *200;
    }

    public void buyGem1X()
    {
        if(Data.o2 > gemCost1X())
        {
            Data.o2 -= gemCost1X();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            currentGems++;
            PlayerPrefs.SetInt("currentGems", currentGems);           
            boughtGems++;
            PlayerPrefs.SetInt("boughtGems", boughtGems);
        }
    }

    public void buySkill1()
    {
        while(skill1Level <= 4)
        {
            if (currentGems >= 1)
            {
                currentGems--;
                PlayerPrefs.SetInt("currentGems", currentGems);
                skill1Level++;
                PlayerPrefs.SetInt("skill1Level", (int)skill1Level);
            }
            break;
        }
        
    }


    public void openScreen()
    {
        buyGem.SetActive(true);
    }
    public void closeScreen()
    {
        buyGem.SetActive(false);
    }
}
