﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour {

    private float D01 = 1f;
    float d04 = 5f;
    float d06 = 7f;
    float d08 = 9f;
    float d10 = 11f;
    float d12 = 13f;
    float d20 = 21f;
    public int D04 { get { return Mathf.RoundToInt(d04); } }
    public int D06 { get { return Mathf.RoundToInt(d06); } }
    public int D08 { get { return Mathf.RoundToInt(d08); } }
    public int D10 { get { return Mathf.RoundToInt(d10); } }
    public int D12 { get { return Mathf.RoundToInt(d12); } }
    public int D20 { get { return Mathf.RoundToInt(d20); } }
        
    public List<int> RollXDices(int diceAmount, int diceQuality){
        List<int> rollResult = new List<int>();
        for (int i = 0; i < diceAmount; i++) {
            rollResult.Add(GiveRandomNumber(diceQuality));
        }
        return rollResult;
    }

    public int GiveRandomNumber(float diceQuality) {
        return Mathf.FloorToInt(Random.Range(D01, diceQuality));
    }
    
    void Update () {
		
	}
}