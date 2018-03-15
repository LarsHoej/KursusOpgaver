using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                ITilfældighedsGenerator m = new TilfældighedsGeneratorMock();
                Console.WriteLine(m.FindTalTilTerning());
                ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
                Console.WriteLine(f.FindTalTilTerning());
            }

            {
                TilfældighedsGeneratorMock m = new TilfældighedsGeneratorMock(1);
                Terning t1 = new Terning(m);
                Console.WriteLine(t1.Værdi);

                TilfældighedsGeneratorFramework f = new TilfældighedsGeneratorFramework();
                Terning t2 = new Terning(f);
                Console.WriteLine(t2.Værdi);
            }

        }
    }

    public interface ITilfældighedsGenerator
    {
        int FindTalTilTerning();
    }

    public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator
    {
        private static System.Random rnd = new System.Random();

        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }

    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        private int tal;
        public TilfældighedsGeneratorMock(int tal)
        {
            this.tal = tal;
        }
        public int FindTalTilTerning()
        {
            return this.tal;
        }
    }

    class Terning
    {
        private ITilfældighedsGenerator generator;

        public int Værdi { get; set; }

        public Terning(ITilfældighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();
        }

        public void Ryst()
        {
            this.Værdi = generator.FindTalTilTerning();
        }
    }
}
