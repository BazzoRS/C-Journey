
//📘 System.Math – Methods and Short Descriptions

//Abs(x) – Returns the absolute value of a number.

//Acos(x) – Returns the arc cosine of a value (in radians).

//Acosh(x) – Returns the hyperbolic arc cosine.

//Asin(x) – Returns the arc sine of a value (in radians).

//Asinh(x) – Returns the hyperbolic arc sine.

//Atan(x) – Returns the arc tangent of a value.

//Atan2(y, x) – Returns the angle between the X-axis and the point (x, y).

//Atanh(x) – Returns the hyperbolic arc tangent.

//BigMul(a, b) – Multiplies two large integers and returns a 64-bit result to prevent overflow.

//Ceiling(x) – Rounds a number up to the smallest integral value greater than or equal to it.

//Clamp(value, min, max) – Restricts a value to be within a specified range.

//CopySign(x, y) – Returns a value with the magnitude of x and the sign of y.

//Cos(x) – Returns the cosine of an angle (in radians).

//Cosh(x) – Returns the hyperbolic cosine of a value.

//DivRem(a, b, out remainder) – Calculates the quotient and remainder of two integers.

//Exp(x) – Returns e raised to the power of x.

//Floor(x) – Rounds a number down to the largest integral value less than or equal to it.

//FusedMultiplyAdd(a, b, c) – Computes (a × b) + c as a single operation with higher precision.

//IEEERemainder(x, y) – Returns the remainder of a division using the IEEE 754 standard.

//Log(x) – Returns the natural logarithm (base e) of a number.

//Log(x, base) – Returns the logarithm of a number in the specified base.

//Log10(x) – Returns the base-10 logarithm of a number.

//Max(x, y) – Returns the larger of two numbers.

//Min(x, y) – Returns the smaller of two numbers.

//Pow(x, y) – Returns x raised to the power of y.

//Round(x) – Rounds a value to the nearest integer or specified number of decimal places.

//Sign(x) – Returns a value indicating the sign of a number (−1, 0, or 1).

//Sin(x) – Returns the sine of an angle (in radians).

//Sinh(x) – Returns the hyperbolic sine of a value.

//Sqrt(x) – Returns the square root of a number.

//Tan(x) – Returns the tangent of an angle (in radians).

//Tanh(x) – Returns the hyperbolic tangent of a value.

//Truncate(x) – Removes the fractional part of a number without rounding.

//-----------------------------------------------------------------------------------------------------------

// Testing different types of arithmetics

Console.WriteLine("\nProvide X value");

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nProvide Y value");

int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of X + Y is = {x+y}");
Console.WriteLine($"Subtration of X - Y is = {x - y}");
Console.WriteLine($"Multiplication of X * Y is = {x * y}");
Console.WriteLine($"Division of X / Y is = {(double)x / y}");
Console.WriteLine($"Mode of X * Y is = {x % y}");
Console.WriteLine($"Square root of X is {Math.Sqrt(x)}"); // Square root of X
Console.WriteLine($"X raised to the power of Y {Math.Pow(x,y)}"); // X raised to the power of Y