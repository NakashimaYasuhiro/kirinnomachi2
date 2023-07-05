using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    //アイテムを受け取ったら画像を取得
    public void SetItem(Item item)
    {
        UpdateImage(item);
    }

    void UpdateImage(Item item) 
    {
        image.sprite = item.sprite;
    }




}
