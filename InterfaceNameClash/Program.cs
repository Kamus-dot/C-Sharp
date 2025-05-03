using System;
using InterfaceNameClash;

Octagon octagon = new Octagon();

IDrawToForm itfForm = (IDrawToForm)octagon;
itfForm.Draw();


((IDrawToPrinter)octagon).Draw();

if (octagon is IDrawMemory drawnMemory)
{
    drawnMemory.Draw();
}