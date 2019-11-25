using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraObjectRenderer : MonoBehaviour
{

    /*
    Copyright (C) 13/10/2019 1:35 PM GMT +8:00 Noah James C. Yanga

    Render's object visibility base on the view of the MainCamera Tag,
    attach this file to the gameobject as component to apply.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

    private Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool camera_visiblity = renderer.IsVisibleFrom(Camera.main);
        renderer.enabled = camera_visiblity;
    }
}
