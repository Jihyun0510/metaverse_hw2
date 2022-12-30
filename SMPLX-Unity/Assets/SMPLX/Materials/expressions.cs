using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class expressions : MonoBehaviour
{
    Mesh thisMesh;
    SkinnedMeshRenderer smr;

    float[] happy;
    float[] surprised;
    float[] angry;

    // Start is called before the first frame update
    void Start()
    {
        smr = this.GetComponent<SkinnedMeshRenderer>();
        thisMesh = smr.sharedMesh;

        happy = new float[thisMesh.blendShapeCount];
        surprised = new float[thisMesh.blendShapeCount];
        angry = new float[thisMesh.blendShapeCount];
        

        happy[thisMesh.GetBlendShapeIndex("Exp000")] = 100;
        surprised[thisMesh.GetBlendShapeIndex("Exp001")] = 100;
        angry[thisMesh.GetBlendShapeIndex("Exp002")] = 100;
        angry[thisMesh.GetBlendShapeIndex("Exp003")] = 100;
        

        SetDefault();
    }

    void SetDefault()
    {
        for (int i = 0; i < thisMesh.blendShapeCount; i++)
            smr.SetBlendShapeWeight(i, 0);

    }

    void SetHappy()
    {
        for (int i = 0; i < thisMesh.blendShapeCount; i++)
            smr.SetBlendShapeWeight(i, happy[i]);
    }
    void SetSurprised()
    {
        for (int i = 0; i < thisMesh.blendShapeCount; i++)
            smr.SetBlendShapeWeight(i, surprised[i]);
    }

    void SetAngry()
    {
        for (int i = 0; i < thisMesh.blendShapeCount; i++)
            smr.SetBlendShapeWeight(i, angry[i]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetDefault();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetHappy();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetSurprised();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetAngry();
        }

    }
}
