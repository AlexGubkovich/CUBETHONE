using UnityEngine;
using System.Collections.Generic;

public class ObstaclePlacer : MonoBehaviour
{
   public Transform Player;
   public Obstacle[] ObstaclePrefabs;
   public Obstacle FirstObstacle;
   public List<Obstacle> spawnedObstacle = new List<Obstacle>();
   void Start(){
       spawnedObstacle.Add(FirstObstacle); 
       SpawnObstacle();  
   }
   void Update(){
       if(Player.position.z > spawnedObstacle[spawnedObstacle.Count-1].End.localPosition.z){
            SpawnObstacle();
            Debug.Log("yes");
       }
       Debug.Log("----");
   }

   private void SpawnObstacle(){
       Obstacle newObstacle = Instantiate(ObstaclePrefabs[Random.Range(0,ObstaclePrefabs.Length)]);
        newObstacle.transform.position = spawnedObstacle[spawnedObstacle.Count-1].End.position - newObstacle.Begin.localPosition;
       spawnedObstacle.Add(newObstacle);
   }
}
