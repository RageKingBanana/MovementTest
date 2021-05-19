using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathExample : MonoBehaviour
{
    public GameObject m_PlayerObj;
    public Transform[] positionPoint;
    [Range(0,1)]
    public float value;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(iTween.PathLength(positionPoint));
    }
    float tempTime;
    // Update is called once per frame
    void Update()
    {
        if (value < 1)
        {
            value += Time.deltaTime / 10;
        }
       //iTween.PutOnPath(m_PlayerObj, positionPoint, value);
       // iTween.PointOnPath(positionPoint, value);
       //iTween.MoveTo(m_PlayerObj, iTween.Hash("walk", iTween.PutOnPath(positionPoint), "orienttopath", true, "lookahead", .5f, "time", 500));
       iTween.MoveTo(m_PlayerObj, iTween.Hash("walk", 5, "time", 100, "orienttopath", true));    
    }
    private void OnDrawGizmos()
    {
        
        iTween.DrawPath(positionPoint,Color.green);
    }
}