using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //[SerializeField] float waveCount;
    [SerializeField] float currentWaveCount;
    [SerializeField] List<GateWaveSO> WaveConfigs;
    GateWaveSO currentWave;

    [SerializeField] bool check;
    // Start is called before the first frame update
    void Start()
    {
        currentWaveCount = 1;
        StartCoroutine(SpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            check = true;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            check = false;
        }
    }

    IEnumerator SpawnEnemy()
    {
        yield return null;
        do
        {
            foreach (GateWaveSO wave in WaveConfigs)
            {
                currentWave = wave;
                for (int i = 0; i < currentWave.GetEnemyTypeCount(); i++)
                {
                    var enemyPrefab = currentWave.GetEnemyTypeByIndex(i);
                    var countEnemy = currentWave.GetEnemyCountByIndex(i);
                    var time = currentWave.GetTimeSpawnEnemyByIndex(i);

                    StartCoroutine(Sp(enemyPrefab, countEnemy, time));

                    yield return new WaitUntil(() => check);
                    check = false;
                    currentWaveCount++;

                }
            }
        } while (true);
    }

    IEnumerator Sp(GameObject enemyPrefab, float countT ,float countE, float time)
    {
        yield return null;
        if (countT != 1)
        {
            for(int k=0; k<countT; k++)
            {
                for(int l = 0; l<currentWave.GetEnemyCountByIndex(l); l++)
                {

                }
            }
        }
        else
        {
            for (int j = 0; j < countE; j++)
            {
                Instantiate(enemyPrefab, this.transform);
                yield return new WaitForSeconds(time);
            }
        }
    }
}
