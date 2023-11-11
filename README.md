# VRChat Android Menu

This prefab adds a menu that can only be seen on Android smartphones, I am using the same menu in my "Lightcylce Arena" world https://vrchat.com/home/world/wrld_9157c81d-24fe-402d-8ba9-2e0ae6e15fa2

![Showcase](https://github.com/MyroG/VRChat-Android-Menu/blob/master/Doc/Lightcycle.jpg)

With this menu you can
- Toggle objects, like a mirror, audio sources... you can use this menu as a quick setting menu
- Teleport the local player at a given location, which can make your world more enjoyable to use. 

## Installation

- Requires UdonSharp
- Download the latest release, and import it into your Unity project
- Open the "Android Menu" prefab (MyroP > AndroidMenu > Android Menu.prefab)
- Under the `Menu` GameObject, you can add as many buttons as you want, buttons can be found in the "Buttons" folder (MyroP > AndroidMenu > Buttons)

![Showcase](https://github.com/MyroG/VRChat-Android-Menu/blob/master/Doc/hierarchy.PNG)

There are two kind of buttons :
- AndroidButtonTeleport : Teleports the player at a given location, the location can be set in the "Teleport Player" component
 
![Showcase](https://github.com/MyroG/VRChat-Android-Menu/blob/master/Doc/Teleport.PNG)
- AndroidToggleButton : Toggles a list of GameObjects. If you want all GameObjects to be shown by default, you can check "Shown By Default"

![Showcase](https://github.com/MyroG/VRChat-Android-Menu/blob/master/Doc/Toggle.PNG)

## Example

An example scene is included in the "Example" folder.
