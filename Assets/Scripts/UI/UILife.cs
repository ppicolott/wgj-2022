using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILife : MonoBehaviour
{
    public Sprite lifeSeventyFive;
    public Sprite lifeFifty;
    public Sprite lifeTwentyFive;
    public Sprite lifeZero;

    private void Update()
    {
        switch (Duck.life)
        {
            case 75:
                GetComponent<SpriteRenderer>().sprite = lifeSeventyFive;
                break;
            case 50:
                GetComponent<SpriteRenderer>().sprite = lifeFifty;
                break;
            case 25:
                GetComponent<SpriteRenderer>().sprite = lifeTwentyFive;
                break;
            case 0:
                GetComponent<SpriteRenderer>().sprite = lifeZero;
                GetComponent<SpriteRenderer>().color = new Color32(0, 0, 0, 0);
                break;
        }
    }
}
