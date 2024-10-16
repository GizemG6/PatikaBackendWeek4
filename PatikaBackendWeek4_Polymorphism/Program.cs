// create a square
Square square = new Square();
square.Width = 5.1;
Console.WriteLine($"Square area :{square.CalculateArea()}");

// create a rectangle
Rectangle rectangle = new Rectangle();
rectangle.Width = 6.3;
rectangle.Height = 4.3;
Console.WriteLine($"Rectangle area :{rectangle.CalculateArea()}");

//create a right triangle
RightTriangle rightTriangle = new RightTriangle();
rightTriangle.Width = 7.2;
rightTriangle.Height = 2.9;
Console.WriteLine($"Right triangle area :{rightTriangle.CalculateArea()}");