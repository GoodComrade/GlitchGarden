using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackedPrefabArray;

	
	
	// Update is called once per frame
	void Update ()
    {
	    foreach (GameObject thisAttacker in attackedPrefabArray)
        {
            if (isTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
	}

    void Spawn (GameObject myGameObject)
    {
        GameObject myAttackeer = Instantiate(myGameObject) as GameObject;
        myAttackeer.transform.parent = transform;
        myAttackeer.transform.position = transform.position;
    }

    bool isTimeToSpawn(GameObject attackerGameObject)
    {
        Attacker attacker = attackerGameObject.GetComponent<Attacker>();

        float meanSpawnDelay = attacker.seenEverySeconds;
        float spawnsPerSecond = 1 / meanSpawnDelay;
        
        if (Time.deltaTime > meanSpawnDelay)
        {

        }

        float threshold = spawnsPerSecond * Time.deltaTime / 5;

        return (Random.value < threshold);
    }
}
