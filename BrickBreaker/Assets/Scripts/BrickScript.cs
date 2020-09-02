using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public int hitCounter = 1;
    public Material oneHitMaterial;
    public GameObject healthAbilityPrefab;

    private GameObject player;
    private PlayerScript playerScript;

    void Start()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerScript>();
    }

    public void RecieveHitCount(int hitCounter)
    {
        this.hitCounter = hitCounter;
    }

    private void SpawnHealthAbility()
    {
        int rand = Random.Range(0, 3);

        // Probability of 33% if real Random
        if (rand == 1)
        {
            GameObject healthGO = GameObject.Instantiate(healthAbilityPrefab, gameObject.transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ball")
            return;

        playerScript.score += 100;

        hitCounter--;
        if (hitCounter == 0)
        {
            gameObject.SetActive(false);
            playerScript.numberOfActiveBricks--;
        }
        else if (hitCounter == 1)
        {
            gameObject.GetComponent<Renderer>().material = oneHitMaterial;
        }

        SpawnHealthAbility();
    }
}
