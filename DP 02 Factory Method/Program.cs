// See https://aka.ms/new-console-template for more information
using Factory_Method;
//int weight = 100000;

//ITransport ship = new Ship(); // без патерна,  самі створюємо обэкт, маємо знати тип
//ship.Deliver();

Logistics logistics = new RoadLogistics();
logistics.PlanDelivery(10_000); // через фабричний метод підбереться HeavyTruck
logistics.PlanDelivery(2_000); //  через фабричний метод підбереться Truck?? 

logistics = new SeaLogistics();
logistics.PlanDelivery(10_000); //  через фабричний метод підбереться Ship
