# 26-27-InteligentInterfaces-p01-IntroductionToCSharpScripts

This repo holds code for 26-27-InteligentInterfaces-p01-IntroductionToC#Scripts

# Movement exercises

* **Exercise 1**:

The main purpose of this exercise is to become familiar with the use of the 
Inspector. In the code, this is achieved by adding the `[SerializeField]` 
attribute to our script.

On the other hand, the main idea behind the script is to initialize the vector 
containing the color components of the object with random values. Then, every 
certain number of frames (`Time.frameCount % framesToWait == 0`), one of the 
components is updated with a new random value. The number of frames to wait 
depends on the `framesToWait` attribute, which can be modified directly from 
the Inspector.

As a result, our cylinder changes color, and its frequency can be modified 
through the Inspector, as illustrated in the GIF.

![gif-1](./gifs/gif-1.gif)

* **Exercise 2**:

The main purpose of this exercise is to work with vectors in Unity and become 
familiar with some of the operations that can be performed on them. The script 
defines two `Vector3` variables, `firstVector` and `secondVector`, which can 
be modified directly from the Inspector.

For each frame, the script calculates several properties of both vectors. 
It calculates the angle between them using `Vector3.Angle()` and the distance 
between them using `Vector3.Distance()`.

The calculated values are stored in variables marked with the `[SerializeField]` 
attribute, allowing them to be displayed in the Inspector. The same information 
is also printed to the Unity Console using `Debug.Log()`. This allows us to 
observe how the different properties change when the vectors are modified.

The resulting calculations can be observed in the Console when the vector 
components are change using the Inspector, as illustrated in the GIF.

![gif-2](./gifs/gif-2.gif)

* **Exercise 3**:

The main purpose of this exercise is to learn how to access the position of a 
GameObject in two different ways. The script stores the sphere's position in a 
`Vector3` variable, which is displayed in the Inspector thanks to the 
`[SerializeField]` attribute.

First, the script directly accesses the `Transform` component through 
`transform.position` and stores the resulting position in the `spherePosition` 
variable. 

Then, in every frame, the script uses `GetComponent<Transform>()` to retrieve 
the GameObject's `Transform` component. If the component is found, its position 
is accessed through `transformComponent.position` and stored in 
`spherePosition`.

Therefore, the exercise demonstrates two different approaches to accessing a 
GameObject's position: directly through the `transform` property and by first 
retrieving the `Transform` component using `GetComponent<Transform>()`. The 
results are shown in the screenshot below, where the sphere's position can be 
seen in the Inspector under the `Script3` component.

![screenshot-3](./screenshots/screenshot-3.png)

* **Exercise 4**:

The main purpose of this exercise is to learn how to find and interact with 
specific GameObjects using tags. To achieve this, it was necessary to create 
the `Cube` and `Cylinder` tags in the Inspector and assign them to their 
corresponding GameObjects.

At the beginning of the script, the `GameObject.FindWithTag()` method is used 
to find the objects associated with each tag. The references to the cube and 
cylinder are then stored in the `cubeObject` and `cylinderObject` variables. 

During each frame, the script calculates the distance between the current 
GameObject and both the cube and the cylinder using `Vector3.Distance()`. 
These distances are stored in the `distanceToCube` and `distanceToCylinder` 
variables, which are marked with the `[SerializeField]` attribute so that their 
values can be displayed in the Inspector. The calculated distances are also 
printed to the Unity Console using `Debug.Log()`.

As a result, we can observe in real time how the distances to the cube and 
cylinder change as their positions are modified.

![gif-4](./gifs/gif-4.gif)
