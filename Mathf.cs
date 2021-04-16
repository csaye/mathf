public static class Mathf
{
    public static float Abs(float f) => f < 0 ? -f : f;
    public static int Ceil(float f) => f <= 0 || f == (int)f ? (int)f : (int)f + 1;
    public static float Clamp(float f, float min, float max) => f < min ? min : f > max ? max : f;
    public static int Floor(float f) => f < 0 ? (int)f - 1 : (int)f;
    public static float Max(float fa, float fb) => fa < fb ? fb : fa;
    public static float Min(float fa, float fb) => fb < fa ? fb : fa;
    public static float Sign(float f) => f < 0 ? -1 : f > 0 ? 1 : 0;
    public static int Truncate(float f) => (int)f;
}
