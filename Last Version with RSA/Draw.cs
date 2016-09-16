﻿///
/// Draw Class (needed for themes)
/// Original vb.Net Creator, AeonHack
/// Converted to C# by Faded
/// www.EmuDevs.com
/// 

using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class Draw
{
    public static void Gradient(Graphics g, Color c1, Color c2, int x, int y, int width, int height)
    {
        Rectangle R = new Rectangle(x, y, width+1, height);
        using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c2, LinearGradientMode.Vertical))
        {
            g.FillRectangle(T, R);
        }
    }
    public static void Blend(Graphics g, Color c1, Color c2, Color c3, float c, int d, int x, int y, int width, int height)
    {
        ColorBlend V = new ColorBlend(3);
        V.Colors = new Color[] { c1, c2, c3 };
        V.Positions = new float[] { 0F, c, 1F };
        Rectangle R = new Rectangle(x, y, width, height);
        using (LinearGradientBrush T = new LinearGradientBrush(R, c1, c1, (LinearGradientMode)d))
        {
            T.InterpolationColors = V;
            g.FillRectangle(T, R);
        }
    }
}
