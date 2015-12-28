using UnityEngine;
using System.Collections;

public class BuildPrefab : MonoBehaviour {

    public GameObject prefab;
    public float delay = 1.0f;
    
    void Start() {
        StartCoroutine(Build(delay));
    }

    IEnumerator Build(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(prefab, transform.position, transform.rotation);
    }
    
}
