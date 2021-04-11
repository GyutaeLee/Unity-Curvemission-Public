﻿using UnityEngine;

public class SPRItemManager : MonoBehaviour
{
    public class ItemInformation
    {
        public int coinQuantity;
    }

    public ItemInformation info;

    private void Awake()
    {
        this.info = new ItemInformation();
    }

    public void SetCoin(int coinQuantity)
    {
        this.info.coinQuantity = coinQuantity;
    }

    public void AddCoin(int coinQuantity)
    {
        this.info.coinQuantity += coinQuantity;
    }
}
