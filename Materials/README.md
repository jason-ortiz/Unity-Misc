Lessons learned:
1. Meshes
    a. The main graphic primitive of Unity, which define the shape of objects
2. Materials
    a. Define how a surface should be rendered by including references to textures, tiling information, color tints, and more
3. Shaders
    a. Small scripts (run on GPU) that contain the math calculations and algorithms for calculating the color of each pixel rendered
4. Textures
    a. Bitmap images that materials use to calculate the surface color of a GameObject via Texture Mapping

Materials have Shaders and Textures T1 to Tn which the shader can reference

- Applying textures
- Using Materials Scripting API to "pulse" the alpha part of color property of a material.
