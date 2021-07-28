# VR Spaceship
Control a spaceship in VR! See video playthrough here: https://1drv.ms/v/s!AqCKHmZudGwHiLlxYxIxwP0gtgcc9A?e=QtE57l

## Background
This project was developed for a VR assignment for NYU's professional XR dev certificate.

## How to install the .apk to your Oculus Quest 2
### Pre-req: Install Andoid Debug Bridge (adb)
1. Go to https://developer.android.com/studio/releases/platform-tools#downloads and select appropriate link for your OS
1. Extract the .zip file and open a shell (e.g. Command Prompt) within downloaded folder (e.g. `<download path>\platform-tools<os>\platform-tools`)
### Pre-req: ensure your Quest is configured for developer mode. Can follow steps 2 & 4 in SideQuest: https://sidequestvr.com/setup-howto
### Install
1. Connect Oculus Quest 2 via USC-C cable to your computer. Ignore Oculus Link pop-ups
1. Download `Build\Assignment\physical-controls.apk` from this repo
1. From previously opened Android Platform Tools shell, type `adb install "your/download/path/to/physical-controls.apk"
1. Put on your Oculus, go to "Unknown sources" and play! See controls below

## Controls
Left Controller & Right Controller
- Grab control with side trigger (middle finger)
- Press button with by pressing it down with any part of your hand

## Third-Party Assets, Tools, and References
1. Hi-Rez Spaceships Creator Free Sample: https://assetstore.unity.com/packages/3d/vehicles/space/hi-rez-spaceships-creator-free-sample-153363
1. How to create an infitine starfield: https://blenderfreak.com/tutorials/how-to-create-infinite-starfield-for-space-scene-in-unity/
1. How to shoot lasers: https://www.firemind-academy.com/p/how-to-shoot-lasers-in-unity
1. Volumetric Lines: https://assetstore.unity.com/packages/tools/particles-effects/volumetric-lines-29160
1. Space skybox: https://assetstore.unity.com/packages/2d/textures-materials/sky/spaceskies-free-80503

# Assignment Requirements
## Lessons Learned & Development Process
- Using the samples I created following along with NYU coursework, I expanded the control movement from 1 dimension to 2 dimensions for the joystick
- The spaceship was intended to continously rotate dependeing on the joystick rotation, but I could not make that work, and that was certainly the most difficult part

## Requirements Checklist
- [x] There are three unique hand-interacatble controls

