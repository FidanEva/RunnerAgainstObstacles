using UnityEngine;

namespace RunnerAgainstObstacle.Scripts
{
    public class GroundTile : MonoBehaviour
    {

        GroundSpawner groundSpawner;
        [SerializeField] GameObject obstaclePrefab;

        private void Start()
        {
            groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        }

        private void OnTriggerExit(Collider other)
        {
            groundSpawner.SpawnTile(true);
            Destroy(gameObject, 2);
        }

        public void SpawnObstacle()
        {
            // Choose a random point to spawn the obstacle
            int obstacleSpawnIndex = Random.Range(2, 5);
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

            // Spawn the obstace at the position
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}