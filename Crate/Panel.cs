﻿namespace Crate
{
    internal class Panel: BathroomStall
    {

        public void ChangeThickness()
        {
            if(_material == "Phenolic")
            {
                _thickness = 0.5;
            }
            else
            {
                _thickness = 0.875;
            }
        }
       
    }
}