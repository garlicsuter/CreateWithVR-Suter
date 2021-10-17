using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksNotes : MonoBehaviour
{
/*
 Create with VR course Progress:
 1 VR Basics Complete
    - Custom picture frame: New Material, base map is jpeg. Material "tiling" x and y scrub until it fits.

 3 Polaroid Camera

    1- Place Camera (prefabs>obj>electronic>camera...and re-add mesh renderer Main_Material). Rigidbody Collision = Continuous Speculative
    2- Import 2 scripts, Polaroid and Photo (Polaroid Script on parent "Camera". Photo script on Photograph prefab)
    3- Add "XR Grab Interactable" Script to Parent Camera
    4- On Parent Camera...create empty "viewfinder_camera" and steal mirror's camera component. Reposition. Set priority to -2!
        A: Mesh Filter = Plane, transform values: P:0,0.0873, -0.0332 Rot: 90,0,180 Scale: .004, .004, .004
    5- Built Photo Prefab from searched "photo". Fix main_mat. Add XR GRAB. Uncheck Retain Transform Parent. Check Force Gravity & Continuous Speculative.
        A: Open Prefab - "Polaroid Film" Mesh Renderer = new Polaroid_Material (Black)
        B: Box Collider: size .0833,.0013,.0929
        C: Add Script "Apply Physics"
            in XR GRAB: On Select Exit...Photo...Enable Physics
    6- Create empty "PhotoSpawnLocation". Play, adjust spawnloc.
    7- Camera Parent: XR Grab Events:
        A: Select Entered...from Camera
*/
}
