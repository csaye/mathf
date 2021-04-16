public static class Mathf
{
    public const float Pi = 3.1415926536f;
    public const float E = 2.7182818285f;

    public static float Abs(float f) => f < 0 ? -f : f;
    public static int Ceil(float f) => f <= 0 || f == (int)f ? (int)f : (int)f + 1;
    public static float Clamp(float f, float min, float max) => f < min ? min : f > max ? max : f;
    public static float DegToRad(float d) => d * Pi / 180;
    public static float Exp(int p) => Pow(E, p);
    public static int Floor(float f) => f < 0 ? (int)f - 1 : (int)f;
    public static float Max(float fa, float fb) => fa < fb ? fb : fa;
    public static float Min(float fa, float fb) => fb < fa ? fb : fa;
    public static float Pow(float f, int p)
    {
        float n = 1;
        for (int i = 0; i < Abs(p); i++) n *= f;
        return p < 0 ? 1 / n : n;
    }
    public static float RadToDeg(float r) => r * 180 / Pi;
    public static int Round(float f) => f - Floor(f) >= 0.5f ? Ceil(f) : Floor(f);
    public static float Sign(float f) => f < 0 ? -1 : f > 0 ? 1 : 0;
    public static int Truncate(float f) => (int)f;
}
