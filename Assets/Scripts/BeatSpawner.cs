using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSpawner : MonoBehaviour
{
        public Transform[] spawnPoints;
       // public int delayFor = 60;
        public Transform prefab;
        public float sampleRate = 0.6f;
        float currentTime = 0f;
        public int bpm = 155;
        public GameObject bp;

    /// <summary>
    /// This code basically uses a bpm to instantiate a beat into the scene. 
    /// </summary>

    private void Start()
    {
        currentTime = Time.time;
        sampleRate = 60f / bpm;    // bpm to beats per second 
        bp = GameObject.Find("Spawner");
        StartCoroutine(StartAfterTime());
        StartCoroutine(ExecuteAfterTime());
    }

    private void Update()
        
        {
        if (Time.time - currentTime > sampleRate)
        {
            // random returns a float
            int index = (int)Random.Range(0, (float)spawnPoints.Length);
            Transform spawnPoint = spawnPoints[index];
            // Instantiate(prefab, spawnPoint.position, Quaternion.identity);
            GameObject prefab = ObjectPool.SharedInstance.GetPooledObject();
            if(prefab != null)
            {
                prefab.transform.position = spawnPoint.position;
                prefab.SetActive(true);
            }
            currentTime = Time.time;
        }

          //  if (Time.frameCount % delayFor == 0)
          //  {
          //       random returns a float
          //      int index = (int)Random.Range(0, (float)spawnPoints.Length);
          //      Transform spawnPoint = spawnPoints[index];
          //      Instantiate(prefab, spawnPoint.position, Quaternion.identity);
          // }
        }

    /// <summary>
    /// these 2 add delays to the spawner to help match the song. The spawner starts at 0 and then sets the sample rate after the set time.
    /// I tried to get it to update the bpm value but the bpm value wont change sample rate during playtime. 
    /// </summary>
    /// <returns></returns>
    IEnumerator StartAfterTime()
    {
        yield return new WaitForSeconds(1.8f);
        bp.GetComponent<BeatSpawner>().sampleRate = 0.8f;
    }
    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(29f);

        bp.GetComponent<BeatSpawner>().sampleRate = 0.3870968f;
    }
    
}
