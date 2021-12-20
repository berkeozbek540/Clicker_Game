using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveLoad : MonoBehaviour
{
    //public skillTree skillTree;
    public static void save()
    {
        PlayerPrefs.SetInt("currento2", (int)Data.o2);
        PlayerPrefs.SetInt("o2persec", (int)Data.o2perSecond);
        PlayerPrefs.SetInt("currentGems", skillTree.currentGems);
        PlayerPrefs.SetInt("boughtGems", skillTree.boughtGems);
        PlayerPrefs.SetInt("skill1Level", (int)skillTree.skill1Level);
        PlayerPrefs.SetInt("clickUpgradeLevel", (int)Data.clickUpgradeLevel);
        PlayerPrefs.SetInt("autoUpgradeLevel1", (int)Data.autoUpgradeLevel1);
        PlayerPrefs.SetInt("autoUpgradeLevelX1", (int)Data.autoUpgradeLevelX1);
        PlayerPrefs.SetInt("autoUpgradeLevel2", (int)Data.autoUpgradeLevel2);
        PlayerPrefs.SetInt("autoUpgradeLevelX2", (int)Data.autoUpgradeLevelX2);
        PlayerPrefs.SetInt("autoUpgradeLevel3", (int)Data.autoUpgradeLevel3);
        PlayerPrefs.SetInt("autoUpgradeLevelX3", (int)Data.autoUpgradeLevelX3);
        PlayerPrefs.SetInt("autoUpgradeLevel4", (int)Data.autoUpgradeLevel4);
        PlayerPrefs.SetInt("autoUpgradeLevelX4", (int)Data.autoUpgradeLevelX4);
        PlayerPrefs.SetInt("autoUpgradeLevel5", (int)Data.autoUpgradeLevel5);
        PlayerPrefs.SetInt("autoUpgradeLevelX5", (int)Data.autoUpgradeLevelX5);
      
    }
    public static void load()
    {
        Data.o2 = PlayerPrefs.GetInt("currento2", 0);
        Data.o2perSecond = PlayerPrefs.GetInt("o2persec", 0);
        skillTree.currentGems = PlayerPrefs.GetInt("currentGems", 0);
        skillTree.boughtGems = PlayerPrefs.GetInt("boughtGems", 0);
        skillTree.skill1Level = PlayerPrefs.GetInt("skill1Level", 1);
        Data.clickUpgradeLevel = PlayerPrefs.GetInt("clickUpgradeLevel", 0);
        Data.autoUpgradeLevel1 = PlayerPrefs.GetInt("autoUpgradeLevel1", 0);
        Data.autoUpgradeLevelX1 = PlayerPrefs.GetInt("autoUpgradeLevelX1", 0);
        Data.autoUpgradeLevel2 = PlayerPrefs.GetInt("autoUpgradeLevel2", 0);
        Data.autoUpgradeLevelX2 = PlayerPrefs.GetInt("autoUpgradeLevelX2", 0);
        Data.autoUpgradeLevel3 = PlayerPrefs.GetInt("autoUpgradeLevel3", 0);
        Data.autoUpgradeLevelX3 = PlayerPrefs.GetInt("autoUpgradeLevelX3", 0);
        Data.autoUpgradeLevel4 = PlayerPrefs.GetInt("autoUpgradeLevel4", 0);
        Data.autoUpgradeLevelX4 = PlayerPrefs.GetInt("autoUpgradeLevelX4", 0);
        Data.autoUpgradeLevel5 = PlayerPrefs.GetInt("autoUpgradeLevel5", 0);
        Data.autoUpgradeLevelX5 = PlayerPrefs.GetInt("autoUpgradeLevelX5", 0);

    }
}
