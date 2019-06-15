using System;


namespace FiguresLib
{
    interface IEMeasurable2D : IEmeasurable1D
    {
        double Circumference { get; }
        double Surface { get; }
    }
}
