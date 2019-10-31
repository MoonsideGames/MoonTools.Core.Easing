using NUnit.Framework;
using FluentAssertions;

using MoonTools.Core.Easing;
using System;

namespace Test
{
    public class EasingTests
    {
        public static void CheckFloatArguments(Func<float, float> easingNormalizedFunction, Func<float, float, float, float> easingRangeFunction)
        {
            Action invalidTime = () => easingNormalizedFunction(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            invalidTime = () => easingRangeFunction(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();
        }

        public static void CheckDoubleArguments(Func<double, double> easingNormalizedFunction, Func<double, double, double, double> easingRangeFunction)
        {
            Action invalidTime = () => easingNormalizedFunction(1.5);
            invalidTime.Should().Throw<ArgumentException>();

            invalidTime = () => easingRangeFunction(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();
        }

        public class FloatTests
        {
            [Test]
            public void Linear()
            {
                Easing.Linear(0.25f).Should().Be(0.25f);
                Easing.Linear(0.5f).Should().Be(0.5f);
                Easing.Linear(0.75f).Should().Be(0.75f);

                Easing.Linear(3, 2, 6).Should().Be(3f);
                Easing.Linear(4, 2, 6).Should().Be(4f);
                Easing.Linear(5, 2, 6).Should().Be(5f);

                CheckFloatArguments(Easing.Linear, Easing.Linear);
            }

            [Test]
            public void InQuad()
            {
                Easing.InQuad(0.25f).Should().Be(0.0625f);
                Easing.InQuad(0.5f).Should().Be(0.25f);
                Easing.InQuad(0.75f).Should().Be(0.5625f);

                Easing.InQuad(3, 2, 6).Should().Be(2.25f);
                Easing.InQuad(4, 2, 6).Should().Be(3f);
                Easing.InQuad(5, 2, 6).Should().Be(4.25f);

                CheckFloatArguments(Easing.InQuad, Easing.InQuad);
            }

            [Test]
            public void OutQuad()
            {
                Easing.OutQuad(0.25f).Should().Be(0.4375f);
                Easing.OutQuad(0.5f).Should().Be(0.75f);
                Easing.OutQuad(0.75f).Should().Be(0.9375f);

                Easing.OutQuad(3, 2, 6).Should().Be(3.75f);
                Easing.OutQuad(4, 2, 6).Should().Be(5f);
                Easing.OutQuad(5, 2, 6).Should().Be(5.75f);

                CheckFloatArguments(Easing.OutQuad, Easing.OutQuad);
            }

            [Test]
            public void InOutQuad()
            {
                Easing.InOutQuad(0.25f).Should().Be(0.125f);
                Easing.InOutQuad(0.5f).Should().Be(0.5f);
                Easing.InOutQuad(0.75f).Should().Be(0.875f);

                Easing.InOutQuad(3, 2, 6).Should().Be(2.5f);
                Easing.InOutQuad(4, 2, 6).Should().Be(4f);
                Easing.InOutQuad(5, 2, 6).Should().Be(5.5f);

                CheckFloatArguments(Easing.InOutQuad, Easing.InOutQuad);
            }

            [Test]
            public void OutInQuad()
            {
                Easing.OutInQuad(0.25f).Should().Be(0.375f);
                Easing.OutInQuad(0.5f).Should().Be(0.5f);
                Easing.OutInQuad(0.75f).Should().Be(0.625f);

                Easing.OutInQuad(3, 2, 6).Should().Be(3.5f);
                Easing.OutInQuad(4, 2, 6).Should().Be(4f);
                Easing.OutInQuad(5, 2, 6).Should().Be(4.5f);

                CheckFloatArguments(Easing.OutInQuad, Easing.OutInQuad);
            }

            [Test]
            public void InCubic()
            {
                Easing.InCubic(0.25f).Should().Be(0.015625f);
                Easing.InCubic(0.5f).Should().Be(0.125f);
                Easing.InCubic(0.75f).Should().Be(0.421875f);

                Easing.InCubic(3, 2, 6).Should().Be(2.0625f);
                Easing.InCubic(4, 2, 6).Should().Be(2.5f);
                Easing.InCubic(5, 2, 6).Should().Be(3.6875f);

                CheckFloatArguments(Easing.InCubic, Easing.InCubic);
            }

            [Test]
            public void OutCubic()
            {
                Easing.OutCubic(0.25f).Should().Be(0.578125f);
                Easing.OutCubic(0.5f).Should().Be(0.875f);
                Easing.OutCubic(0.75f).Should().Be(0.984375f);

                Easing.OutCubic(3, 2, 6).Should().Be(4.3125f);
                Easing.OutCubic(4, 2, 6).Should().Be(5.5f);
                Easing.OutCubic(5, 2, 6).Should().Be(5.9375f);

                CheckFloatArguments(Easing.OutCubic, Easing.OutCubic);
            }

            [Test]
            public void InOutCubic()
            {
                Easing.InOutCubic(0.25f).Should().Be(0.0625f);
                Easing.InOutCubic(0.5f).Should().Be(0.5f);
                Easing.InOutCubic(0.75f).Should().Be(0.9375f);

                Easing.InOutCubic(3, 2, 6).Should().Be(2.25f);
                Easing.InOutCubic(4, 2, 6).Should().Be(4f);
                Easing.InOutCubic(5, 2, 6).Should().Be(5.75f);

                CheckFloatArguments(Easing.InOutCubic, Easing.InOutCubic);
            }

            [Test]
            public void OutInCubic()
            {
                Easing.OutInCubic(0.25f).Should().Be(0.4375f);
                Easing.OutInCubic(0.5f).Should().Be(0.5f);
                Easing.OutInCubic(0.75f).Should().Be(0.5625f);

                Easing.OutInCubic(3, 2, 6).Should().Be(3.75f);
                Easing.OutInCubic(4, 2, 6).Should().Be(4f);
                Easing.OutInCubic(5, 2, 6).Should().Be(4.25f);

                CheckFloatArguments(Easing.OutInCubic, Easing.OutInCubic);
            }

            [Test]
            public void InQuartic()
            {
                Easing.InQuart(0.25f).Should().Be(0.00390625f);
                Easing.InQuart(0.5f).Should().Be(0.0625f);
                Easing.InQuart(0.75f).Should().Be(0.31640625f);

                Easing.InQuart(3, 2, 6).Should().Be(2.015625f);
                Easing.InQuart(4, 2, 6).Should().Be(2.25f);
                Easing.InQuart(5, 2, 6).Should().Be(3.265625f);

                CheckFloatArguments(Easing.InQuart, Easing.InQuart);
            }

            [Test]
            public void OutQuartic()
            {
                Easing.OutQuart(0.25f).Should().Be(0.68359375f);
                Easing.OutQuart(0.5f).Should().Be(0.9375f);
                Easing.OutQuart(0.75f).Should().Be(0.99609375f);

                Easing.OutQuart(3, 2, 6).Should().Be(4.734375f);
                Easing.OutQuart(4, 2, 6).Should().Be(5.75f);
                Easing.OutQuart(5, 2, 6).Should().Be(5.984375f);

                CheckFloatArguments(Easing.OutQuart, Easing.OutQuart);
            }

            [Test]
            public void InOutQuartic()
            {
                Easing.InOutQuart(0.25f).Should().Be(0.03125f);
                Easing.InOutQuart(0.5f).Should().Be(0.5f);
                Easing.InOutQuart(0.75f).Should().Be(0.96875f);

                Easing.InOutQuart(3, 2, 6).Should().Be(2.125f);
                Easing.InOutQuart(4, 2, 6).Should().Be(4f);
                Easing.InOutQuart(5, 2, 6).Should().Be(5.875f);

                CheckFloatArguments(Easing.InOutQuart, Easing.InOutQuart);
            }

            [Test]
            public void OutInQuartic()
            {
                Easing.OutInQuart(0.25f).Should().Be(0.46875f);
                Easing.OutInQuart(0.5f).Should().Be(0.5f);
                Easing.OutInQuart(0.75f).Should().Be(0.53125f);

                Easing.OutInQuart(3, 2, 6).Should().Be(3.875f);
                Easing.OutInQuart(4, 2, 6).Should().Be(4f);
                Easing.OutInQuart(5, 2, 6).Should().Be(4.125f);

                CheckFloatArguments(Easing.OutInQuart, Easing.OutInQuart);
            }

            [Test]
            public void InQuintic()
            {
                Easing.InQuint(0.25f).Should().Be(0.0009765625f);
                Easing.InQuint(0.5f).Should().Be(0.03125f);
                Easing.InQuint(0.75f).Should().Be(0.2373046875f);

                Easing.InQuint(3, 2, 6).Should().Be(2.00390625f);
                Easing.InQuint(4, 2, 6).Should().Be(2.125f);
                Easing.InQuint(5, 2, 6).Should().Be(2.94921875f);

                CheckFloatArguments(Easing.InQuint, Easing.InQuint);
            }

            [Test]
            public void OutQuintic()
            {
                Easing.OutQuint(0.25f).Should().Be(0.7626953125f);
                Easing.OutQuint(0.5f).Should().Be(0.96875f);
                Easing.OutQuint(0.75f).Should().Be(0.9990234375f);

                Easing.OutQuint(3, 2, 6).Should().Be(5.05078125f);
                Easing.OutQuint(4, 2, 6).Should().Be(5.875f);
                Easing.OutQuint(5, 2, 6).Should().Be(5.99609375f);

                CheckFloatArguments(Easing.OutQuint, Easing.OutQuint);
            }

            [Test]
            public void InOutQuintic()
            {
                Easing.InOutQuint(0.25f).Should().Be(0.015625f);
                Easing.InOutQuint(0.5f).Should().Be(0.5f);
                Easing.InOutQuint(0.75f).Should().Be(0.984375f);

                Easing.InOutQuint(3, 2, 6).Should().Be(2.0625f);
                Easing.InOutQuint(4, 2, 6).Should().Be(4f);
                Easing.InOutQuint(5, 2, 6).Should().Be(5.9375f);

                CheckFloatArguments(Easing.InOutQuint, Easing.InOutQuint);
            }

            [Test]
            public void OutInQuintic()
            {
                Easing.OutInQuint(0.25f).Should().Be(0.484375f);
                Easing.OutInQuint(0.5f).Should().Be(0.5f);
                Easing.OutInQuint(0.75f).Should().Be(0.515625f);

                Easing.OutInQuint(3, 2, 6).Should().Be(3.9375f);
                Easing.OutInQuint(4, 2, 6).Should().Be(4f);
                Easing.OutInQuint(5, 2, 6).Should().Be(4.0625f);

                CheckFloatArguments(Easing.OutInQuint, Easing.OutInQuint);
            }

            [Test]
            public void InSine()
            {
                Easing.InSine(0.25f).Should().BeApproximately(0.076120467488713f, 0.0001f);
                Easing.InSine(0.5f).Should().BeApproximately(0.29289321881345f, 0.0001f);
                Easing.InSine(0.75f).Should().BeApproximately(0.61731656763491f, 0.0001f);

                Easing.InSine(3f, 2, 6).Should().BeApproximately(2.304481869955f, 0.0001f);
                Easing.InSine(4f, 2, 6).Should().BeApproximately(3.17157287525f, 0.0001f);
                Easing.InSine(5f, 2, 6).Should().BeApproximately(4.46926627054f, 0.0001f);

                Action invalidTime = () => Easing.InSine(1.5f);
                invalidTime.Should().Throw<ArgumentException>();

                invalidTime = () => Easing.InSine(7f, 2, 6);
                invalidTime.Should().Throw<ArgumentException>();
            }

            [Test]
            public void OutSine()
            {
                Easing.OutSine(0.25f).Should().BeApproximately(0.38268343236509f, 0.0001f);
                Easing.OutSine(0.5f).Should().BeApproximately(0.70710678118655f, 0.0001f);
                Easing.OutSine(0.75f).Should().BeApproximately(0.92387953251129f, 0.0001f);

                Easing.OutSine(3f, 2, 6).Should().BeApproximately(3.53073372946f, 0.0001f);
                Easing.OutSine(4f, 2, 6).Should().BeApproximately(4.82842712475f, 0.0001f);
                Easing.OutSine(5f, 2, 6).Should().BeApproximately(5.69551813005f, 0.0001f);

                Action invalidTime = () => Easing.OutSine(1.5f);
                invalidTime.Should().Throw<ArgumentException>();

                invalidTime = () => Easing.OutSine(7f, 2, 6);
                invalidTime.Should().Throw<ArgumentException>();
            }

            [Test]
            public void InOutSine()
            {
                Easing.InOutSine(0.25f).Should().BeApproximately(0.14644660940673f, 0.0001f);
                Easing.InOutSine(0.5f).Should().BeApproximately(0.5f, 0.0001f);
                Easing.InOutSine(0.75f).Should().BeApproximately(0.85355339059327f, 0.0001f);

                Easing.InOutSine(3f, 2, 6).Should().BeApproximately(2.585786437627f, 0.0001f);
                Easing.InOutSine(4f, 2, 6).Should().BeApproximately(4f, 0.0001);
                Easing.InOutSine(5f, 2, 6).Should().BeApproximately(5.41421356237f, 0.0001f);

                Action invalidTime = () => Easing.OutSine(1.5f);
                invalidTime.Should().Throw<ArgumentException>();

                invalidTime = () => Easing.OutSine(7f, 2, 6);
                invalidTime.Should().Throw<ArgumentException>();
            }

            [Test]
            public void OutInSine()
            {
                Easing.OutInSine(0.25f).Should().BeApproximately(0.35355339059327f, 0.0001f);
                Easing.OutInSine(0.5f).Should().BeApproximately(0.5f, 0.0001f);
                Easing.OutInSine(0.75f).Should().BeApproximately(0.64644660940673f, 0.0001f);

                Easing.OutInSine(3f, 2, 6).Should().BeApproximately(3.41421356237f, 0.0001f);
                Easing.OutInSine(4f, 2, 6).Should().BeApproximately(4f, 0.0001f);
                Easing.OutInSine(5f, 2, 6).Should().BeApproximately(4.58578643763f, 0.0001f);

                Action invalidTime = () => Easing.OutSine(1.5f);
                invalidTime.Should().Throw<ArgumentException>();

                invalidTime = () => Easing.OutSine(7f, 2, 6);
                invalidTime.Should().Throw<ArgumentException>();
            }
        }

        public class DoubleTests
        {
            [Test]
            public void Linear()
            {
                Easing.Linear(0.25).Should().Be(0.25);
                Easing.Linear(0.5).Should().Be(0.5);
                Easing.Linear(0.75).Should().Be(0.75);

                Easing.Linear(3.0, 2, 6).Should().Be(3);
                Easing.Linear(4.0, 2, 6).Should().Be(4);
                Easing.Linear(5.0, 2, 6).Should().Be(5);

                CheckDoubleArguments(Easing.Linear, Easing.Linear);
            }

            [Test]
            public void InQuad()
            {
                Easing.InQuad(0.25).Should().Be(0.0625);
                Easing.InQuad(0.5).Should().Be(0.25);
                Easing.InQuad(0.75).Should().Be(0.5625);

                Easing.InQuad(3.0, 2, 6).Should().Be(2.25);
                Easing.InQuad(4.0, 2, 6).Should().Be(3);
                Easing.InQuad(5.0, 2, 6).Should().Be(4.25);

                CheckDoubleArguments(Easing.InQuad, Easing.InQuad);
            }

            [Test]
            public void OutQuad()
            {
                Easing.OutQuad(0.25).Should().Be(0.4375);
                Easing.OutQuad(0.5).Should().Be(0.75);
                Easing.OutQuad(0.75).Should().Be(0.9375);

                Easing.OutQuad(3.0, 2, 6).Should().Be(3.75);
                Easing.OutQuad(4.0, 2, 6).Should().Be(5);
                Easing.OutQuad(5.0, 2, 6).Should().Be(5.75);

                CheckDoubleArguments(Easing.OutQuad, Easing.OutQuad);
            }

            [Test]
            public void InOutQuad()
            {
                Easing.InOutQuad(0.25).Should().Be(0.125);
                Easing.InOutQuad(0.5).Should().Be(0.5);
                Easing.InOutQuad(0.75).Should().Be(0.875);

                Easing.InOutQuad(3.0, 2, 6).Should().Be(2.5);
                Easing.InOutQuad(4.0, 2, 6).Should().Be(4);
                Easing.InOutQuad(5.0, 2, 6).Should().Be(5.5);

                CheckDoubleArguments(Easing.InOutQuad, Easing.InOutQuad);
            }

            [Test]
            public void OutInQuad()
            {
                Easing.OutInQuad(0.25).Should().Be(0.375);
                Easing.OutInQuad(0.5).Should().Be(0.5);
                Easing.OutInQuad(0.75).Should().Be(0.625);

                Easing.OutInQuad(3.0, 2, 6).Should().Be(3.5);
                Easing.OutInQuad(4.0, 2, 6).Should().Be(4);
                Easing.OutInQuad(5.0, 2, 6).Should().Be(4.5);

                CheckDoubleArguments(Easing.OutInQuad, Easing.OutInQuad);
            }

            [Test]
            public void InCubic()
            {
                Easing.InCubic(0.25).Should().Be(0.015625);
                Easing.InCubic(0.5).Should().Be(0.125);
                Easing.InCubic(0.75).Should().Be(0.421875);

                Easing.InCubic(3.0, 2, 6).Should().Be(2.0625);
                Easing.InCubic(4.0, 2, 6).Should().Be(2.5);
                Easing.InCubic(5.0, 2, 6).Should().Be(3.6875);

                CheckDoubleArguments(Easing.InCubic, Easing.InCubic);
            }

            [Test]
            public void OutCubic()
            {
                Easing.OutCubic(0.25).Should().Be(0.578125);
                Easing.OutCubic(0.5).Should().Be(0.875);
                Easing.OutCubic(0.75).Should().Be(0.984375);

                Easing.OutCubic(3.0, 2, 6).Should().Be(4.3125);
                Easing.OutCubic(4.0, 2, 6).Should().Be(5.5);
                Easing.OutCubic(5.0, 2, 6).Should().Be(5.9375);

                CheckDoubleArguments(Easing.OutCubic, Easing.OutCubic);
            }

            [Test]
            public void InOutCubic()
            {
                Easing.InOutCubic(0.25).Should().Be(0.0625);
                Easing.InOutCubic(0.5).Should().Be(0.5);
                Easing.InOutCubic(0.75).Should().Be(0.9375);

                Easing.InOutCubic(3.0, 2, 6).Should().Be(2.25);
                Easing.InOutCubic(4.0, 2, 6).Should().Be(4);
                Easing.InOutCubic(5.0, 2, 6).Should().Be(5.75);

                CheckDoubleArguments(Easing.InOutCubic, Easing.InOutCubic);
            }

            [Test]
            public void OutInCubic()
            {
                Easing.OutInCubic(0.25).Should().Be(0.4375);
                Easing.OutInCubic(0.5).Should().Be(0.5);
                Easing.OutInCubic(0.75).Should().Be(0.5625);

                Easing.OutInCubic(3.0, 2, 6).Should().Be(3.75);
                Easing.OutInCubic(4.0, 2, 6).Should().Be(4);
                Easing.OutInCubic(5.0, 2, 6).Should().Be(4.25);

                CheckDoubleArguments(Easing.OutInCubic, Easing.OutInCubic);
            }

            [Test]
            public void InQuartic()
            {
                Easing.InQuart(0.25).Should().Be(0.00390625);
                Easing.InQuart(0.5).Should().Be(0.0625);
                Easing.InQuart(0.75).Should().Be(0.31640625);

                Easing.InQuart(3.0, 2, 6).Should().Be(2.015625);
                Easing.InQuart(4.0, 2, 6).Should().Be(2.25);
                Easing.InQuart(5.0, 2, 6).Should().Be(3.265625);

                CheckDoubleArguments(Easing.InQuart, Easing.InQuart);
            }

            [Test]
            public void OutQuartic()
            {
                Easing.OutQuart(0.25).Should().Be(0.68359375);
                Easing.OutQuart(0.5).Should().Be(0.9375);
                Easing.OutQuart(0.75).Should().Be(0.99609375);

                Easing.OutQuart(3.0, 2, 6).Should().Be(4.734375);
                Easing.OutQuart(4.0, 2, 6).Should().Be(5.75);
                Easing.OutQuart(5.0, 2, 6).Should().Be(5.984375);

                CheckDoubleArguments(Easing.OutQuart, Easing.OutQuart);
            }

            [Test]
            public void InOutQuartic()
            {
                Easing.InOutQuart(0.25).Should().Be(0.03125);
                Easing.InOutQuart(0.5).Should().Be(0.5);
                Easing.InOutQuart(0.75).Should().Be(0.96875);

                Easing.InOutQuart(3.0, 2, 6).Should().Be(2.125);
                Easing.InOutQuart(4.0, 2, 6).Should().Be(4);
                Easing.InOutQuart(5.0, 2, 6).Should().Be(5.875);

                CheckDoubleArguments(Easing.InOutQuart, Easing.InOutQuart);
            }

            [Test]
            public void OutInQuartic()
            {
                Easing.OutInQuart(0.25).Should().Be(0.46875);
                Easing.OutInQuart(0.5).Should().Be(0.5);
                Easing.OutInQuart(0.75).Should().Be(0.53125);

                Easing.OutInQuart(3.0, 2, 6).Should().Be(3.875);
                Easing.OutInQuart(4.0, 2, 6).Should().Be(4);
                Easing.OutInQuart(5.0, 2, 6).Should().Be(4.125);

                CheckDoubleArguments(Easing.OutInQuart, Easing.OutInQuart);
            }

            [Test]
            public void InQuintic()
            {
                Easing.InQuint(0.25).Should().Be(0.0009765625);
                Easing.InQuint(0.5).Should().Be(0.03125);
                Easing.InQuint(0.75).Should().Be(0.2373046875);

                Easing.InQuint(3.0, 2, 6).Should().Be(2.00390625);
                Easing.InQuint(4.0, 2, 6).Should().Be(2.125);
                Easing.InQuint(5.0, 2, 6).Should().Be(2.94921875);

                CheckDoubleArguments(Easing.InQuint, Easing.InQuint);
            }

            [Test]
            public void OutQuintic()
            {
                Easing.OutQuint(0.25).Should().Be(0.7626953125);
                Easing.OutQuint(0.5).Should().Be(0.96875);
                Easing.OutQuint(0.75).Should().Be(0.9990234375);

                Easing.OutQuint(3.0, 2, 6).Should().Be(5.05078125);
                Easing.OutQuint(4.0, 2, 6).Should().Be(5.875);
                Easing.OutQuint(5.0, 2, 6).Should().Be(5.99609375);

                CheckDoubleArguments(Easing.OutQuint, Easing.OutQuint);
            }

            [Test]
            public void InOutQuintic()
            {
                Easing.InOutQuint(0.25).Should().Be(0.015625);
                Easing.InOutQuint(0.5).Should().Be(0.5);
                Easing.InOutQuint(0.75).Should().Be(0.984375);

                Easing.InOutQuint(3.0, 2, 6).Should().Be(2.0625);
                Easing.InOutQuint(4.0, 2, 6).Should().Be(4);
                Easing.InOutQuint(5.0, 2, 6).Should().Be(5.9375);

                CheckDoubleArguments(Easing.InOutQuint, Easing.InOutQuint);
            }

            [Test]
            public void OutInQuintic()
            {
                Easing.OutInQuint(0.25).Should().Be(0.484375);
                Easing.OutInQuint(0.5).Should().Be(0.5);
                Easing.OutInQuint(0.75).Should().Be(0.515625);

                Easing.OutInQuint(3.0, 2, 6).Should().Be(3.9375);
                Easing.OutInQuint(4.0, 2, 6).Should().Be(4);
                Easing.OutInQuint(5.0, 2, 6).Should().Be(4.0625);

                CheckDoubleArguments(Easing.OutInQuint, Easing.OutInQuint);
            }

            [Test]
            public void InSine()
            {
                Easing.InSine(0.25).Should().BeApproximately(0.076120467488713, 0.0001);
                Easing.InSine(0.5).Should().BeApproximately(0.29289321881345, 0.0001);
                Easing.InSine(0.75).Should().BeApproximately(0.61731656763491, 0.0001);

                Easing.InSine(3, 2, 6).Should().BeApproximately(2.304481869955, 0.0001);
                Easing.InSine(4, 2, 6).Should().BeApproximately(3.17157287525, 0.0001);
                Easing.InSine(5, 2, 6).Should().BeApproximately(4.46926627054, 0.0001);

                CheckDoubleArguments(Easing.InSine, Easing.InSine);
            }

            [Test]
            public void OutSine()
            {
                Easing.OutSine(0.25).Should().BeApproximately(0.38268343236509, 0.0001);
                Easing.OutSine(0.5).Should().BeApproximately(0.70710678118655, 0.0001);
                Easing.OutSine(0.75).Should().BeApproximately(0.92387953251129, 0.0001);

                Easing.OutSine(3, 2, 6).Should().BeApproximately(3.53073372946, 0.0001);
                Easing.OutSine(4, 2, 6).Should().BeApproximately(4.82842712475, 0.0001);
                Easing.OutSine(5, 2, 6).Should().BeApproximately(5.69551813005, 0.0001);

                CheckDoubleArguments(Easing.OutSine, Easing.OutSine);
            }

            [Test]
            public void InOutSine()
            {
                Easing.InOutSine(0.25).Should().BeApproximately(0.14644660940673, 0.0001);
                Easing.InOutSine(0.5).Should().BeApproximately(0.5, 0.0001);
                Easing.InOutSine(0.75).Should().BeApproximately(0.85355339059327, 0.0001);

                Easing.InOutSine(3, 2, 6).Should().BeApproximately(2.585786437627, 0.0001);
                Easing.InOutSine(4, 2, 6).Should().BeApproximately(4, 0.0001);
                Easing.InOutSine(5, 2, 6).Should().BeApproximately(5.41421356237, 0.0001);

                CheckDoubleArguments(Easing.InOutSine, Easing.InOutSine);
            }

            [Test]
            public void OutInSine()
            {
                Easing.OutInSine(0.25).Should().BeApproximately(0.35355339059327, 0.0001);
                Easing.OutInSine(0.5).Should().BeApproximately(0.5, 0.0001);
                Easing.OutInSine(0.75).Should().BeApproximately(0.64644660940673, 0.0001);

                Easing.OutInSine(3, 2, 6).Should().BeApproximately(3.41421356237, 0.0001);
                Easing.OutInSine(4, 2, 6).Should().BeApproximately(4, 0.0001);
                Easing.OutInSine(5, 2, 6).Should().BeApproximately(4.58578643763, 0.0001);

                CheckDoubleArguments(Easing.OutInSine, Easing.OutInSine);
            }
        }
    }
}