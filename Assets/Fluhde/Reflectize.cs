using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflectize : MonoBehaviour
{
    // Start is called before the first frame update

    public ReflectionProbe PRefab;

    [ContextMenu("Create")]
    public void Create()
    {
        var collider = GetComponent<BoxCollider>();

        var probe = GameObject.Instantiate(PRefab);

        probe.transform.parent = this.transform;
        var extend = collider.size;
        extend.Scale(new Vector3(0.5f, 0.5f, 0.5f));
        probe.transform.localPosition = collider.center + extend;
        probe.transform.localRotation = Quaternion.identity;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
