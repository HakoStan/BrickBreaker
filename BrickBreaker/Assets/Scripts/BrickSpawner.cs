using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawner : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject floor;
    public GameObject celling;
    public GameObject leftWall;
    public GameObject rightWall;
    public GameObject frontWall;
    public GameObject backWall;
    public GameObject player;
    public float level=0;
    public int matrixScalar=4;
    public int yAxisDivider=2;
    public Material oneHitMaterial;
    public Material twoHitMaterial;

    private float diffX = 0f;
    private float diffY = 0f;
    private float diffZ = 0f;


    GameObject CreateBrick(Vector3 position, Vector3 brickScale, int hitCount)
    {
        Quaternion brickRotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

        GameObject brickGo = GameObject.Instantiate(brickPrefab, position, brickRotation);
        brickGo.transform.localScale = brickScale;
        brickGo.GetComponent<BrickScript>().RecieveHitCount(hitCount);
        
        if (hitCount == 1)
        {
            brickGo.GetComponent<Renderer>().material = oneHitMaterial;
        }
        else if (hitCount == 2)
        {
            brickGo.GetComponent<Renderer>().material = twoHitMaterial;
        }

        return brickGo;
    }

    // Start is called before the first frame update
    void Start()
    {
        diffX = (rightWall.transform.position.x - (0.5f * rightWall.transform.localScale.x) ) + (-1f * leftWall.transform.position.x - (0.5f * leftWall.transform.localScale.x) );
        diffY = (celling.transform.position.y - (0.5f * celling.transform.localScale.y) ) - (floor.transform.position.y + (0.5f * floor.transform.localScale.y) );
        diffZ = (frontWall.transform.position.z - (0.5f * frontWall.transform.localScale.z) ) - (backWall.transform.position.z + (0.5f * backWall.transform.localScale.z) );

        Vector3 brickScale = new Vector3(diffX/matrixScalar, diffY/yAxisDivider/matrixScalar, diffZ/matrixScalar);

        float x = leftWall.transform.position.x + 0.5f * leftWall.transform.localScale.x + 0.5f * brickScale.x;
        float y = celling.transform.position.y - 0.5f * celling.transform.localScale.y - 0.5f * brickScale.y;
        float z = backWall.transform.position.z + 0.5f * backWall.transform.localScale.z + 0.5f * brickScale.z;    

        int numberOfBricks = 0;

        // z axis
        for (int i = 0; i < matrixScalar; i++)
        {
            // y axis
            for (int j = 0; j < matrixScalar; j++)
            {
                // x axis
                for (int k = 0; k < matrixScalar; k++)
                {
                    // TODO :: Instead random build hitCount2 and hitCount1 bricks according to the game level
                    CreateBrick(new Vector3(x,y,z), brickScale, (int)Random.Range(1,3));
                    numberOfBricks++;
                    x += diffX/matrixScalar;
                }
                x = leftWall.transform.position.x + 0.5f * leftWall.transform.localScale.x + 0.5f * brickScale.x;
                y -= diffY/yAxisDivider/matrixScalar;
            }
            y = celling.transform.position.y - 0.5f * celling.transform.localScale.y - 0.5f * brickScale.y;
            z += diffZ/matrixScalar;
        }
        player.GetComponent<PlayerScript>().numberOfActiveBricks = numberOfBricks;
    }
}
