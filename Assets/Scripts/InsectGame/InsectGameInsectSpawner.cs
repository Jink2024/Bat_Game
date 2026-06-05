using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


public class InsectGameInsectSpawner : MonoBehaviour
{
    public GameObject Prefab;
    
    public float minimumSecondsToWait;
    public float maximumSecondsToWait;
    
    public bool isOkToCreate = true;
    public bool isActive = false;
    public Coroutine countdownCoroutine;
    
    public virtual void Update()
    {
        if (!isActive)
            return;
        if (isOkToCreate)
        {
            countdownCoroutine = StartCoroutine(CountdownUntilCreation());
        }
    }
    
    public void StartPlacing()
    {
        isActive = true;
        isOkToCreate = true;
    }
    
    public void StopPlacing()
    {
        isActive = false;
        isOkToCreate = false;
        
        if (countdownCoroutine != null)
            StopCoroutine(countdownCoroutine);

        CleanupPlacerObjects();
    }

    private void CleanupPlacerObjects()
    {
        List<GameObject> placedObjects = GameObject.FindGameObjectsWithTag(Prefab.tag).ToList();
        for (int i = 0; i < placedObjects.Count; i++)
        {
            Destroy(placedObjects[i]);
        }
    }

    public virtual IEnumerator CountdownUntilCreation()
    {
        isOkToCreate = false;
        
        float secondsToWait = Random.Range(minimumSecondsToWait, maximumSecondsToWait);
        yield return new WaitForSeconds(secondsToWait);
        Place();
        
        isOkToCreate = true;
    }

    public virtual void Place()
    {
        Instantiate(Prefab, SpawnTools.RandomLocationWorldSpace(), Quaternion.identity);
    }

    public void IncreaseSpawnRate()
    {
        minimumSecondsToWait -= 0.5f;
        if (minimumSecondsToWait < 0) minimumSecondsToWait = 0;
        maximumSecondsToWait -= 0.5f;
        if (maximumSecondsToWait < 0) maximumSecondsToWait = 0;
    }

    public void ResetSpawnRate()
    {
        minimumSecondsToWait = InsectGameGameParameters.InsectMinimumSecondsToWait;
        maximumSecondsToWait = InsectGameGameParameters.InsectMaximumSecondsToWait;
    }
}
