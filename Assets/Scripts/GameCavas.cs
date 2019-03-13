using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameCavas : MonoBehaviour {


    public RectTransform[] ConfPlayer;
    public RectTransform PlayerTF;

    public bool IsPlayAnimation = false;

    public FloorType[] floorTypes = new FloorType[15];

    public static GameCavas instance;

    private void Awake()
    {
        instance = this;
        //地板初始化
        for (int i = 0; i < floorTypes.Length; i++)
        {
            floorTypes[i] = FloorType.Null;
        }
        RangeFloor(FloorType.Addlive);
        RangeFloor(FloorType.Combo);
        RangeFloor(FloorType.Gold);
        RangeFloor(FloorType.OnceMore);
        RangeFloor(FloorType.StickTo);
    }

    private void RangeFloor(FloorType floorType)
    {
        while (true)
        {
            int num = Random.Range(1, floorTypes.Length - 1);
            if (floorTypes[num] == FloorType.Null)
            {
                floorTypes[num] = floorType;
                break;
            }
        }
    }

    // Use this for initialization
    void Start () {
        

    }


	
	// Update is called once per frame
	void Update () {
		
	}
}
