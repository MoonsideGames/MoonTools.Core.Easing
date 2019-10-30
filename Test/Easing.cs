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
        }
    }
}