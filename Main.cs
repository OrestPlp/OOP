namespace Module1;

interface IPayment
{
   public void Pay(Order order, Transport type);
}
class Program
{
   static void Main()
   {
      DeliveryService service = new DeliveryService();
      service.SetTypes();

      Order order0 = service.CreateOrder("Слон", 2001, 2001);
      Order order1 = service.CreateOrder("Генератор", 2000, 100);
      Order order2 = service.CreateOrder("Пакунок_0", 10, 10);
      Order order3 = service.CreateOrder("Не вибухівка", 10, 20);
      Order order4 = service.CreateOrder("Яблука", 5, 3);

      service.CreateCar();
      service.CreateTruck();
      service.CreateBike();
      service.CreateBike();

      Console.WriteLine("""
      [Тест] Виведення ціни замовлення 'Слон' та 'Пакунок_0'.
             'Слон' не може бути оцінене через вагу.


      """);
     
      service.DisplayCost(order0);
      service.DisplayCost(order2);
 /**/
      Console.WriteLine("""
      [Тест] Виведення порожньої історії перевезень.


      """);
      service.DisplayOrderHistory();

      Console.WriteLine("""
      [Тест] Відправлення замовлення 'Генератор' вантажівкою, картка.
             Замовлення 'Пакунок_0' - велосипедом, готівка
             Спроба відправити замовлення 3 неіснуючою вантажівкою.


      """);
      service.TakeOrder(order1, "truck", new PayCard());
      service.TakeOrder(order2, "bike", new PayCash());
      service.TakeOrder(order3, "truck", new PayCash());
      Console.WriteLine("""
      [Тест] Замовлення 'Генератор' та 'Пакунок_0' - активні.

      """);
      service.DisplayActiveOrders();


      Console.WriteLine("""
      [Тест] Замовлення 'Генератор' завершено.
             Замовлення 'Не вибухівка' відправляється вантажівкою що звільнилась, оплата готівкою.
             Замовлення 'Яблука відпраляється другим велосипедом, оплата карткою.'

      """);
      service.SimulateOrderCompletion(order1);
      service.TakeOrder(order3, "truck", new PayCash());
      service.TakeOrder(order4, "bike", new PayCard());

      Console.WriteLine("""
      [Тест] Замовлення 'Не вибухівка' завершено.
             Виведення виконаних замовлень 'Генератор' та 'Не вибухівка'.
             Замовлення 'Пакунок_0' та 'Яблука' досі активні.

      """);
      service.SimulateOrderCompletion(order3);
      service.DisplayOrderHistory();
      service.DisplayActiveOrders();
      
   }
}
