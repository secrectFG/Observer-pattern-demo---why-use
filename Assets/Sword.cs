using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Character owner;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.OnDamageTaken(owner, collision.GetComponent<Character>());

        //var other = collision.GetComponent<Character>();
        
        //if (other != null && other != owner)
        //{
        //    other.HP.Value -= owner.Attack.Value;

        //    //if(GameManager.Instance.PlayerInfoPanelInstance != null && other.name == "Player")
        //    //{
        //    //    GameManager.Instance.PlayerInfoPanelInstance.UpdateInfo(other);
        //    //}

        //    if(other.HP.Value <= 0)
        //    {
        //        owner.EXP.Value += 10;
        //        Destroy(other.gameObject);
        //        //if (GameManager.Instance.PlayerInfoPanelInstance != null && owner.name == "Player")
        //        //{
        //        //    GameManager.Instance.PlayerInfoPanelInstance.UpdateInfo(owner);
        //        //}
        //    }
        //}
    }
}
