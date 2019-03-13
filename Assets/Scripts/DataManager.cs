using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DataManager : MonoBehaviour {

    public static DataManager instance;

    public int PlayHP = 0;
    public int PlayLv = 0;
    public int Gold = 0;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
        LoadDB();
        InitPlay();
    }

    /// <summary>
    /// 第一次进入游戏初始化数据
    /// </summary>
    private void InitPlay()
    {
        if (PlayerPrefs.GetInt("FirstGame", 0) == 1)
        {
            return;
        }



        PlayerPrefs.SetInt("FirstGame", 1);

    }




    private void LoadDB()
    {
        
    }


 
   
}
