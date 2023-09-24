using web_api_project.Models;

namespace web_api_project.Services;

public static class PizzaService
{
  static List<Pizza> Pizzas { get; }
  static int nextId = 3;
  static PizzaService()
  {
    Pizzas = new List<Pizza>
    {
      new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
      new Pizza { Id = 2, Name = "Calabreza", IsGlutenFree = true }
    };
  }

  public static List<Pizza>? GetAll() => Pizzas;

  public static Pizza? Get(int id) => Pizzas.FirstOrDefault(pizza => pizza.Id == id);

  public static void Add(Pizza pizza)
  {
    pizza.Id = nextId++;
    Pizzas.Add(pizza);
  }

  public static void Delete(int id)
  {
    var pizza = Get(id);

    if (pizza is null)
      return;

    Pizzas.Remove(pizza);
  }

  public static void Update(Pizza pizza)
  {
    var index = Pizzas.FindIndex(item => item.Id == pizza.Id);

    if (index == -1)
      return;

    Pizzas[index] = pizza;
  }
}
