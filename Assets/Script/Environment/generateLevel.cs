using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateLevel : MonoBehaviour
{
    public GameObject[] section;
    public GameObject[] StartingSections;
    public int zPos = 70;
    public int secNum;
    private List<GameObject> activeTiles = new List<GameObject>();
    private GameObject tiles;
    public Transform playerTransform;
    public bool CreatingSections = false; 

    void Start(){
        for (int i = 0; i < 5 ; i++)
        {
            secNum = Random.Range(0, 7);
            tiles = Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
            activeTiles.Add(tiles);
            zPos += 35;
        }
    }
    void Update()
    {
        if (CreatingSections == false)
        {
            CreatingSections = true;
            StartCoroutine(GenerateSection());
        }
        if (playerTransform.position.z >= activeTiles[0].transform.position.z + 35)
        {
            DeleteTile();
        }
    }

    IEnumerator GenerateSection()
    {
        
        secNum = Random.Range(0, 7);
        tiles = Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        activeTiles.Add(tiles);
        zPos += 35;
        yield return new WaitForSeconds(1);
        CreatingSections = false;
    
    }
    private void DeleteTile()
    {
        Destroy(activeTiles[0]);
        activeTiles.RemoveAt (0);

    }
}

