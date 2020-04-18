using System;
using System.Drawing;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    [XmlInclude(typeof(LineFig))]
    [XmlInclude(typeof(EllipseFig))]
    [XmlInclude(typeof(RectangleFig))]
    [Serializable]
    public abstract class Figure
    {

        public abstract string Draw(Graphics draw);

    }
    
}