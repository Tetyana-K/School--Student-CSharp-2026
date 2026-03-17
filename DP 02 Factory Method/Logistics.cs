using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method // класичний приклад Фабричного Методу = інтерфейс (або  абстрактний клас) для фабричного методу  (Logistics)
                         // + конкретні класи RoadLogistics і SeaLogistics
{
    abstract internal class Logistics // клас абстрактного Фабричного Методу
   {
        abstract public ITransport CreateTransport(int weight);
        public void PlanDelivery(int weight) // конкретний матод Планування Доставки
        {
            ITransport transport = CreateTransport( weight);
            transport.Deliver();
        }
   }
    class RoadLogistics : Logistics // клас конкретного Фабричного Методу
    {
        public override ITransport CreateTransport(int weight)
        {
            if(weight < 7_000)
                return new Truck();
            else
                return new HeavyTruck();

        }
    }
    class SeaLogistics : Logistics
    {
        public override ITransport CreateTransport(int weight)
        {
            return new Ship();
        }
    }
}
