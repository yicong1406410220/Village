using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    public static Enemy instance;

    /// <summary>
    /// 所在位置
    /// </summary>
    public int Seat = 14;

    //护甲
    public int Armor = 0;

    public int Life = 10;

    private void Awake()
    {
        instance = this;
    }

    //被攻击
    public void BeAttacked(int value)
    {
        if (Seat == 14)
        {
            value = 2 * value;
        }

        if (value > 0)
        {
            int num = Armor - value;
            if (num > 0)
            {
                Armor = num;
            }
            else
            {
                BeHurt(num);
            }
        }
        else
        {
            BeHurt(value);
        }
    }

    //受伤被击退
    private void BeHurt(int num)
    {
        Life = Life - num;
        if (Life <= 0)
        {
            Debug.Log("英雄赢了");
        }
        BeMove(num);
    }

    //做移动
    private void BeMove(int backward)
    {
        //能够后退的步数
        int spacing = 14 - Seat;
        //后退超过的步数
        int number = backward - spacing;
        if (number >= 0)
        {
            GetComponent<RectTransform>().DOMove(new Vector2(GameCavas.instance.ConfPlayer[14].position.x, GameCavas.instance.ConfPlayer[14].position.y), spacing * 1f);
        }
        else
        {
            GetComponent<RectTransform>().DOMove(new Vector2(GameCavas.instance.ConfPlayer[14 + number].position.x, GameCavas.instance.ConfPlayer[14 + number].position.y), backward * 1f);
        }
    }

    /// <summary>
    /// 添加生命
    /// </summary>
    public void AddLive(int value)
    {
        Life += value;
    }

    /// <summary>
    /// 添加护盾
    /// </summary>
    public void AddArmor(int value)
    {
        Armor += value;
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
