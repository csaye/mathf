public static class Mathf
{
    // Constants
    public const float Pi = 3.1415926536f;
    public const float E = 2.7182818285f;
    public const float Sqrt2 = 1.4142135624f;
    public const float Sqrt3 = 1.7320508076f;

    // Basic functions
    public static float Abs(float f) => f < 0 ? -f : f;
    public static int Ceil(float f) => f <= 0 || f == (int)f ? (int)f : (int)f + 1;
    public static float Clamp(float f, float min, float max) => f < min ? min : f > max ? max : f;
    public static int Floor(float f) => f < 0 ? (int)f - 1 : (int)f;
    public static float Max(float fa, float fb) => fa < fb ? fb : fa;
    public static float Min(float fa, float fb) => fb < fa ? fb : fa;
    public static int Round(float f) => f - Floor(f) >= 0.5f ? Ceil(f) : Floor(f);
    public static float Sign(float f) => f < 0 ? -1 : f > 0 ? 1 : 0;
    public static int Truncate(float f) => (int)f;

    // Degree functions
    public static float DegToRad(float d) => d * Pi / 180;
    public static float RadToDeg(float r) => r * 180 / Pi;

    // Exponent functions
    public static float Exp(int p) => Pow(E, p);
    public static float Pow(float f, int p)
    {
        float n = 1;
        for (int i = 0; i < Abs(p); i++) n *= f;
        return p < 0 ? 1 / n : n;
    }

    // Area functions
    public static float AreaCircle(float r) => Pi * r * r;
    public static float AreaCone(float r, float h) => Pi * r * r * h / 3;
    public static float AreaCube(float w) => w * w * w;
    public static float AreaCylinder(float r, float h) => Pi * r * r * h;
    public static float AreaEquiTri(float w) => w * w * Sqrt3 / 4;
    public static float AreaIsocTri(float w, float h) => w * h / 2;
    public static float AreaQuad(float w, float h, float l) => w * h * l;
    public static float AreaRect(float w, float h) => w * h;
    public static float AreaRightTri(float w, float h) => w * h / 2;
    public static float AreaSquare(float w) => w * w;
}
