using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeManager : MonoBehaviour
{
    public Upgrades Upgrade;
    public Controller controller;

    public double gemBaseCost;
    public double gemMult;
  
    public double clickUpgradeBaseCost;
    public double clickUpgradeMult;
    public double autoUpgradeBaseCost1;
    public double autoUpgradeMult1;
    public double autoUpgradeBaseCost2;
    public double autoUpgradeMult2;
    public double autoUpgradeBaseCost3;
    public double autoUpgradeMult3;
    public double autoUpgradeBaseCost4;
    public double autoUpgradeMult4;
    public double autoUpgradeBaseCost5;
    public double autoUpgradeMult5;

    private void Awake()
    {
        //PlayerPrefs.DeleteAll();
        saveLoad.load();
    }
    public void Update()
    {
        Data.o2perSecond = Data.autoUpgradeLevelX1 + Data.autoUpgradeLevelX2+ Data.autoUpgradeLevelX3+ Data.autoUpgradeLevelX4+ Data.autoUpgradeLevelX5;
        Data.o2 += Data.o2perSecond*Time.deltaTime; 
        Upgrade.o2perSecondText.text = "o2/s: " + Data.o2perSecond;
        PlayerPrefs.SetInt("currento2", (int)Data.o2);
        saveLoad.save();
    }

    public void startManager()
    {
        clickUpgradeBaseCost = 10;      
        clickUpgradeMult = 1.2;
        autoUpgradeBaseCost1 = 100;
        autoUpgradeMult1 = 1.1;
        autoUpgradeBaseCost2 = 500;
        autoUpgradeMult2 = 1.04;
        autoUpgradeBaseCost3 = 2500;
        autoUpgradeMult3 = 1.02;
        autoUpgradeBaseCost4 = 5000;
        autoUpgradeMult4 = 1.01;
        autoUpgradeBaseCost5 = 7500;
        autoUpgradeMult5 = 1.003;

        gemBaseCost = 100;
        gemMult = 2;
        updateUpgrade();
    }
    public void updateUpgrade()
    {
        Upgrade.clickUpgradeCostText.text = "Gereken: " + (int)clickCost() + " o2";
        Upgrade.clickUpgradeLevelText.text = Data.clickUpgradeLevel.ToString()+" Level";
        Upgrade.clickUpgradePowerText.text = "Tıklama basina o2: " + Data.clickUpgradeLevel + " (+1)";

        Upgrade.autoUpgradeCostText1.text = "Gereken: " + (int)autoCost1() + " o2";
        Upgrade.autoUpgradeLevelText1.text = Data.autoUpgradeLevel1.ToString() + " Level";
        Upgrade.autoUpgarde1o2sText.text = "O2/s: " + Data.autoUpgradeLevelX1 + " (+5)";

        Upgrade.autoUpgradeCostText2.text = "Gereken: " + (int)autoCost2() + " o2";
        Upgrade.autoUpgradeLevelText2.text = Data.autoUpgradeLevel2.ToString() + " Level";
        Upgrade.autoUpgarde2o2sText.text = "O2/s: " + Data.autoUpgradeLevelX2 + " (+25)";

        Upgrade.autoUpgradeCostText3.text = "Gereken: " + (int)autoCost3() + " o2";
        Upgrade.autoUpgradeLevelText3.text = Data.autoUpgradeLevel3.ToString() + " Level";
        Upgrade.autoUpgarde3o2sText.text = "O2/s: " + Data.autoUpgradeLevelX3 + " (+25)";

        Upgrade.autoUpgradeCostText4.text = "Gereken: " + (int)autoCost4() + " o2";
        Upgrade.autoUpgradeLevelText4.text = Data.autoUpgradeLevel4.ToString() + " Level";
        Upgrade.autoUpgarde4o2sText.text = "O2/s: " + Data.autoUpgradeLevelX4 + "(+100)";

        Upgrade.autoUpgradeCostText5.text = "Gereken: " + (int)autoCost5() + " o2";
        Upgrade.autoUpgradeLevelText5.text = Data.autoUpgradeLevel5.ToString() + " Level";
        Upgrade.autoUpgarde5o2sText.text = "O2/s: " + Data.autoUpgradeLevelX5 + " (+1000)";
    }
    public double clickCost()
    {
        return clickUpgradeBaseCost * Mathf.Pow((float)clickUpgradeMult, (float)Data.clickUpgradeLevel);
    }
    public double autoCost1()
    {
        return autoUpgradeBaseCost1 * Mathf.Pow((float)autoUpgradeMult1, (float)Data.autoUpgradeLevel1);
    }
    public double autoCost2()
    {
        return autoUpgradeBaseCost2 * Mathf.Pow((float)autoUpgradeMult2, (float)Data.autoUpgradeLevelX2);
    }
    public double autoCost3()
    {
        return autoUpgradeBaseCost3 * Mathf.Pow((float)autoUpgradeMult3, (float)Data.autoUpgradeLevelX3);
    }
    public double autoCost4()
    {
        return autoUpgradeBaseCost4 * Mathf.Pow((float)autoUpgradeMult4, (float)Data.autoUpgradeLevelX4);
    }
    public double autoCost5()
    {
        return autoUpgradeBaseCost5 * Mathf.Pow((float)autoUpgradeMult5, (float)Data.autoUpgradeLevelX5);
    }

    public void buyClickUpgrade()
    {
       if(Data.o2 >= clickCost())
        {
            Data.o2 -= clickCost();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.clickUpgradeLevel++;
            PlayerPrefs.SetInt("clickUpgradeLevel", (int)Data.clickUpgradeLevel);
        }
        updateUpgrade();
    }

    public void buyAutoUpgrade()
    {
        if(Data.o2 >= autoCost1())
        {
            Data.o2 -= autoCost1();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.autoUpgradeLevel1++;
            PlayerPrefs.SetInt("autoUpgradeLevel1", (int)Data.autoUpgradeLevel1);
            Data.autoUpgradeLevelX1+=5;
            PlayerPrefs.SetInt("autoUpgradeLevelX1", (int)Data.autoUpgradeLevelX1);
        }
        updateUpgrade();
    }
    public void buyAutoUpgrade2()
    {
        if (Data.o2 >= autoCost2())
        {
            Data.o2 -= autoCost2();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.autoUpgradeLevel2++;
            PlayerPrefs.SetInt("autoUpgradeLevel2", (int)Data.autoUpgradeLevel2);
            Data.autoUpgradeLevelX2 += 25;          
            PlayerPrefs.SetInt("autoUpgradeLevelX2", (int)Data.autoUpgradeLevelX2);
        }
        updateUpgrade();
    }
    public void buyAutoUpgrade3()
    {
        if (Data.o2 >= autoCost3())
        {
            Data.o2 -= autoCost3();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.autoUpgradeLevel3++;
            PlayerPrefs.SetInt("autoUpgradeLevel3", (int)Data.autoUpgradeLevel3);
            Data.autoUpgradeLevelX3 += 50;           
            PlayerPrefs.SetInt("autoUpgradeLevelX3", (int)Data.autoUpgradeLevelX3);
        }
        updateUpgrade();
    }
    public void buyAutoUpgrade4()
    {
        if (Data.o2 >= autoCost4())
        {
            Data.o2 -= autoCost4();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.autoUpgradeLevel4++;
            PlayerPrefs.SetInt("autoUpgradeLevel4", (int)Data.autoUpgradeLevel4);
            Data.autoUpgradeLevelX4 += 100;
            PlayerPrefs.SetInt("autoUpgradeLevelX4", (int)Data.autoUpgradeLevelX4);
        }
        updateUpgrade();
    }
    public void buyAutoUpgrade5()
    {
        if (Data.o2 >= autoCost5())
        {
            Data.o2 -= autoCost5();
            PlayerPrefs.SetInt("currento2", (int)Data.o2);
            Data.autoUpgradeLevel5++;
            PlayerPrefs.SetInt("autoUpgradeLevel5", (int)Data.autoUpgradeLevel5);
            Data.autoUpgradeLevelX5 += 1000;          
            PlayerPrefs.SetInt("autoUpgradeLevelX5", (int)Data.autoUpgradeLevelX5);
        }
        updateUpgrade();
    }




}
