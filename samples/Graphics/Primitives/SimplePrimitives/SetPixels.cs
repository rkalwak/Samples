﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using nanoFramework.Presentation.Media;
using nanoFramework.UI;

namespace Primitives.SimplePrimitives
{
    class SetPixels
    {
        public SetPixels(Bitmap fullScreenBitmap, Font DisplayFont)
        {
            fullScreenBitmap.Clear();
            fullScreenBitmap.Flush();
            for (int i = 0; i < fullScreenBitmap.Height; ++i)
            {
                fullScreenBitmap.SetPixel(i, i, (Color)((255 - i) << 16));
            }

            for (int i = 0; i < fullScreenBitmap.Height; i += 2)
            {
                fullScreenBitmap.SetPixel(fullScreenBitmap.Height - i, i, (Color)(i << 8));
            }

            InformationBar.DrawInformationBar(fullScreenBitmap, DisplayFont, InfoBarPosition.bottom, "Set individual Pixels");
            fullScreenBitmap.Flush();
        }
    }
}
