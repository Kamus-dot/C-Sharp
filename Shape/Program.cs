using Shape;

Console.WriteLine("*******Fun with Polymorphism*******");
Hexagon hex = new Hexagon("Beth");
hex.Draw();

Circle cir = new Circle("Cindy");
cir.Draw();

ThreeDCircle threeDCircle = new ThreeDCircle();
threeDCircle.Draw();
((Circle)(threeDCircle)).Draw();