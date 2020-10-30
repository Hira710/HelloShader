using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialCtrl : MonoBehaviour
{
    
    private Material myMaterial;

    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer myMeshRender = gameObject.GetComponent<MeshRenderer>();
        myMaterial = myMeshRender.material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPosition = transform.position;
        float red   = Mathf.Clamp(Mathf.Abs(myPosition.x), 0.0f, 1.0f);
        float green = Mathf.Clamp(Mathf.Abs(myPosition.y), 0.0f, 1.0f);
        float blue  = Mathf.Clamp(Mathf.Abs(myPosition.z), 0.0f, 1.0f);
        myMaterial.SetFloat("_MyR", red);
        myMaterial.SetFloat("_MyG", green);
        myMaterial.SetFloat("_MyB", blue);
    }
}
