using System;
using InterfaceHierarchy;

Console.WriteLine("******* Simple Interface Hierarchy *******");

BitmapImage bitmap = new BitmapImage();

bitmap.Draw();
bitmap.DrawInBoundingBox(100, 10, 10, 10);
bitmap.DrawUpsideDown();

if (bitmap is IAdvancedDraw advanced)
{
    advanced.Draw();
    Console.WriteLine($"Time to draw is {advanced.TimeToDraw()}");
}

IDrawable drawable = (IDrawable)bitmap;

Console.WriteLine(drawable.TimeToDraw(12));

Console.WriteLine(bitmap.TimeToDraw());

