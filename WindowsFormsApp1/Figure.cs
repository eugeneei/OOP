using System;
using System.Drawing;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public interface Figure
    {

        string Draw(Graphics draw);
        void SetCoordinates(float x, float y, float xsize, float ysize);
        string Name();


    }
}