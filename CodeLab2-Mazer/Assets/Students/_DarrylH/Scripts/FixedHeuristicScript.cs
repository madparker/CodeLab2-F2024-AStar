using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace DarrylH
{
    public class FixedHeuristicScript : HeuristicScript
    {
        
        public float BrooklynDistanceHeuristic(float x, float y, Vector3 start, Vector3 goal, GridScript gridScript)
        {
            //return Mathf.Abs((a.x - b.x) + Mathf.Abs(a.y - b.y));
            return Mathf.Abs((start.x - goal.x) + Mathf.Abs(start.y - goal.y));
        }
        
        /* Attempted another heuristic, but need more time to understand
        public static float MinkowskiDistance(double[] x, double[] y, int p)
            {
                double sum = 0;
                    for (int i = 0; i < x.Length; i++)
                    {
                        sum += Math.Pow(Math.Abs(x[i] - y[i]), p);
                    }
             return Math.Pow(sum, 1.0f / p);
            }
        
        */
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
