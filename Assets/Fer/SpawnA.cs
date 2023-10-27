using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnA : MonoBehaviour
{
    public GameObject spawnA;
    public Vector3 Position;
    Quaternion Rotation;
    public Transform Parent;

    BoardEnter _boardEnter;
    CheckA check;

    void Start()
    {
        _boardEnter = FindFirstObjectByType<BoardEnter>();
        check = FindFirstObjectByType<CheckA>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_boardEnter.Entro == true)
        {
            StartCoroutine(SpawnerA());
        }

        if (_boardEnter.Entro == false)
        {
            StopCoroutine(SpawnerA());
        }
    }

    IEnumerator SpawnerA()
    {
        Instantiate(spawnA, Position, Rotation, Parent);
        yield return new WaitForSeconds(5f);
    }
}
