using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
    public float secondsToSpawn;
    public GameObject prefabToSpawn;

    public static int itemsSpawned = 0;
    private void Start() {
        StartCoroutine(SpawnPrefabEverySecond());
    }

    private IEnumerator SpawnPrefabEverySecond() {
        while (true) {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);

            itemsSpawned++;
            yield return new WaitForSeconds(secondsToSpawn);
        }
    }
}