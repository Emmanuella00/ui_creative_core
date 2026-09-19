# Ready??? — Creative Core: UI
A custom interactive UI project with multiple features and a World Space UI design built from the **Creative Core: UI** pathway

## Live Demo
 
- Unity Play: [https://play.unity.com/en/games/baafe29d-96a0-48ad-8394-bc883a428213/webbuilds]

## Features

- Title text using a custom Creepster font, with a Settings menu (Music toggle, Volume slider, Exit button)
- **Lights Out toggle** — kills the StreetLamp and BulbLamp light sources on demand, with an on-screen label that swaps between "Lights Off" / "Lights On"
- **Fire toggle** — extinguishes the firepit's light and flame together, with a gradual fade instead of an instant cutoff, independent of the existing spacebar-driven fire scripts (`ToggleFireParticle.cs` / `ToggleFireVFXGraph.cs`)
- **Brightness slider** — adjusts the intensity of the StreetLamp and BulbLamp lights live
- **World Space UI challenge** — a duplicate scene (`UI_Worldspace`) with the entire Canvas converted to World Space render mode, repositioned in the 3D environment, with full menu functionality retained

## How to Run 
1. Open the project in **Unity 6 (6000.5.10f1)** or later.
2. Open either scene above from the Project window.
3. Press **Play**.
4. Click the Settings button to access Music, Volume, Lights, Fire, and Brightness controls.
5. Press **Space** to test the independent spacebar-driven fire scripts.


## Built With
 
Unity 6 ·

