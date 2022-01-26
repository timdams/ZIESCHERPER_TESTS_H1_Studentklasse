using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPClassBasicsTesterLibrary;
using Studentenklasse;

namespace StudentKlasseTests
{
    [TestClass]
    public class UnitTest1
    {
        TimsEpicClassAnalyzer tester = new TimsEpicClassAnalyzer(new Student());
        [TestMethod]
        public void TestAutoProps()
        {
            tester.CheckAutoProperty("Naam", typeof(string));
            tester.CheckAutoProperty("Leeftijd", typeof(int));
            tester.CheckAutoProperty("Klas", typeof(Klassen));
            tester.CheckAutoProperty("PuntenCommunicatie", typeof(int));
            tester.CheckAutoProperty("PuntenProgrammingPrinciples", typeof(int));
            tester.CheckAutoProperty("PuntenWebTech", typeof(int));
        }

        [TestMethod]
        public void TestBerekenTotaalCijfer()
        {
            if (tester.CheckMethod("BerekenTotaalCijfer", typeof(double)))
            {
                int pc = 12;
                int pp = 14;
                int wt = 9;

                tester.SetProp("PuntenCommunicatie", pc);
                tester.SetProp("PuntenProgrammingPrinciples", pp);
                tester.SetProp("PuntenWebTech", wt);
                tester.TestMethod("BerekenTotaalCijfer", null, (pc + pp + wt) / 3.0, $"Punten werden op {pc},{pp} en {wt} gezet.");
            }
        }


        [TestMethod]
        public void TestGeefOverzicht()
        {
            if (tester.CheckMethod("GeefOverzicht", typeof(void)))
            {
                tester.TestMethod("GeefOverzicht", null, null);
                Assert.Fail("Methode GeefOverzicht bestaat en heeft juiste signature. Ik kan helaas (nog) niet controleren wat je op het scherm print, dus deze test zal daarom falen. ");
            }
        }
    }
}
