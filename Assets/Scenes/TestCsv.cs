using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using csvutility;

public class TestCsv : MonoBehaviour
{
    public TextAsset m_textMasterEnemy;
    public TextAsset m_textMasterPlayer;

    void Start()
    {
        MasterPlayer player = new MasterPlayer();
        player.Load(m_textMasterPlayer);
        foreach( MasterPlayerParam p in player.list)
        {
            Debug.Log(string.Format("{0}:{1} HP={2}",
                p.player_id,
                p.player_name,
                p.hp));
        }



        /*
        MasterEnemy enemy = new MasterEnemy();
        enemy.Load(m_textMasterEnemy);
        foreach(MasterEnemyParam p in enemy.list)
        {
            Debug.Log(string.Format("{0}:{1}", p.enemy_id, p.name));
        }
        */



    }
}
