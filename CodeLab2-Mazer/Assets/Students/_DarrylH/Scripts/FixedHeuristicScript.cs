using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DarrylH
{
    public class FixedHeuristicScript : HeuristicScript
    {

        public float BrooklynDistanceHeuristic(float x, float y, Vector3 start, Vector3 goal, GridScript gridScript)
        {
            //return Mathf.Abs((a.x - b.x) + Mathf.Abs(a.y - b.y));
            return Mathf.Abs((start.x - goal.x) + Mathf.Abs(start.y - goal.y));
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
