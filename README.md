# DrawingSim
The solution is composed of several projects, each representing a layer or a separate context.
## DrawingSim.Application
Contains application logic
### `Canvas`
Takes a list of `Widgets` and print out their output
Implements `ICanvas` interface
## DrawingSim.Common
Contains common classes and abstracts (interfaces and proper `abstract` classes)
### `ICanvas`
Represent a common interface for application logic and has methods to add widgets and print out output.
### `WidgetNameAttribute`
This Attribute is used to declaratively set the display name of the widget (it's returned by the Draw method of the widget)

## DrawingSim.Console
Console application displaying the desidered output, consuming the application logic
## DrawingSim.Domain
Contains all the widget to be displayed.
There are five widget, one for every shape:
```
Rectangle
Square
Ellipse
Circle
Textbox
```
Every widget has a `Draw` method to produce its output and has a private `Verify` function which is executed when the `Drawable` property is evaluated.
Constructor is protected to avoid to create the `Widget` without correct parameters.
## DrawingSim.Test
Unit Test project