using StaticApp;

namespace StaticApp {
    public static class MyMath {
        public const double pi = 3.14;

        public static double CircleArea(in double radius) {
            return pi * (radius * radius);
        }
    }
}