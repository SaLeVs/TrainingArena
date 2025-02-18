using UnityEngine;

public class AudioOptimizationTips : MonoBehaviour
{
    // Though audio is not typically a performance bottleneck, you an still optimize to save memory 

    // Make sounds sound clips when possible
    // If you are using 3d spatial audio, author your sound clips as mono or enable the Force to Mono setting
    // Otherwhise, a multichannel sound used positionally at runtime will be flattened to a mono source, thus increasing CPU cost and wasting memory

    // Use original uncrompressed WAV files as your source assets
    // if you use any compressed format (such as MP3 or vorbis), Unity will decompress it, then recompress it during build time

    // Compress the clip and reuce the compression bitrate
    // Use Vorbis for most sounds (or MP3 sounds not intended to loop)
    // Use ADPCM for short, frequently used sounds (footsteps, gunshots). this shrinks the files compared to uncompressed PCM, but is quick to decode during playbacks

    // Sound effects on mobile devices should be 22,050hz at most. Using lower settings usually has a minimal impact on the final quality

    // Choose the proper Load Type
    // This seetings varies by clip size

    // Clip size: 200 kb)
    // Example usage: Noisy sfx (gunshots, explosions)
    // Load Type: Decompress on Load or set to compressed in memory and set compression format to ADPCM. this offer a inexpensive decompression cost in realtime

    // clip size: >= 200 kb
    // Example usage: Dialog, short music, medium sfx
    // Load Type: Depends of the projects priorities
    // if reducing memory usage is the priority, sleect decompress on load
    // if CPU usage is a concern, clips should be set to decompress on load

    // clip size: >= 350-400 kb
    // Example usage: Long music, ambient sounds
    // Load Type: Set to streaming. Streaming has a 200kb overhead.

    // Use the sample rate setting
    // Set the Sample Rate Setting to optimize Sample rate
    // FOr mobile plataforms, 22.050 hz should be sufficient for most sounds. Use 44.100hz for high quality music
}
