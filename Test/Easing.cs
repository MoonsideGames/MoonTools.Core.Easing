using NUnit.Framework;
using FluentAssertions;

using MoonTools.Core.Easing;
using System;

namespace Test
{
    public class EasingTests
    {
        [Test]
        public void Linear()
        {
            Easing.Linear(0.25f).Should().Be(0.25f);
            Easing.Linear(0.5f).Should().Be(0.5f);
            Easing.Linear(0.75f).Should().Be(0.75f);

            Action invalidTime = () => Easing.Linear(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.Linear(0.25).Should().Be(0.25);
            Easing.Linear(0.5).Should().Be(0.5);
            Easing.Linear(0.75).Should().Be(0.75);

            invalidTime = () => Easing.Linear(1.5);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.Linear(3, 2, 6).Should().Be(3f);
            Easing.Linear(4, 2, 6).Should().Be(4f);
            Easing.Linear(5, 2, 6).Should().Be(5f);

            invalidTime = () => Easing.Linear(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.Linear(3, 2, 6).Should().Be(3);
            Easing.Linear(4, 2, 6).Should().Be(4);
            Easing.Linear(5, 2, 6).Should().Be(5);
        }

        [Test]
        public void InQuad()
        {
            Easing.InQuad(0.25f).Should().Be(0.0625f);
            Easing.InQuad(0.5f).Should().Be(0.25f);
            Easing.InQuad(0.75f).Should().Be(0.5625f);

            Action invalidTime = () => Easing.InQuad(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InQuad(0.25).Should().Be(0.0625);
            Easing.InQuad(0.5).Should().Be(0.25);
            Easing.InQuad(0.75).Should().Be(0.5625);

            invalidTime = () => Easing.InQuad(1.5);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InQuad(3, 2, 6).Should().Be(2.25f);
            Easing.InQuad(4, 2, 6).Should().Be(3f);
            Easing.InQuad(5, 2, 6).Should().Be(4.25f);

            invalidTime = () => Easing.InQuad(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InQuad(3.0, 2, 6).Should().Be(2.25);
            Easing.InQuad(4.0, 2, 6).Should().Be(3);
            Easing.InQuad(5.0, 2, 6).Should().Be(4.25);
        }

        [Test]
        public void OutQuad()
        {
            Easing.OutQuad(0.25f).Should().Be(0.4375f);
            Easing.OutQuad(0.5f).Should().Be(0.75f);
            Easing.OutQuad(0.75f).Should().Be(0.9375f);

            Action invalidTime = () => Easing.OutQuad(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.OutQuad(0.25).Should().Be(0.4375);
            Easing.OutQuad(0.5).Should().Be(0.75);
            Easing.OutQuad(0.75).Should().Be(0.9375);

            invalidTime = () => Easing.OutQuad(1.5);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.OutQuad(3, 2, 6).Should().Be(3.75f);
            Easing.OutQuad(4, 2, 6).Should().Be(5f);
            Easing.OutQuad(5, 2, 6).Should().Be(5.75f);

            invalidTime = () => Easing.OutQuad(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.OutQuad(3.0, 2, 6).Should().Be(3.75);
            Easing.OutQuad(4.0, 2, 6).Should().Be(5);
            Easing.OutQuad(5.0, 2, 6).Should().Be(5.75);
        }

        [Test]
        public void InOutQuad()
        {
            Easing.InOutQuad(0.25f).Should().Be(0.125f);
            Easing.InOutQuad(0.5f).Should().Be(0.5f);
            Easing.InOutQuad(0.75f).Should().Be(0.875f);

            Action invalidTime = () => Easing.InOutQuad(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InOutQuad(0.25).Should().Be(0.125);
            Easing.InOutQuad(0.5).Should().Be(0.5);
            Easing.InOutQuad(0.75).Should().Be(0.875);

            invalidTime = () => Easing.InOutQuad(1.5);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InOutQuad(3, 2, 6).Should().Be(2.5f);
            Easing.InOutQuad(4, 2, 6).Should().Be(4f);
            Easing.InOutQuad(5, 2, 6).Should().Be(5.5f);

            invalidTime = () => Easing.InOutQuad(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.InOutQuad(3.0, 2, 6).Should().Be(2.5);
            Easing.InOutQuad(4.0, 2, 6).Should().Be(4);
            Easing.InOutQuad(5.0, 2, 6).Should().Be(5.5);
        }

        [Test]
        public void OutInQuad()
        {
            Easing.OutInQuad(0.25f).Should().Be(0.375f);
            Easing.OutInQuad(0.5f).Should().Be(0.5f);
            Easing.OutInQuad(0.75f).Should().Be(0.625f);

            Action invalidTime = () => Easing.OutInQuad(1.5f);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.OutInQuad(0.25).Should().Be(0.375);
            Easing.OutInQuad(0.5).Should().Be(0.5);
            Easing.OutInQuad(0.75).Should().Be(0.625);

            Easing.OutInQuad(3, 2, 6).Should().Be(3.5f);
            Easing.OutInQuad(4, 2, 6).Should().Be(4f);
            Easing.OutInQuad(5, 2, 6).Should().Be(4.5f);

            invalidTime = () => Easing.OutInQuad(7, 2, 6);
            invalidTime.Should().Throw<ArgumentException>();

            Easing.OutInQuad(3.0, 2, 6).Should().Be(3.5);
            Easing.OutInQuad(4.0, 2, 6).Should().Be(4);
            Easing.OutInQuad(5.0, 2, 6).Should().Be(4.5);
        }
    }
}