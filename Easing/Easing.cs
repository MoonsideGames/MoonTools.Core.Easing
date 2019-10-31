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

        private static float OutIn(Func<float, float, float, float, float> outFunc,
                            Func<float, float, float, float, float> inFunc,
                            float t,
                            float b,
                            float c,
                            float d)
        {
            if (t < d / 2)
            {
                return outFunc(t * 2, b, c / 2, d);
            }
            else
            {
                return inFunc((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

        private static double NormalizedTime(Func<double, double, double, double, double> easingFunction, double t) => easingFunction(t, 0, 1, 1);
        private static double TimeRange(Func<double, double> easingFunction, double time, double start, double end) => start + (end - start) * easingFunction((time - start) / (end - start));

        private static double OutIn(Func<double, double, double, double, double> outFunc,
                                    Func<double, double, double, double, double> inFunc,
                                    double t,
                                    double b,
                                    double c,
                                    double d)
        {
            if (t < d / 2)
            {
                return outFunc(t * 2, b, c / 2, d);
            }
            else
            {
                return inFunc((t * 2) - d, b + c / 2, c / 2, d);
            }
        }

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
        public static float OutInQuad(float t, float b, float c, float d) => OutIn(OutQuad, InQuad, t, b, c, d);

        public static double OutInQuad(double t) => NormalizedTime(OutInQuad, t);
        public static double OutInQuad(double time, double start, double end) => TimeRange(OutInQuad, time, start, end);
        public static double OutInQuad(double t, double b, double c, double d) => OutIn(OutQuad, InQuad, t, b, c, d);

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
        public static float OutInCubic(float t, float b, float c, float d) => OutIn(OutCubic, InCubic, t, b, c, d);

        public static double OutInCubic(double t) => NormalizedTime(OutInCubic, t);
        public static double OutInCubic(double time, double start, double end) => TimeRange(OutInCubic, time, start, end);
        public static double OutInCubic(double t, double b, double c, double d) => OutIn(OutCubic, InCubic, t, b, c, d);

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
        public static float OutInQuart(float t, float b, float c, float d) => OutIn(OutQuart, InQuart, t, b, c, d);

        public static double OutInQuart(double t) => NormalizedTime(OutInQuart, t);
        public static double OutInQuart(double time, double start, double end) => TimeRange(OutInQuart, time, start, end);
        public static double OutInQuart(double t, double b, double c, double d) => OutIn(OutQuart, InQuart, t, b, c, d);

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
        public static float OutInQuint(float t, float b, float c, float d) => OutIn(OutQuint, InQuint, t, b, c, d);

        public static double OutInQuint(double t) => NormalizedTime(OutInQuint, t);
        public static double OutInQuint(double time, double start, double end) => TimeRange(OutInQuint, time, start, end);
        public static double OutInQuint(double t, double b, double c, double d) => OutIn(OutQuint, InQuint, t, b, c, d);

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
        public static double OutInSine(double t, double b, double c, double d) => OutIn(OutSine, InSine, t, b, c, d);

        // IN EXPONENTIAL

        public static double InExpo(double t) => NormalizedTime(InExpo, t);
        public static double InExpo(double time, double start, double end) => TimeRange(InExpo, time, start, end);

        public static double InExpo(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t == 0)
            {
                return b;
            }
            else
            {
                return c * Math.Pow(2, 10 * ((t / d) - 1)) + b - c * 0.001;
            }
        }

        // OUT EXPONENTIAL

        public static double OutExpo(double t) => NormalizedTime(OutExpo, t);
        public static double OutExpo(double time, double start, double end) => TimeRange(OutExpo, time, start, end);

        public static double OutExpo(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t == d)
            {
                return b + c;
            }
            else
            {
                return c * 1.001 * (-Math.Pow(2, -10 * t / d) + 1) + b;
            }
        }

        // IN OUT EXPONENTIAL

        public static double InOutExpo(double t) => NormalizedTime(InOutExpo, t);
        public static double InOutExpo(double time, double start, double end) => TimeRange(InOutExpo, time, start, end);

        public static double InOutExpo(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t == 0) { return b; }
            if (t == d) { return b + c; }
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * Math.Pow(2, 10 * (t - 1)) + b - c * 0.0005;
            }
            else
            {
                t = t - 1;
                return c / 2 * 1.0005 * (-Math.Pow(2, -10 * t) + 2) + b;
            }
        }

        // OUT IN EXPONENTIAL

        public static double OutInExpo(double t) => NormalizedTime(OutInExpo, t);
        public static double OutInExpo(double time, double start, double end) => TimeRange(OutInExpo, time, start, end);
        public static double OutInExpo(double t, double b, double c, double d) => OutIn(OutExpo, InExpo, t, b, c, d);

        // IN CIRCULAR

        public static double InCirc(double t) => NormalizedTime(InCirc, t);
        public static double InCirc(double time, double start, double end) => TimeRange(InCirc, time, start, end);

        public static double InCirc(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            return -c * (Math.Sqrt(1 - (t * t)) - 1) + b;
        }

        // OUT CIRCULAR

        public static double OutCirc(double t) => NormalizedTime(OutCirc, t);
        public static double OutCirc(double time, double start, double end) => TimeRange(OutCirc, time, start, end);

        public static double OutCirc(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * Math.Sqrt(1 - (t * t)) + b;
        }

        // IN OUT CIRCULAR

        public static double InOutCirc(double t) => NormalizedTime(InOutCirc, t);
        public static double InOutCirc(double time, double start, double end) => TimeRange(InOutCirc, time, start, end);

        public static double InOutCirc(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d * 2;
            if (t < 1)
            {
                return -c / 2 * (Math.Sqrt(1 - (t * t)) - 1) + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * (Math.Sqrt(1 - (t * t)) + 1) + b;
            }
        }

        // OUT IN CIRCULAR

        public static double OutInCirc(double t) => NormalizedTime(OutInCirc, t);
        public static double OutInCirc(double time, double start, double end) => TimeRange(OutInCirc, time, start, end);
        public static double OutInCirc(double t, double b, double c, double d) => OutIn(OutCirc, InCirc, t, b, c, d);

        // ELASTIC functions have two optional extra arguments
        // a: amplitude
        // p: period

        // IN ELASTIC

        public static double InElasticNormalized(double t) => InElastic(t, 0, 1, 1);
        public static double InElasticNormalized(double t, double a) => InElastic(t, 0, 1, 1, a);
        public static double InElasticNormalized(double t, double a, double p) => InElastic(t, 0, 1, 1, a, p);

        public static double InElasticTimeRange(double time, double start, double end) => start + (end - start) * InElasticNormalized((time - start) / (end - start));
        public static double InElasticTimeRange(double time, double start, double end, double a) => start + (end - start) * InElasticNormalized((time - start) / (end - start), a);
        public static double InElasticTimeRange(double time, double start, double end, double a, double p) => start + (end - start) * InElasticNormalized((time - start) / (end - start), a, p);

        public static double InElastic(double t, double b, double c, double d, double? a = null, double? p = null)
        {
            CheckTime(t, d);

            if (t == 0) { return b; }

            t = t / d;

            if (t == 1) { return b + c; }

            if (!p.HasValue) { p = d * 0.3; }

            double s;
            if (!a.HasValue || a.Value < Math.Abs(c))
            {
                a = c;
                s = p.Value / 4;
            }
            else
            {
                s = p.Value / (2 * Math.PI) * Math.Asin(c / a.Value);
            }

            t = t - 1;

            return -(a.Value * Math.Pow(2, 10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p.Value)) + b;
        }

        // OUT ELASTIC

        public static double OutElasticNormalized(double t) => OutElastic(t, 0, 1, 1);
        public static double OutElasticNormalized(double t, double a) => OutElastic(t, 0, 1, 1, a);
        public static double OutElasticNormalized(double t, double a, double p) => OutElastic(t, 0, 1, 1, a, p);

        public static double OutElasticTimeRange(double time, double start, double end) => start + (end - start) * OutElasticNormalized((time - start) / (end - start));
        public static double OutElasticTimeRange(double time, double start, double end, double a) => start + (end - start) * OutElasticNormalized((time - start) / (end - start), a);
        public static double OutElasticTimeRange(double time, double start, double end, double a, double p) => start + (end - start) * OutElasticNormalized((time - start) / (end - start), a, p);

        public static double OutElastic(double t, double b, double c, double d, double? a = null, double? p = null)
        {
            CheckTime(t, d);

            if (t == 0) { return b; }

            t = t / d;

            if (t == 1) { return b + c; }

            if (!p.HasValue) { p = d * 0.3; }

            double s;

            if (!a.HasValue || a.Value < Math.Abs(c))
            {
                a = c;
                s = p.Value / 4;
            }
            else
            {
                s = p.Value / (2 * Math.PI) * Math.Asin(c / a.Value);
            }

            return a.Value * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p.Value) + c + b;
        }

        // IN OUT ELASTIC

        public static double InOutElasticNormalized(double t) => InOutElastic(t, 0, 1, 1);
        public static double InOutElasticNormalized(double t, double a) => InOutElastic(t, 0, 1, 1, a);
        public static double InOutElasticNormalized(double t, double a, double p) => InOutElastic(t, 0, 1, 1, a, p);

        public static double InOutElasticTimeRange(double time, double start, double end) => start + (end - start) * InOutElasticNormalized((time - start) / (end - start));
        public static double InOutElasticTimeRange(double time, double start, double end, double a) => start + (end - start) * InOutElasticNormalized((time - start) / (end - start), a);
        public static double InOutElasticTimeRange(double time, double start, double end, double a, double p) => start + (end - start) * InOutElasticNormalized((time - start) / (end - start), a, p);

        public static double InOutElastic(double t, double b, double c, double d, double? a = null, double? p = null)
        {
            CheckTime(t, d);

            if (t == 0) { return b; }

            t = t / d * 2;

            if (t == 2) { return b + c; }

            if (!p.HasValue) { p = d * (0.3 * 1.5); }
            if (!a.HasValue) { a = 0; }

            double s;

            if (!a.HasValue || a < Math.Abs(c))
            {
                a = c;
                s = p.Value / 4;
            }
            else
            {
                s = p.Value / (2 * Math.PI) * Math.Asin(c / a.Value);
            }

            if (t < 1)
            {
                t = t - 1;
                return -0.5 * (a.Value * Math.Pow(2, 10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p.Value)) + b;
            }
            else
            {
                t = t - 1;
                return a.Value * Math.Pow(2, -10 * t) * Math.Sin((t * d - s) * (2 * Math.PI) / p.Value) * 0.5 + c + b;
            }
        }

        // OUT IN ELASTIC

        public static double OutInElasticNormalized(double t) => OutInElastic(t, 0, 1, 1);
        public static double OutInElasticNormalized(double t, double a) => OutInElastic(t, 0, 1, 1, a);
        public static double OutInElasticNormalized(double t, double a, double p) => OutInElastic(t, 0, 1, 1, a, p);

        public static double OutInElasticTimeRange(double time, double start, double end) => start + (end - start) * OutInElasticNormalized((time - start) / (end - start));
        public static double OutInElasticTimeRange(double time, double start, double end, double a) => start + (end - start) * OutInElasticNormalized((time - start) / (end - start), a);
        public static double OutInElasticTimeRange(double time, double start, double end, double a, double p) => start + (end - start) * OutInElasticNormalized((time - start) / (end - start), a, p);

        public static double OutInElastic(double t, double b, double c, double d, double? a = null, double? p = null)
        {
            if (t < d / 2)
            {
                return OutElastic(t * 2, b, c / 2, d, a, p);
            }
            else
            {
                return InElastic((t * 2) - d, b + c / 2, c / 2, d, a, p);
            }
        }

        // back functions take an optional parameter
        // s: size

        // IN BACK

        public static double InBackNormalized(double t) => InBack(t, 0, 1, 1);
        public static double InBackNormalized(double t, double s) => InBack(t, 0, 1, 1, s);
        public static double InBackTimeRange(double time, double start, double end) => start + (end - start) * InBackNormalized((time - start) / (end - start));
        public static double InBackTimeRange(double time, double start, double end, double s) => start + (end - start) * InBackNormalized((time - start) / (end - start), s);

        public static double InBack(double t, double b, double c, double d, double s = 1.70158)
        {
            CheckTime(t, d);
            t = t / d;
            return c * t * t * ((s + 1) * t - s) + b;
        }

        // OUT BACK

        public static double OutBackNormalized(double t) => OutBack(t, 0, 1, 1);
        public static double OutBackNormalized(double t, double s) => OutBack(t, 0, 1, 1, s);
        public static double OutBackTimeRange(double time, double start, double end) => start + (end - start) * OutBackNormalized((time - start) / (end - start));
        public static double OutBackTimeRange(double time, double start, double end, double s) => start + (end - start) * OutBackNormalized((time - start) / (end - start), s);

        public static double OutBack(double t, double b, double c, double d, double s = 1.70158)
        {
            CheckTime(t, d);
            t = t / d - 1;
            return c * (t * t * ((s + 1) * t + s) + 1) + b;
        }

        // IN OUT BACK

        public static double InOutBackNormalized(double t) => InOutBack(t, 0, 1, 1);
        public static double InOutBackNormalized(double t, double s) => InOutBack(t, 0, 1, 1, s);
        public static double InOutBackTimeRange(double time, double start, double end) => start + (end - start) * InOutBackNormalized((time - start) / (end - start));
        public static double InOutBackTimeRange(double time, double start, double end, double s) => start + (end - start) * InOutBackNormalized((time - start) / (end - start), s);

        public static double InOutBack(double t, double b, double c, double d, double s = 1.70158)
        {
            CheckTime(t, d);
            s = s * 1.525;
            t = t / d * 2;
            if (t < 1)
            {
                return c / 2 * (t * t * ((s + 1) * t - s)) + b;
            }
            else
            {
                t = t - 2;
                return c / 2 * (t * t * ((s + 1) * t + s) + 2) + b;
            }
        }

        // OUT IN BACK

        public static double OutInBackNormalized(double t) => OutInBack(t, 0, 1, 1);
        public static double OutInBackNormalized(double t, double s) => OutInBack(t, 0, 1, 1, s);
        public static double OutInBackTimeRange(double time, double start, double end) => start + (end - start) * OutInBackNormalized((time - start) / (end - start));
        public static double OutInBackTimeRange(double time, double start, double end, double s) => start + (end - start) * OutInBackNormalized((time - start) / (end - start), s);

        public static double OutInBack(double t, double b, double c, double d, double s = 1.70158)
        {
            if (t < d / 2)
            {
                return OutBack(t * 2, b, c / 2, d, s);
            }
            else
            {
                return InBack((t * 2) - d, b + c / 2, c / 2, d, s);
            }
        }

        // OUT BOUNCE

        public static double OutBounce(double t) => NormalizedTime(OutBounce, t);
        public static double OutBounce(double time, double start, double end) => TimeRange(OutBounce, time, start, end);

        public static double OutBounce(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            t = t / d;
            if (t < 1 / 2.75)
            {
                return c * (7.5625 * t * t) + b;
            }
            else if (t < 2 / 2.75)
            {
                t = t - (1.5 / 2.75);
                return c * (7.5625 * t * t + 0.75) + b;
            }
            else if (t < 2.5 / 2.75)
            {
                t = t - (2.25 / 2.75);
                return c * (7.5625 * t * t + 0.9375) + b;
            }
            else
            {
                t = t - (2.625 / 2.75);
                return c * (7.5625 * t * t + 0.984375) + b;
            }
        }

        // IN BOUNCE

        public static double InBounce(double t) => NormalizedTime(InBounce, t);
        public static double InBounce(double time, double start, double end) => TimeRange(InBounce, time, start, end);

        public static double InBounce(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            return c - OutBounce(d - t, 0, c, d) + b;
        }

        // IN OUT BOUNCE

        public static double InOutBounce(double t) => NormalizedTime(InOutBounce, t);
        public static double InOutBounce(double time, double start, double end) => TimeRange(InOutBounce, time, start, end);

        public static double InOutBounce(double t, double b, double c, double d)
        {
            CheckTime(t, d);
            if (t < d / 2)
            {
                return InBounce(t * 2, 0, c, d) * 0.5 + b;
            }
            else
            {
                return OutBounce(t * 2 - d, 0, c, d) * 0.5 + c * 0.5 + b;
            }
        }

        // OUT IN BOUNCE

        public static double OutInBounce(double t) => NormalizedTime(OutInBounce, t);
        public static double OutInBounce(double time, double start, double end) => TimeRange(OutInBounce, time, start, end);
        public static double OutInBounce(double t, double b, double c, double d) => OutIn(OutBounce, InBounce, t, b, c, d);
    }
}
