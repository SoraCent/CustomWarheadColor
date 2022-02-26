[![forthebadge](https://forthebadge.com/images/badges/built-with-love.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/check-it-out.svg)](https://forthebadge.com)[![forthebadge](https://forthebadge.com/images/badges/made-with-c-sharp.svg)](https://forthebadge.com)

# CustomWarheadColor
CustomWarheadColor is a Simple Exiled Plugin that changes the Light Color when the Warhead is started.
You can define your own colors in the Config with RBG codes.

# Config:
| Name | Type | Description | Default |
| ---- | ---- | ---- | ---- |
| IsEnabled | bool | Is the Plugin enabled | true |
| warhead_color_r | int | Red Color | 0 |
| warhead_color_g | int | Green Color | 128 |
| warhead_color_b | int | Blue Color | 255 |
| enable_no_light_after_detonate | bool | Activating that the Lights going out after the Warhead detonates | true |
| no_light_after_detonate_duration | float | Duration of how long the lights are off | 60 |
| enable_custom_light_color_after_detonate | bool | Activating that the Lights color changes after the Warhead detonates | false |
| warhead_color_after_detonation_r | int | Red Color | 0 |
| warhead_color_after_detonation_g | int | Green Color | 128 |
| warhead_color_after_detonation_b | int | Blue Color | 255 |

## Default Config
```yml
custom_warhead_color:
  is_enabled: true
  # Light Color R = Red, G = Green, B = Blue from 0-255 | Default 0,128,255 = Dodger Blue
  warhead_color_r: 0
  warhead_color_g: 128
  warhead_color_b: 255
  # Activate this if you want that the Light is getting of after Warhead detonation | Default = true
  enable_no_light_after_detonate: true
  no_light_after_detonate_duration: 60
  # Activate this if you want Custom Lightcolor after the Warhead detonated | Default = false
  enable_custom_light_color_after_detonate: false
  # Light Color R = Red, G = Green, B = Blue from 0-255 | Default 0,0,0 = Black
  warhead_color_after_detonation_r: 0
  warhead_color_after_detonation_g: 0
  warhead_color_after_detonation_b: 0
```

For best Experience use Bright colors. Dark Colors can make that users doesn't see anything in game.

For RGB Codes just use the Colorpicker from Google [Google Colorpicker](https://www.google.com/search?q=colorpicker)

# Upcoming Features:
- Nothing.

# Bugs and Suggestions
If you found a Bug or want to suggest something please do that on the Exiled Discord and ping SoraCént#0001

# Known Bugs:
- If you start the Warhead immediately after the Round has started the Server is crashing. So wait a few Seconds before starting the Warhead.
https://www.youtube.com/watch?v=r5tr0rOmy5A

# Screenshots
![Screenshot 1](https://soracent.de/resourcen/pics/github/customwarheadcolor/screen1.jpg)
![Screenshot 2](https://soracent.de/resourcen/pics/github/customwarheadcolor/screen2.jpg)
