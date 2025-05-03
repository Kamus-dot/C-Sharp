namespace MiInterfaceHierarchy
{
    interface IShape: IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}