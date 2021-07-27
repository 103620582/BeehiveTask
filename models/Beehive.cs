using System.Collections.Generic;

namespace BeehiveTask
{
    public class Beehive
    {

        public List<Bee> Bees { get; set; }
        public int MaxAmt { get; set; }

        public Beehive (int maxAmt) {
            MaxAmt = maxAmt;
            Bees = new List<Bee>();
        }

        public void NewBee (Bee noobie) {
            if (this.Bees.Count < this.MaxAmt) {
                this.Bees.Add(noobie);
            }
            else {
                System.Console.WriteLine("Too many bees!");
            }
        }

        public float CollectHoney (int days) {
            float honey = 0F;
            foreach (Bee noobie in this.Bees) {
                honey += noobie.Size * 0.2F;
            }

            honey *= days;

            return honey;

        }
            

                

            
        

    }
    
}