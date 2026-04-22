# Moon Surface Audio Visualizer (TouchDesigner)

A **Perform Mode** audio visualizer built in TouchDesigner that renders a procedural, moon-like surface driven by Touchdesigner's audio analysis. Noise is added through the surface of the Moon through [NASA's Moon Trek](https://trek.nasa.gov/moon/). Supports both **direct file URLs** and **local file selection**.

## Features
- URL or local audio input
- Audio-reactive visualizer (noise optionally based on the Moon's surface)
- Perform Mode UI (file select + URL input)

## Node Visualizer Chain
![Visual Chain](https://media.githubusercontent.com/media/BioSh0cked/Moon-Visualizer/refs/heads/main/VisualChain.svg)

## Usage
1. Install [TouchDesigner](https://derivative.ca/download)
2. Open Project
3. Enter Perform Mode (F1)
4. Choose:
   - Local file (file directory), or
   - Direct URL (string input), or
   - Webcame mode
5. Visualizer activates automatically when audio is present / can be directly controller through hand tracking via webcam.

## Demo
![BaseVisual](https://github.com/BioSh0cked/Moon-Visualizer/blob/main/BaseVisual.gif?raw=true)
