using UnityEngine;

public class UnityProfilerTip : MonoBehaviour
{
    // Improve performance using optimization techniques
    // setting benchmark data
    // profiling should be done at regular intervals
    // profiler is for creators who want to enhance their project by impolementing optimization techniques to improve gameplay performance
    // its a good pratice define the frame rate of the game
    // we have a good fluxogram on unity documentation talking about order of execution of unity events
    // window -> analysis -> profiler
    // its simple to use, the idea is understand when we have a peak and a bad performance and understand where is the problem
    // for it, we paly the game and in profiler window we click on record
    // after that we analyze the data, we have a lot of information like cpu usage, gpu usage, memory usage, draw calls, etc
    // for analyze the peak its just click on window
    // we can analyze each data, for example, look only for scripts, rendering, physics, etc
    // we have a window for filter all data
    // we can press A for frame all, and we can look the time of specific frame 
    // On job we can see all others threads
    // We can press F for frame it
    // the secret is change for hierarchy view 
    // we have a good fluxogram on unity documentation talking about how to discover the problem
    // We can connect a device for profiling, we need to put a ip on play mode on window profiler
}
