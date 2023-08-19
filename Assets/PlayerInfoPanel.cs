using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInfoPanel : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI expText;

    private Character player;

    private void Start()
    {
        //正式里面不要这么写，这里只是为了方便演示
        player = GameObject.Find("Player").GetComponent<Character>();

        player.HP.OnValueChanged += OnHPChanged;
        player.EXP.OnValueChanged += OnEXPChanged;

        hpText.text = $"{player.HP.Value}";
        expText.text = $"{player.EXP.Value}";
    }

    private void OnHPChanged(int oldValue, int newValue)
    {
        hpText.text = $"{newValue}";
    }

    private void OnEXPChanged(int oldValue, int newValue)
    {
        expText.text = $"{newValue}";
    }

    //public void UpdateInfo(Character character)
    //{
    //    hpText.text = $"{character.HP.Value}";
    //    expText.text = $"{character.EXP.Value}";
    //}

    private void OnDestroy()
    {
        player.HP.OnValueChanged -= OnHPChanged;
        player.EXP.OnValueChanged -= OnEXPChanged;
    }

    public void OnClose()
    {
        Destroy(gameObject);
    }
}
