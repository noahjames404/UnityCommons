using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Copyright (C) 12/10/2019 11:53 PM GMT +8:00 Noah James C. Yanga

    This class is used to manipulate & compute the values of health points.

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

public class HealthBar
{

    /*
     * @METHOD getCurrentHealthByPercentage 
     * @PARAMS hp - the current hp
     * @PARAMS max_hp - the highest peak that can be reach by hp
     * @PARAMS base_value - the value to be related with. 
     * e.g: 
     * if the base_value is 100 the result of variable hp with value of 10 & max_hp with value of 500 is 2%. 
     * if the base_value is 200 the result of variable hp with value of 10 & max_hp with value of 500 is 4%. 
     * if the base_value is 100 the result of variable hp with value of 50 & max_hp with value of 100 is 50%. 
     * this takes the percetage of the result of variable hp & max_hp base on base_value.
     * @THROWS an exception if the hp is greater than max_hp
     * 
     */
    public float getCurrentHealthByPercentage(float hp, float max_hp, float base_value = 100)
    {
        if (hp > max_hp)
        {
            throw new Exception("HP must be less than or equal to MAX HP");
        }
        return hp / max_hp * base_value;
    }

}
