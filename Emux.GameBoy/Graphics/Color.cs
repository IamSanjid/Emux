﻿namespace Emux.GameBoy.Graphics
{
    /// <summary>
    /// Represents a 24 bit color.
    /// </summary>
    public struct Color
    {
        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        {
            R = r;
            G = g;
            B = b;
        }

        public override string ToString()
        {
            return $"{nameof(R)}: {R}, {nameof(G)}: {G}, {nameof(B)}: {B}";
        }
    }
}
