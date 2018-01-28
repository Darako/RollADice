﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateDices : MonoBehaviour {

    public int diceMaximumLimit = 6;

    public Button bDiceQuality;
    public Button bDiceAmount;
    public Image iDiceQuality;
    public Image iDiceAmount;

    private int diceAmount = 1;
    private int diceQuality;

    public List<Sprite> dices;
    public List<Sprite> numbers;


    NumberGenerator ng;

    void Start() {
        ng = gameObject.GetComponent<NumberGenerator>();
        diceQuality = ng.D04;
        bDiceAmount.onClick.AddListener(IncreaseDiceAmount);
        bDiceQuality.onClick.AddListener(IncreaseDiceQuality);
    }


    public void IncreaseDiceQuality() {
        if (ng.D04 == diceQuality) {
            diceQuality = ng.D06;
            iDiceQuality.sprite = dices[1];
        } else if (ng.D06 == diceQuality) {
            diceQuality = ng.D08;
            iDiceQuality.sprite = dices[2];
        } else if (ng.D08 == diceQuality) {
            diceQuality = ng.D10;
            iDiceQuality.sprite = dices[3];
        } else if (ng.D10 == diceQuality) {
            diceQuality = ng.D12;
            iDiceQuality.sprite = dices[4];
        } else if (ng.D12 == diceQuality) {
            diceQuality = ng.D20;
            iDiceQuality.sprite = dices[5];
        } else if (ng.D20 == diceQuality) {
            diceQuality = ng.D04;
            iDiceQuality.sprite = dices[0];
        }
    }

    public void IncreaseDiceAmount() {
        diceAmount++;
        if (diceAmount >= diceMaximumLimit){
            diceAmount = 1;
            return;
        }
        ChangeDiceAmountIcon();
    }

    private void ChangeDiceAmountIcon() {
        switch (diceAmount) {
            case 1: iDiceAmount.sprite = numbers[0]; break;
            case 2: iDiceAmount.sprite = numbers[1]; break;
            case 3: iDiceAmount.sprite = numbers[2]; break;
            case 4: iDiceAmount.sprite = numbers[3]; break;
            case 5: iDiceAmount.sprite = numbers[4]; break;
            case 6: iDiceAmount.sprite = numbers[5]; break;
        }
    }


}
