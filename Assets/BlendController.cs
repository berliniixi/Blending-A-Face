using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendController : MonoBehaviour
{
    SkinnedMeshRenderer _blendShapes;

    [SerializeField] private float eyesReaction; 
    [SerializeField] private float eyesOpen; // Open and close the eyes
    [SerializeField] private float mouthReaction; // Open and close the mouth using the mouse 
    void Start()
    {
        _blendShapes = GetComponent<SkinnedMeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        eyesReaction = Input.GetAxis("Vertical") * 100;
        eyesOpen = Input.GetAxis("Horizontal") * 100;
        mouthReaction = Input.mousePosition.y;
        
        _blendShapes.SetBlendShapeWeight(0, eyesReaction);
        _blendShapes.SetBlendShapeWeight(1, eyesOpen);
        _blendShapes.SetBlendShapeWeight(2, mouthReaction);
    }
}

