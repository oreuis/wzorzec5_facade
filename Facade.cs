using System;

namespace wzorzec5
{
    public class Facade
    {
        protected PierwszySystem system1;
        protected DrugiSystem system2;
        protected TrzeciSystem system3;

        public Facade(PierwszySystem sys1, DrugiSystem sys2, TrzeciSystem sys3)
        {
            this.system1 = sys1;
            this.system2 = sys2;
            this.system3 = sys3;
        }

        public string Operacja()
        {
            string result = "Subsystemy:\n";
            result += this.system1.horanghae();
            result += this.system2.wonranghae();
            result += this.system3.gyulranghae();
            result += this.system1.ity();
            result += this.system2.iwy();
            result += this.system3.imy();
            return result;
        }
    }

    public class PierwszySystem
    {
        public string horanghae()
        {
            return "1: Horanghae!\n";
        }

        public string ity()
        {
            return "1: I Tiger You!\n";
        }
    }
    public class DrugiSystem
    {
        public string wonranghae()
        {
            return "2: Wonranghae!\n";
        }

        public string iwy()
        {
            return "2: I Wonwoo You!\n";
        }
    }

    public class TrzeciSystem
    {
        public string gyulranghae()
        {
            return "3: Gyulranghae!\n";
        }

        public string imy()
        {
            return "3: I Mingyu You!\n";
        }
    }

    class Klient
    {
        public static void k_c(Facade facade)
        {
            Console.Write(facade.Operacja());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            PierwszySystem ssystem1 = new PierwszySystem();
            DrugiSystem ssystem2 = new DrugiSystem();
            TrzeciSystem ssystem3 = new TrzeciSystem();
            Facade facade = new Facade(ssystem1, ssystem2, ssystem3);
            Klient.k_c(facade);
        }
    }
}
