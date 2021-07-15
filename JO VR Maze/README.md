# VR Hedge Maze
An 8-bit like hedge maze with turns, dead ends, an obstacle, a chainsaw, and a fun prize made for the Oculus Quest 2. See if you can make it to the end! Link to video playthrough: https://1drv.ms/v/s!AqCKHmZudGwHiLlUnhRgUllz2BW3vA?e=dmjQJC

## Background
This project was developed for a VR assignment for NYU's professional XR dev certificate. Not all required files for opening this as a Unity project have been uploaded since third party assets were used.

## How to install the .apk to your Oculus Quest 2
### Pre-req: Install Andoid Debug Bridge (adb)
1. Go to https://developer.android.com/studio/releases/platform-tools#downloads and select appropriate link for your OS
1. Extract the .zip file and open a shell (e.g. Command Prompt) within downloaded folder (e.g. `<download path>\platform-tools<os>\platform-tools`)
### Pre-req: ensure your Quest is configured for developer mode. Can follow steps 2 & 4 in SideQuest: https://sidequestvr.com/setup-howto
### Install
1. Connect Oculus Quest 2 via USC-C cable to your computer. Ignore Oculus Link pop-ups
1. Download `Build\OculusAPK\maze.apk` from this repo
1. From previously opened Android Platform Tools shell, type `adb install "your/download/path/to/maze.apk"
1. Put on your Oculus and play! See controls below

## Controls
Left Controller (Teleportation and Snap-Turn)
- Use thumbstick to rotate
- Press up on thumbstick when blue sphere is seen to teleport to that location
- Press A to teleport also

Right Controller (Grab)
- Grab object with side trigger (middle finger)
- Use object with back trigger (index finger)

## Third-Party Assets & Tools
1. Jujube Map Editor | 3D Level Designer: https://assetstore.unity.com/packages/tools/game-toolkits/jujube-map-editor-3d-level-designer-176992
1. Rescue3D Petrol Chainsaw: https://assetstore.unity.com/packages/3d/props/petrol-chainsaw-74889
1. Chainsaw sound effect: https://freesound.org/people/forfie/sounds/413550/
1. Maze End Win Sound: https://freesound.org/people/funisfun8/sounds/332172/
1. XR Default Actions: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples
1. Unity VR Project Template: https://docs.unity3d.com/Packages/com.unity.template.vr@2.0/manual/index.html

# Assignment Requirements
## Lessons Learned & Development Process
- XR Interaction Toolkit is awesome! The samples here helped tremendously: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples
- Using Jujube Map Editor really helped me create the hedge maze I wanted
- Testing changes via a simulator on my computer was *essential*. Checkout XR Device Simulator (this thread and its videos are a great starter: https://forum.unity.com/threads/where-can-i-learn-to-use-the-xr-device-simulator.1013644/)
- This certainly took a lot longer than I expected (probably 10-15 hours?) Getting the XR rig and controllers to work the way I wanted was the hardest part. In retrospect, I wish I would have simply taken the XR Interaction Toolkit Example rig as my base, but I learned a lot about how the XR Interactors and Interacatables work on my own.
- Adding sounds was soooooo worth it :)
- I challenged myself to use action-based XR components and to add Unity events. For example, the hedge door is only removed if you activate the chainsaw, rather than just "touch it." I'm glad I invested in this although I had to read docs and go through trial and error, but I think it more closely matches to a user's expectation. It was fun to learn about [Physics.ComputePenetration](https://docs.unity3d.com/ScriptReference/Physics.ComputePenetration.html).

## Requirements Checklist
- [x] The maze includes at least four turns.
- [x] The maze includes at least two dead ends.
- [x] The environment objects are aligned to the grid.

See turns, dead ends, and grid, via this screenshot:
![Maze Screenshot](https://github.com/jason-ortiz/Unity-Misc/blob/main/JO%20VR%20Maze/AssignmentMedia/Screenshots/Maze%20Grid%20View.png)

- [x] The player must use a grabbable object to progress further.
- [x] A win state is activated upon entering the final section.
- [x] The maze must be playable with the VR headset.

See video playthrough: https://1drv.ms/v/s!AqCKHmZudGwHiLlUnhRgUllz2BW3vA?e=dmjQJC

