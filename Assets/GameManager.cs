using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public PlayerInfoPanel PlayerInfoPanelInstance => playerInfoPanelInstance;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private PlayerInfoPanel playerInfoPanelPrefab;

    private PlayerInfoPanel playerInfoPanelInstance;

    private void Awake()
    {
        Instance = this;
    }

    public void OnOpenPlayerInfoPanel()
    {
        if (playerInfoPanelInstance == null)
        {
            playerInfoPanelInstance = Instantiate(playerInfoPanelPrefab);
            playerInfoPanelInstance.transform.SetParent(canvas.transform, false);
        }
        else
        {
            playerInfoPanelInstance.gameObject.SetActive(true);
        }
    }

    public void OnDamageTaken(Character instigator, Character affectedCharacter)
    {
        if (instigator == affectedCharacter) return; //自己不能伤害自己
        if (affectedCharacter != null)
        {
            affectedCharacter.HP.Value -= instigator.Attack.Value;
            if (affectedCharacter.HP.Value <= 0)
            {
                instigator.EXP.Value += 10;
                Destroy(affectedCharacter.gameObject);
            }
        }
    }
}
