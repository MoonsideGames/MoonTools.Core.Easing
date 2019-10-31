using System;

namespace MoonTools.Core.Easing
{
    public static class Easing
    {
        // argument checker

        private static void CheckTime(float time, float duration)
        {
            if (time > duration) { throw new ArgumentException($"{time} is invalid. Must be less than {duration}."); }
        }

        private static void CheckTime(double time, double duration)
        {
            if (time > duration) { throw new ArgumentException($"{time} is invalid. Must be less than {duration}."); }
        }

        // function transformations
        private static float NormalizedTime(Func<float, float, float, float, float> easingFunction, float t) => easingFunction(t, 0, 1, 1);
        private static float TimeRange(Func<float, float> easingFunction, float time, float start, float end) => start + (end - start) * easingFunction((time - start) / (end - start));

        private static double NormalizedTime(Func<double, double, double, double, double> easingFunction, double t) => easingFunction(t, 0, 1, 1);
        private static double TimeRange(Func<double, double> easingFunction, double time, double start, double end) => start + (end - start) * easingFunction((time - start) / (end - start));

        /********* EASING FUNCTIONS ********/

        // LINEAR

        public static float Linear(float t) => NormalizedTime(Linear, t);
        public static float Linear(float time, float start, float end) => TimeRange(Linear, time, start, end);

        public static float Linear(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            return c * t / d + b;
        }

        public static double Linear(double t) => NormalizedTime(Linear, t);
        public static double Linear(double time, double start, double end) => TimeRange(Linear, time, start, end);

        public static double Linear(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return c * t / d + b;
        }

        // IN QUAD

        public static float InQuad(float t) => NormalizedTime(InQuad, t);
        public static float InQuad(float time, float start, float end) => TimeRange(InQuad, time, start, end);

        public static float InQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t) + b;
        }

        public static double InQuad(double t) => NormalizedTime(InQuad, t);
        public static double InQuad(double time, double start, double end) => TimeRange(InQuad, time, start, end);

        public static double InQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t) + b;
        }

        // OUT QUAD

        public static float OutQuad(float t) => NormalizedTime(OutQuad, t);
        public static float OutQuad(float time, float start, float end) => TimeRange(OutQuad, time, start, end);

        public static float OutQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * t * (t - 2) + b;
        }

        public static double OutQuad(double t) => NormalizedTime(OutQuad, t);
        public static double OutQuad(double time, double start, double end) => TimeRange(OutQuad, time, start, end);

        public static double OutQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * t * (t - 2) + b;
        }

        // IN OUT QUAD

        public static float InOutQuad(float t) => NormalizedTime(InOutQuad, t);
        public static float InOutQuad(float time, float start, float end) => TimeRange(InOutQuad, time, start, end);

        public static float InOutQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t) + b;
            }
            else
            {
                return -c / 2 * ((t - 1) * (t - 3) - 1) + b;
            }
        }

        public static double InOutQuad(double t) => NormalizedTime(InOutQuad, t);
        public static double InOutQuad(double time, double start, double end) => TimeRange(InOutQuad, time, start, end);

        public static double InOutQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t) + b;
            }
            else
            {
                return -c / 2 * ((t - 1) * (t - 3) - 1) + b;
            }
        }

        // OUT IN QUAD

        public static float OutInQuad(float t) => NormalizedTime(OutInQuad, t);
        public static float OutInQuad(float time, float start, float end) => TimeRange(OutInQuad, time, start, end);

        public static float OutInQuad(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuad(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuad((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static double OutInQuad(double t) => NormalizedTime(OutInQuad, t);
        public static double OutInQuad(double time, double start, double end) => TimeRange(OutInQuad, time, start, end);

        public static double OutInQuad(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuad(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuad((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        // IN CUBIC

        public static float InCubic(float t) => NormalizedTime(InCubic, t);
        public static float InCubic(float time, float start, float end) => TimeRange(InCubic, time, start, end);

        public static float InCubic(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t) + b;
        }

        public static double InCubic(double t) => NormalizedTime(InCubic, t);
        public static double InCubic(double time, double start, double end) => TimeRange(InCubic, time, start, end);

        public static double InCubic(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t) + b;
        }

        // OUT CUBIC

        public static float OutCubic(float t) => NormalizedTime(OutCubic, t);
        public static float OutCubic(float time, float start, float end) => TimeRange(OutCubic, time, start, end);

        public static float OutCubic(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * (t * t * t + 1) + b;
        }

        public static double OutCubic(double t) => NormalizedTime(OutCubic, t);
        public static double OutCubic(double time, double start, double end) => TimeRange(OutCubic, time, start, end);

        public static double OutCubic(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * (t * t * t + 1) + b;
        }

        // IN OUT CUBIC

        public static float InOutCubic(float t) => NormalizedTime(InOutCubic, t);
        public static float InOutCubic(float time, float start, float end) => TimeRange(InOutCubic, time, start, end);

        public static float InOutCubic(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * t * t * t + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * (t * t * t + 2) + b;
            }
        }

        // IN OUT CUBIC

        public static double InOutCubic(double t) => NormalizedTime(InOutCubic, t);
        public static double InOutCubic(double time, double start, double end) => TimeRange(InOutCubic, time, start, end);

        public static double InOutCubic(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * t * t * t + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * (t * t * t + 2) + b;
            }
        }

        // OUT IN CUBIC

        public static float OutInCubic(float t) => NormalizedTime(OutInCubic, t);
        public static float OutInCubic(float time, float start, float end) => TimeRange(OutInCubic, time, start, end);

        public static float OutInCubic(float t, float b, float c, float d)
        {
            if (t < d / 2)
            {
                return OutCubic(t * 2, b, c / 2, d);
            }
            else
            {
                return InCubic((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static double OutInCubic(double t) => NormalizedTime(OutInCubic, t);
        public static double OutInCubic(double time, double start, double end) => TimeRange(OutInCubic, time, start, end);

        public static double OutInCubic(double t, double b, double c, double d)
        {
            if (t < d / 2)
            {
                return OutCubic(t * 2, b, c / 2, d);
            }
            else
            {
                return InCubic((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        // IN QUARTIC

        public static float InQuart(float t) => NormalizedTime(InQuart, t);
        public static float InQuart(float time, float start, float end) => TimeRange(InQuart, time, start, end);

        public static float InQuart(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t * t) + b;
        }

        public static double InQuart(double t) => NormalizedTime(InQuart, t);
        public static double InQuart(double time, double start, double end) => TimeRange(InQuart, time, start, end);

        public static double InQuart(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t * t) + b;
        }

        // OUT QUARTIC

        public static float OutQuart(float t) => NormalizedTime(OutQuart, t);
        public static float OutQuart(float time, float start, float end) => TimeRange(OutQuart, time, start, end);

        public static float OutQuart(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return -c * ((t * t * t * t) - 1) + b;
        }

        public static double OutQuart(double t) => NormalizedTime(OutQuart, t);
        public static double OutQuart(double time, double start, double end) => TimeRange(OutQuart, time, start, end);

        public static double OutQuart(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return -c * ((t * t * t * t) - 1) + b;
        }

        // IN OUT QUARTIC

        public static float InOutQuart(float t) => NormalizedTime(InOutQuart, t);
        public static float InOutQuart(float time, float start, float end) => TimeRange(InOutQuart, time, start, end);

        public static float InOutQuart(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t * t * t) + b;
            }
            else
            {
                t = t - 2;
                return -c / 2 * ((t * t * t * t) - 2) + b;
            }
        }

        public static double InOutQuart(double t) => NormalizedTime(InOutQuart, t);
        public static double InOutQuart(double time, double start, double end) => TimeRange(InOutQuart, time, start, end);

        public static double InOutQuart(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t * t * t) + b;
            }
            else
            {
                t = t - 2;
                return -c / 2 * ((t * t * t * t) - 2) + b;
            }
        }

        // OUT IN QUARTIC

        public static float OutInQuart(float t) => NormalizedTime(OutInQuart, t);
        public static float OutInQuart(float time, float start, float end) => TimeRange(OutInQuart, time, start, end);

        public static float OutInQuart(float t, float b, float c, float d)
        {
            if (t < d / 2)
            {
                return OutQuart(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuart((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static double OutInQuart(double t) => NormalizedTime(OutInQuart, t);
        public static double OutInQuart(double time, double start, double end) => TimeRange(OutInQuart, time, start, end);

        public static double OutInQuart(double t, double b, double c, double d)
        {
            if (t < d / 2)
            {
                return OutQuart(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuart((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        // IN QUINTIC

        public static float InQuint(float t) => NormalizedTime(InQuint, t);
        public static float InQuint(float time, float start, float end) => TimeRange(InQuint, time, start, end);

        public static float InQuint(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t * t * t) + b;
        }

        public static double InQuint(double t) => NormalizedTime(InQuint, t);
        public static double InQuint(double time, double start, double end) => TimeRange(InQuint, time, start, end);

        public static double InQuint(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return c * (t * t * t * t * t) + b;
        }

        // OUT QUINTIC

        public static float OutQuint(float t) => NormalizedTime(OutQuint, t);
        public static float OutQuint(float time, float start, float end) => TimeRange(OutQuint, time, start, end);

        public static float OutQuint(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * ((t * t * t * t * t) + 1) + b;
        }

        public static double OutQuint(double t) => NormalizedTime(OutQuint, t);
        public static double OutQuint(double time, double start, double end) => TimeRange(OutQuint, time, start, end);

        public static double OutQuint(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * ((t * t * t * t * t) + 1) + b;
        }

        // IN OUT QUINTIC

        public static float InOutQuint(float t) => NormalizedTime(InOutQuint, t);
        public static float InOutQuint(float time, float start, float end) => TimeRange(InOutQuint, time, start, end);

        public static float InOutQuint(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t * t * t * t) + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * ((t * t * t * t * t) + 2) + b;
            }
        }

        public static double InOutQuint(double t) => NormalizedTime(InOutQuint, t);
        public static double InOutQuint(double time, double start, double end) => TimeRange(InOutQuint, time, start, end);

        public static double InOutQuint(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t * t * t * t) + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * ((t * t * t * t * t) + 2) + b;
            }
        }

        // OUT IN QUINTIC

        public static float OutInQuint(float t) => NormalizedTime(OutInQuint, t);
        public static float OutInQuint(float time, float start, float end) => TimeRange(OutInQuint, time, start, end);

        public static float OutInQuint(float t, float b, float c, float d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuint(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuint((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        public static double OutInQuint(double t) => NormalizedTime(OutInQuint, t);
        public static double OutInQuint(double time, double start, double end) => TimeRange(OutInQuint, time, start, end);

        public static double OutInQuint(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return OutQuint(t * 2, b, c / 2, d);
            }
            else
            {
                return InQuint((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        // note: no float implementations because trig functions are double precision

        // IN SINE

        public static double InSine(double t) => NormalizedTime(InSine, t);
        public static double InSine(double time, double start, double end) => TimeRange(InSine, time, start, end);

        public static double InSine(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return -c * Math.Cos(t / d * (Math.PI / 2)) + c + b;
        }

        // OUT SINE

        public static double OutSine(double t) => NormalizedTime(OutSine, t);
        public static double OutSine(double time, double start, double end) => TimeRange(OutSine, time, start, end);

        public static double OutSine(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return c * Math.Sin(t / d * (Math.PI / 2)) + b;
        }

        // IN OUT SINE

        public static double InOutSine(double t) => NormalizedTime(InOutSine, t);
        public static double InOutSine(double time, double start, double end) => TimeRange(InOutSine, time, start, end);

        public static double InOutSine(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return -c / 2 * (Math.Cos(Math.PI * t / d) - 1) + b;
        }

        // OUT IN SINE

        public static double OutInSine(double t) => NormalizedTime(OutInSine, t);
        public static double OutInSine(double time, double start, double end) => TimeRange(OutInSine, time, start, end);

        public static double OutInSine(double t, double b, double c, double d)
        {
            if (t < d / 2)
            {
                return OutSine(t * 2, b, c / 2, d);
            }
            else
            {
                return InSine((t * 2) - d, b + c / 2, c / 2, d);
            }
        }
    }
}
