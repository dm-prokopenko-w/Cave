using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torchLightJitter : MonoBehaviour
{
    public Light lightObject;
    public float range;
    public float jitterSize;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(lightCore());
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator lightCore()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            lightObject.intensity = Random.Range(1.5f, 3f);
            //  lightObject.range = range + Random.Range(-0.5f, 0.5f);
            transform.position = pos + new Vector3(Random.Range(-jitterSize, jitterSize), Random.Range(-jitterSize, jitterSize), Random.Range(-jitterSize, jitterSize));
        }

    }
}