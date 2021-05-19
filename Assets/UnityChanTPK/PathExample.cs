using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathExample : MonoBehaviour
{
    public GameObject m_PlayerObj;
    public GameObject m_walk;
    public Transform[] positionPoint;
    [Range(0,1)]
    public float value;
    // Start is called before the first frame update
   /* public static void LookFrom(GameObject target, Vector3 looktarget, float time){
		LookFrom(target,Hash("m_walk",looktarget,"time",2));
	}	*/
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
     // iTween.RotateTo(m_PlayerObj, iTween.Hash("y", 45, "time", 100));
      
        //iTween.PointOnPath(positionPoint, value);
      iTween.MoveTo(this.gameObject, iTween.Hash("x",5, "time", 100, "islocal", true));
       //iTween.MoveTo(m_PlayerObj, iTween.Hash("positionPoint",value));    
    }
    private void OnDrawGizmos()
    {
        
        iTween.DrawPath(positionPoint,Color.green);
    }
}