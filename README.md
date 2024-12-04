# cpflyout

## Application Functionality and Implementation

This application is a WPF-based Windows 11 application that docks to the side of the screen and flies out to half the screen width when the mouse is near the edge. The application hosts a browser window with a configurable URL.

### Features

- Docks to the side of the screen
- Flies out to half the screen width when moused over
- Hosts a browser window
- Configurable URL in app settings
- Handles different screen resolutions and scaling settings
- Detects mouse proximity to the screen edge
- Handles window resizing

### Implementation Details

- Uses WPF to create a window that docks to the side of the screen
- The window's `WindowStyle` is set to `None` and `AllowsTransparency` is set to `True` to create a borderless window
- A `Storyboard` is used to animate the window's position and size when the mouse is near the edge of the screen
- A `WebBrowser` control is used to host the browser window
- The initial position of the window is set using the `Left` and `Top` properties in the XAML file or programmatically in the `Window_Loaded` event handler
- Uses the `SystemParameters` class to get the screen resolution and scaling settings
- Sets the `Width` and `Height` properties of the window based on the screen resolution
- Uses the `LayoutTransform` property to apply scaling to the window content
- Handles the `DpiChanged` event to adjust the window size and scaling when the DPI settings change
- Handles the `MouseMove` event of the main window to detect mouse proximity to the screen edge
- Uses the `Mouse.GetPosition` method to get the current mouse position
- Triggers the flyout animation if the mouse is near the edge
- Sets the `SizeToContent` property of the window to `WidthAndHeight`
- Handles the `SizeChanged` event of the window
- Uses the `MinWidth`, `MinHeight`, `MaxWidth`, and `MaxHeight` properties to set the window size limits
- Ensures responsive layout using layout controls like `Grid`, `StackPanel`, and `DockPanel`
- Uses `HorizontalAlignment`, `VerticalAlignment`, `Margin`, and `Padding` properties for content alignment and spacing

### Setting the URL in App Settings

To set the URL in the app settings, follow these steps:

1. Open the `App.config` file in your project.
2. Add an entry for the URL in the `App.config` file.
3. Use the `ConfigurationManager` class to read the URL from the `App.config` file in your code.
4. Set the `Source` property of the `WebBrowser` control to the URL read from the settings.
