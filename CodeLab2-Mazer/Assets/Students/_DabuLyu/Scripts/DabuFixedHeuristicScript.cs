using UnityEngine;
using System.Collections;

namespace DabuLyu
{
    public class DabuFixedHeuristicScript : HeuristicScript {
		
         //Manhattan Distance
         public override float Heuristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript) {
             return Mathf.Abs(goal.x - x) + Mathf.Abs(goal.y - y);
         }
        
        
        // //Manhattan Distance with Terrain Awareness
        // Manually replicate gridString from SecondGridScript
        // private string[] gridString = new string[]{
        //     "----|----}wwwwwwww-|----|----|",
        //     "--r-|----|---wpppw-|-f--r----|",
        //     "----|--f-|---rpppppp-f--|----|",
        //     "--f-r----|---wpppw-p-f--|--r-|",
        //     "----|----|---wwrww-p-f--|----|",
        //     "----|----|---p|----ppf--|----|",
        //     "ff-f|ff--|--wwwwww-fpffwwwwwwww",
        //     "ff---fffpwwwwwwwwwfffwwwwwwwww",
        //     "fffrffff-|wwwwrwwwwwww--|----|",
        //     "f--ffff--|--wrlr---fgppp|-r--|",
        //     "frffff---f---rllr--|-ffppp-f-|",
        //     "----|----|--rrlllrrr----|p---|",
        //     "---rrrrrrrrrrllllllrrrrrrrrrrr",
        //     "rr--|----rrrrlllllrrrrr-|-r--|",
        //     "---r|--r-|-r-lrrl--r---r|----|",
        //     "-r--|r--r|---lrrl--|-r--|r-r-|",
        //     "--r-|----|r---rr---|----|----|"
        // };
        //
        // // Manhattan Distance with Terrain Awareness
        // public override float Heuristic(int x, int y, Vector3 start, Vector3 goal, GridScript gridScript) {
        //     // Calculate the Manhattan distance
        //     float distance = Mathf.Abs(goal.x - x) + Mathf.Abs(goal.y - y);
        //
        //     // Determine the terrain cost modifier based on the replicated gridString
        //     float terrainModifier = 1.0f; // Default modifier
        //
        //     // Ensure coordinates are within bounds
        //     if (y >= 0 && y < gridString.Length && x >= 0 && x < gridString[y].Length) {
        //         char terrain = gridString[y][x];
        //
        //         // Assign cost multiplier based on terrain type
        //         switch (terrain) {
        //             case 'r': // Rough terrain
        //                 terrainModifier = 5.0f;
        //                 break;
        //             case 'w': // Water
        //                 terrainModifier = 10.0f;
        //                 break;
        //             case 'l': // Low-cost terrain
        //                 terrainModifier = 1.5f;
        //                 break;
        //             case 'p': // Path
        //                 terrainModifier = 1.0f;
        //                 break;
        //             case 'f': // Forest
        //                 terrainModifier = 3.0f;
        //                 break;
        //             default: // Default terrain
        //                 terrainModifier = 1.0f;
        //                 break;
        //         }
        //     }
        //
        //     // Incorporate the terrain modifier into the heuristic
        //     return distance * terrainModifier;
        // }
        //
        
        

    }
    
    


}
