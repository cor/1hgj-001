using UnityEngine;
using System.Collections;

public class ObstacleSpawnerController : MonoBehaviour {

    public GameObject obstacle;
    public float spawnRange = 40f;
    public float despawnDelay = 20f;
    public int spawnsPerUpdate = 10;

	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < spawnsPerUpdate; i++)
        {
            float randomX = Random.Range(-spawnRange, spawnRange);
	        float randomZ = Random.Range(-spawnRange, spawnRange);
       
            Vector3 obstaclePosition = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);
            GameObject spawnedObstacle = (GameObject)Instantiate(obstacle, obstaclePosition, transform.rotation);
            Destroy(spawnedObstacle, despawnDelay);
        }
       
       

    
	}
}
