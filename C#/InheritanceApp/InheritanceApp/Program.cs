using System.Linq.Expressions;

namespace InheritanceApp {

    public class A {
        public int num1;
        protected int num2;
        private int num3;

        public A(int num1, int num2, int num3) {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
    }

    public class B : A {
        void Func() {
            this.num1 = 1;
            this.num2 = 2;
        }

        public B() : base(1,2,3) {

        }
    }

    public class Program {
        static void Main() {
            // ExceptionWithStatus
            // enum Status success/warning/error





            //throw new NotFoundException(entityName: nameof(Student))

            //try {
            //    throw new MyCustomException("There is my custom error. don't worry");
            //}
            //catch(MyCustomException ex) {
            //    Console.WriteLine($"Error description: {ex.Description}");
            //}


            //try {
            //    throw new ExceptionWithStatus(ExceptionStatus.warning);
            //}
            //catch (MyCustomException ex) {
            //    Console.WriteLine("MyCustomException");
            //}
            //catch (Exception ex) {
            //    Console.WriteLine("Exception");
            //}



            //A a = new A();
            //a.num1 = 1;

            //B b = new B();
            //b.num1 = 1;
        }
    }
}