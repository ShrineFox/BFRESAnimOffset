# BFRESAnimOffset
Offset keyframe values for bones in BFRES files
![](https://i.imgur.com/3HlVv8H.png)  
If you ever need to offset a whole animation's X/Y/Z Translation/Rotation/Scale by a certain amount of units, this is the tool for you!
## Usage
1. Open the BFRES in [Switch Toolbox](https://github.com/KillzXGaming/Switch-Toolbox)
2. Export the animation as ``.anim``
3. Open it with this tool & change values to your liking
4. Export as a new ``.anim`` and replace the Toolbox animation.
## Features
- Features a toggle for treating negative values as positive when adding (i.e. adding 10 to -75 becomes -85)
- Limited to transformations that already exist for a given bone, but that's okay because you'll usually only need to use this on ``Skl_Root`` or similar.
