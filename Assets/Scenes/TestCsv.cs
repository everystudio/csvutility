using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using csvutility;

public class TestCsv : MonoBehaviour
{
    public TextAsset m_textMasterEnemy;

    void Start()
    {
        MasterEnemy enemy = new MasterEnemy();
        enemy.Load(m_textMasterEnemy);

        foreach(MasterEnemyParam p in enemy.list)
        {
            Debug.Log(string.Format("{0}:{1}", p.enemy_id, p.name));
        }
    }
}
