using UnityEngine;

public class MemoryProfilerTip : MonoBehaviour
{
    // Snapshot of memory usage
    // Works alongside profiler and profile analyzer
    // Compare before and after optimization snapshots
    // We need to instal the package from the package manager
    // window -> analysis -> memory 
    // Capture new snapshot
    // We have Resident memory and allocated memory
    // Resident memory is the memory used in the system ram
    // Allocated memory is the amount of memory requested but not yet filled
    // after create a snapshot we have 3 guides, sumaary, unity objects and all of memory
    // on sumary we have so much things and all have a good description
    // for good analysis we need to build a game and after that we click on capture for a new snapshot
    // On unity objects we can see what kind of objects are using more memory, and we can click on flatten hierachy to see the objects in a better way
    // to create a build we need to check development build and autoconnect profiler on build settings
    // after cretae a build we can click for capture and will work
    // the difference is crazy, we have a editor game with 2.68 and a build withg 0.52
    // the most important is compare snapshots for understand if a method of optimization is working
    // just change single snapshot to compare snapshots and select 2 different snapshots
    // snapshots are saved in the project folder, its better save on computer and test after, gitkraken have a problem with snapshots because the size
}
