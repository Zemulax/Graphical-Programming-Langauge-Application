﻿namespace MyAssignment
{
    /// <summary>
    /// interface for all classes
    /// </summary>
    internal interface ShapesInterface
    {
        /// <summary>
        /// all classes must have this general implementation
        /// </summary>
        /// <param name="graphics"></param>
        void DrawShape(Graphics graphics);
        void Set(Color color, bool fill, Brush shapeBrush, Pen shapePen, params int[] coordinates);

    }
}
