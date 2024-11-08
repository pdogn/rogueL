using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Wave config", fileName = "New Wave config")]
public class GateWaveSO : ScriptableObject
{
    [SerializeField] List<GameObject> enemyTypes;

    [SerializeField] List<int> enemyCount;

    [SerializeField] List<int> timeSpawnEnemy;

    //lấy số loại quái trong wave
    public int GetEnemyTypeCount()
    {
        return enemyTypes.Count;
    }

    //lấy loại enemy theo index
    public GameObject GetEnemyTypeByIndex(int index)
    {
        return enemyTypes[index];
    }

    //lấy số lượng quái trong wave
    public int GetEnemyCountByIndex(int index)
    {
        return enemyCount[index];
    }

    //lấy thời gian spawn enemy của loại quái theo index
    public int GetTimeSpawnEnemyByIndex(int index)
    {
        return timeSpawnEnemy[index];
    }
}
