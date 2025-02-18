using UnityEngine;

public class UiToolKitTip : MonoBehaviour
{
    // It offers improved performance over unity UI, is tailored for maximum performance and reusability
    // One of its key benefits is that it uses a highly optimized rendering pipeline that is specifically designed for UI elements

    // On assets folder, right click -> Create -> UI Toolkit -> Editor window
    // In UI Toolkit Editor Window Creator, enter SimpleCustomEditor in the C# box.
    // Keep the UXML checkbox selected and clear the USS checkbox.
    // Select Confirm
    // To open the Editor window, select Window > UI Toolkit > SimpleCustomEditor.

    // But for build things Window > UI Toolkit > UI Builder

    // Use efficient layouts
    // Refer to using layout groups provided by UI toolkit, instead of manually positions and resizing UI elements

    // Avoid expensive operations in Update
    // minimize heavy operations like UI element creation, manipulation or calculation

    // Optimize Event handling
    // Be mindful of event subscriptions and unregister them when no longer needed
    // Excessive event handling can impact performance, so ensure you only subscribe to events that are necessary

    // Optimize style sheets
    // Large style sheets with numerous rules can impact performance

    // Profile and optimize
    // Unitys profiling tools to identify bottlenecks in your UI and spot areas that can be optimized

    // Test in all target plataforms
   
}
