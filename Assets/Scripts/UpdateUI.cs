using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    public Text PlayerNameText;

    //Called before first frame update
    public void Start()
    {
        PlayerNameText.text = GameManager.Instance.PlayerName;
    }
}
